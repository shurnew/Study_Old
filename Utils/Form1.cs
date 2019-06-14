using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils.Trans;

namespace Utils
{
    public partial class Form1 : Form
    {
        string inputLg = "en";
        string outputLg = "kr";
        TT t = new TT();

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text=t.Translat(textBox1.Text,inputLg,outputLg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string lg =inputLg;
            inputLg = outputLg;
            outputLg = lg;
            button2.Text = inputLg + ">>" + outputLg;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            textBox1.Text=Clipboard.GetText();
            if (checkBox2.Checked)
            {
                textBox2.Text = t.Translat(textBox1.Text, inputLg, outputLg);
            }
        }
    }
}
