using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GeomexWorkManager.Common
{
    class CF
    {
        //[DLL 함수] INI DLL 로드
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);
        [DllImport("kernel32")]
        public static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

        public static string Getini(string Section, string Key,bool bDicoding)
        {
            string Value = "";
            StringBuilder sb = new StringBuilder(1000);
            GetPrivateProfileString(Section, Key, "", sb, 1000, CV.PathConfig + "Config.ini");
            Value = sb.ToString();

            if (bDicoding&&Value!="")
            {
                byte[] bytes = Convert.FromBase64String(Value);
                string[] strAry = Encoding.Unicode.GetString(bytes).Split('.');
                Value = strAry[1];
            }
            return Value;
        }

        public static void Saveini(string Section, string Key, string Value, bool bEncoding)
        {
            DirectoryInfo di = new DirectoryInfo(CV.PathConfig);
            if (di.Exists==false)
            {
                di.Create();
            }

            if (bEncoding) {
                byte[] bytes = Encoding.Unicode.GetBytes("!@#$%SSH."+Value+ ".!@#$%SSH");
                Value = Convert.ToBase64String(bytes);
            }

            WritePrivateProfileString(Section, Key, Value, CV.PathConfig+"Config.ini");
        }

        public static void Loadini()
        {
            string IP = CF.Getini("DBConn", "IP", false);
            string Port = CF.Getini("DBConn", "Port", false);
            string DB = CF.Getini("DBConn", "DB", true);
            string ID = CF.Getini("DBConn", "ID", true);
            string PW = CF.Getini("DBConn", "PW", true);
            CV.DBConn=String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4}", IP, Port, ID, PW, DB);

        }

    }
}
