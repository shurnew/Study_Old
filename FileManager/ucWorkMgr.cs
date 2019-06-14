using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FileManager
{
    public partial class ucMain : UserControl
    {
        private static ucMain _instance;

        public static ucMain Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucMain();
                }
                return _instance;
            }
        }

        public ucMain()
        {
            InitializeComponent();
        }



        public void ExcuteQry()
        {
            using (SQLiteConnection conn = new SQLiteConnection(Form1.ConnectionString))
            {
                conn.Open();
                string sql = "INSERT INTO works VALUES (1,'Tom', '2018-09-09',1)";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        private void Select_Reader()
        {
            
            using (var conn = new SQLiteConnection(Form1.ConnectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM works";

                //SQLiteDataReader를 이용하여 연결 모드로 데이타 읽기
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    WorkItem wi = new WorkItem(Convert.ToInt32(rdr["type_idx"].ToString()), rdr["title"].ToString(), rdr["date"].ToString(), Convert.ToInt32(rdr["state_idx"].ToString()));
                    if (rdr["state_idx"].ToString() == "1")
                    {
                        panel1.Controls.Add(wi);
                        wi.Dock = DockStyle.Left;
                        
                    }
                    else if (rdr["state_idx"].ToString() == "2")
                    {
                        panel2.Controls.Add(wi);
                        wi.Dock = DockStyle.Left;
                    }
                
                    //  listBox1.Items.Add(rdr["title"]);
                }
                rdr.Close();
            }
        }

        private static DataSet Select_Adapter()
        {
            DataSet ds = new DataSet();
            string connStr = @"Data Source=C:\Temp\mydb.db";

            //SQLiteDataAdapter 클래스를 이용 비연결 모드로 데이타 읽기
            string sql = "SELECT * FROM member";
            var adpt = new SQLiteDataAdapter(sql, connStr);
            adpt.Fill(ds);

            return ds;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcuteQry();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Select_Reader();
        }
    }
}
