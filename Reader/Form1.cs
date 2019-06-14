using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID","id");
            dataGridView1.Columns.Add("name", "이름");
            dataGridView1.Columns.Add("mon", "월");
            dataGridView1.Columns.Add("date", "날짜");
            dataGridView1.Columns.Add("pay", "요금");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            StreamReader rd = new StreamReader("D:/data.txt");

            while (!rd.EndOfStream)
            {
                String line=rd.ReadLine();
                String[] col = line.Split(';');
                for(int i=0;i<5;i++){
                    string[] str = col[i].Split(':');
                    col[i] = str[1];
                }
                dataGridView1.Rows.Add(col[0],col[1], col[2], col[3], col[4]);
            }
            rd.Close();
        }
    }
}
