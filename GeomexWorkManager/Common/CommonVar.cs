using GeomexWorkManager.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeomexWorkManager.Common
{
    class CV
    {
        public static string PathRoot = Application.StartupPath + @"\";
        public static string PathConfig = PathRoot + @"config\";
        public static string DBConn = "";//DB접속
        public static UserSesson sesson;
    }
}
