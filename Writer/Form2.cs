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

namespace Writer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        class Donation
        {
            public string Id { get; set; }   // Id 라는 속성
            public string Name { get; set; }  // Name 이라는 속성
            public string Grade { get; set; }
            public string Date { get; set; }
            public string Amount { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Donation> list = new List<Donation>();

            StreamReader rb = new StreamReader("D:/data.txt");

            while (!rb.EndOfStream)
            {
                string line=rb.ReadLine();
                string[] col = line.Split(';');

                for (int i = 0; i < col.Length; i++)
                {
                    string[] str = col[i].Split(':') ;
                    col[i] = str[1];
                }

                Donation d = new Donation();
                d.Id = col[0];
                d.Name = col[1];
                d.Grade = col[2];
                d.Date = col[3];
                d.Amount = col[4];

                list.Add(d);
            }

            rb.Close();
            dataGridView1.DataSource = list;

        }
    }
}
