using Sundance.Interop.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VurixSample.CCTV;

namespace VurixSample
{
    public partial class Main : Form
    {
        private WebLiveViewer viewer;
        private VMSConn conn;
        public List<string> CameraList = new List<string>();

        public Main()
        {
            InitializeComponent();
            Init();
        }

        public void Init() {
            viewer = new WebLiveViewer();
            viewer.CreateControl();
            viewer.Parent = panel1;
            panel1.Controls.Add(viewer);
            viewer.Dock = DockStyle.Fill;
            viewer.Disconnect();
        }

        public void PlayCCTV(String str)
        {        


            viewer.StopLiveVideo();
      
            viewer.StartLiveVideo(int.Parse(str));
        }

        public void StopCCTV()
        {
            if (viewer != null)
            {
                if (viewer.IsConnected)
                {
                    viewer.StopLiveVideo();
                    viewer.Disconnect();
                }
            }
        }



        public void LoadCamara()
        {

            DeviceInformations cctv = viewer.GetCameras();

            for (int i = 0; i < cctv.Count; i++)
            {
                int id = cctv[i].ID;
                string nm = cctv[i].Name;
                int ptz = cctv[i].SupportPTZ ? 1 : 0;
                
                CameraList.Add(string.Format("{0}|{1}|{2}", id, nm, ptz));

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            viewer.Connect(conn.IP,conn.Port,conn.ID,conn.PW);
          
            LoadCamara();
            for (int i = 0; i > CameraList.Count; i++)
            {
               listBox1.Items.Add(CameraList[i]);
            }

               Console.WriteLine("연결완료");
            
       
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i= listBox1.SelectedIndex; 
          
            
            string[] Info = listBox1.Items[i].ToString().Split('|');
            PlayCCTV(Info[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new VMSConn("122.199.233.181", 8738, "test", "test00");

            bool con = conn.Conn.Connect(conn.IP, conn.Port, conn.ID, conn.PW);
            Console.WriteLine(con? "성공":"실패");
        }
    }
}
