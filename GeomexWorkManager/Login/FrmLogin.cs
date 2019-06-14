using GeomexWorkManager.Common;
using GeomexWorkManager.Login;
using GeomexWorkManager.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeomexWorkManager
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            FrmConfig frmConfig = FrmConfig.CreateInstance();
            frmConfig.SetOwnerControl(this, DevExpress.Utils.Win.PopupToolWindowAnchor.Right);
            frmConfig.ShowPanel();
        }

        private void FrmLogin_Activated(object sender, EventArgs e)
        {
            CF.Loadini();
            lbState.Text= CDB.TestDatabase(CV.DBConn) ? "연결가능" : "연결불가";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string sSql = string.Format("select * from users where user_id = '{0}' and user_pw = '{1}'",txtID.Text,txtPw.Text);
            Console.WriteLine("로그인시작"+sSql);
                
            Console.WriteLine("검증완료");

           using (DataTable dt = CDB.ExcuteDataTable(sSql))
           {
                if (dt.Rows.Count != 0 || dt.Rows.Count > 1)
                {
                    DataRow dr = dt.Rows[0];
                    CV.sesson = new UserSesson(dr["user_id"].ToString(), dr["user_pw"].ToString(), dr["user_name"].ToString(), DateTime.Now, dr["user_auth"].ToString());
                    this.Hide();
                    FrmMain frmMain = new FrmMain();
                    frmMain.Show();
                }
                else
                {
                    MessageBox.Show("로그인 실패");
                }
           }
           

        }
    }
}
