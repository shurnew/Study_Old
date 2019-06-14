using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class WorkItem : UserControl
    {

        public WorkItem()
        {
            InitializeComponent();
        }

        public WorkItem(int _type, string _title, string _date,int _state)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = _type;
            comboBox2.SelectedIndex = _state;
            textBox1.Text = _title;
            dateTimePicker1.Text = _date;
        }
    }
}
