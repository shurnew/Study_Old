using Sundance.Interop.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VurixSample.CCTV
{
    class VMSConn
    {
        
        public WebLiveViewer Conn { get; set; }
        public string IP { get; set; }
        public int Port { get; set; }
        public string ID { get; set; }
        public string PW { get; set; }

        public VMSConn( string iP, int port, string iD, string pW)
        {
            IP = iP;
            Port = port;
            ID = iD;
            PW = pW;
            Conn = new WebLiveViewer();
            Conn.CreateControl();
          //  Conn.Connect("122.199.233.181", 8738, "test", "test00");
        }
    }
}
