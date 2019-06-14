using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_ChatServer
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(ServerThread);
            t.Start();
        }

        public void ServerThread()
        {
            using (Socket SvrSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(txtIP.Text), Convert.ToInt32(txtPort.Text));
                SvrSocket.Bind(endPoint);
                SvrSocket.Listen(10);
                Socket CliSocket = SvrSocket.Accept();
                while (true)
                {
                    byte[] recvBytes = new byte[1024];
                    int nRecv = CliSocket.Receive(recvBytes);
                    string msg = Encoding.UTF8.GetString(recvBytes, 0, nRecv);
                    if (msg=="Exit")
                    {
                        break;
                    }
                    Console.WriteLine(msg);

                    byte[] sendBytes = Encoding.UTF8.GetBytes("서버:" + msg);
                    CliSocket.Send(sendBytes);

                    
                }
                Client.Close();
            }
        }

        Socket Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private void button3_Click(object sender, EventArgs e)
        {
       
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(txtCliIP.Text), Convert.ToInt32(txtCliPort.Text));
            Client.Connect(endPoint);

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Client.Connected)
            {
                byte[] sendBytes = Encoding.UTF8.GetBytes("Exit");
                Client.Send(sendBytes);
            }
            Console.WriteLine("클라종료");
            Client.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Client.Connected)
            {
                byte[] sendBytes = Encoding.UTF8.GetBytes(textEdit5.Text);
                Client.Send(sendBytes);
            }
            byte[] recvBytes = new byte[1024];
            int nRecv = Client.Receive(recvBytes);
            string msg = Encoding.UTF8.GetString(recvBytes, 0, nRecv);
            Console.WriteLine(msg);
        }
    }
}
