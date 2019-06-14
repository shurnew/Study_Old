using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeomexWorkManager.Common;
using Npgsql;

namespace GeomexWorkManager.Login
{
    public partial class FrmConfig : UserControl
    {
        private static FrmConfig _instance;
        public static FrmConfig CreateInstance()
        {
            if (_instance == null)
            {
                _instance = new FrmConfig();
            }
            return _instance;
        }


        public FrmConfig()
        {
            InitializeComponent();
        }


        //패널이 표시될 소유주 및 표시방향을 설정
        public void SetOwnerControl(Control owner, DevExpress.Utils.Win.PopupToolWindowAnchor anchor)
        {
            flyoutPanel1.OwnerControl = owner;
            flyoutPanel1.Options.AnchorType = anchor;
        }

        //패널 표시
        public void ShowPanel()
        {
            flyoutPanel1.ShowPopup();
            txtIP.Text=CF.Getini("DBConn", "IP", false);
            txtPort.Text=CF.Getini("DBConn", "Port", false);
            txtDB.Text=CF.Getini("DBConn", "DB", true);
            txtUsername.Text=CF.Getini("DBConn", "ID", true);
            txtPw.Text=CF.Getini("DBConn", "PW", true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flyoutPanel1.HidePopup();
            Form f = flyoutPanel1.OwnerControl as Form;
            f.Activate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CF.Saveini("DBConn","IP",txtIP.Text,false);
            CF.Saveini("DBConn", "Port", txtPort.Text,false);
            CF.Saveini("DBConn", "DB", txtDB.Text,true);
            CF.Saveini("DBConn", "ID", txtUsername.Text,true);
            CF.Saveini("DBConn", "PW", txtPw.Text,true);
            MessageBox.Show("저장완료");
        }

        private void btnConnTest_Click(object sender, EventArgs e)
        {
            string DBConnStr = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4}", txtIP.Text, txtPort.Text, txtUsername.Text, txtPw.Text, txtDB.Text);
            MessageBox.Show(CDB.TestDatabase(DBConnStr)?"접속성공":"접속실패");
               
        }
    }
}
