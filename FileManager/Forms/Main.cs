using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class Form1 : Form
    {
        public static string DbFile = "WorkList.dat";
        public static string ConnectionString = string.Format("Data Source={0};Version=3;", DbFile);


        public Form1()
        {
            InitializeComponent();
        }
 
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SelectedBarMove(btnMain);
            if (!plMain.Controls.Contains(ucMain.Instance))
            {
                plMain.Controls.Add(ucMain.Instance);
                ucMain.Instance.Dock = DockStyle.Fill;
                ucMain.Instance.BringToFront();
            }
            else
                ucMain.Instance.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectedBarMove(btnTrans);
            if (!plMain.Controls.Contains(ucGoogleTrans.Instance))
            {
                plMain.Controls.Add(ucGoogleTrans.Instance);
                ucGoogleTrans.Instance.Dock = DockStyle.Fill;
                ucGoogleTrans.Instance.BringToFront();
            }else
                ucGoogleTrans.Instance.BringToFront();
        }

        private void SelectedBarMove(Button button)
        {
            while (SelectedBar.Top != button.Top)
            {
                if (SelectedBar.Top < button.Top)
                {
                    SelectedBar.Top += 1;
                }
                else if (SelectedBar.Top > button.Top)
                {
                    SelectedBar.Top -= 1;
                }

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
   
            try
            {
                if (!System.IO.File.Exists(DbFile))
                {
                    SQLiteConnection.CreateFile(DbFile);  // SQLite DB 생성
                }
                else  // 기능 동작 여부 확인을 위해서 추가했지만 불필요
                {
                    //MessageBox.Show("DB 생성되어 있습니다");
                    return;
                }

                // 테이블 생성 코드
                SQLiteConnection sqliteConn = new SQLiteConnection(ConnectionString);
                sqliteConn.Open();

                string strsql = "CREATE TABLE IF NOT EXISTS works (type_idx int,title varchar(1024),date varchar(30),state_idx int)";

                SQLiteCommand cmd = new SQLiteCommand(strsql, sqliteConn);
                cmd.ExecuteNonQuery();
                sqliteConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
