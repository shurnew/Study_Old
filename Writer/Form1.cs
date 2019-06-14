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
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string id=textBox1.Text;
            string name = textBox2.Text;
            string mon = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            string date = dateTimePicker1.Value.ToShortDateString();
            string pay = comboBox2.Items[comboBox2.SelectedIndex].ToString();
            if (id!="" && name != "" && mon != "" && date != "" && pay != "") {
                string data = "아이디:{0};이름:{1};월:{2};날짜:{3};요금:{4}";
                list.Add(String.Format(data,id,name,mon,date,pay));
                MessageBox.Show("저장완료");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("D:/data.txt", true);
            for (int i = 0; i < list.Count; i++)
            {
                sw.WriteLine(list[i]);
            }
            sw.Flush();
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
