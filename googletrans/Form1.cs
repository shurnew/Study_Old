using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Translate.v2;
using Google.Apis.Services;

namespace googletrans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var service = new TranslateService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyBvpSXJCzxqrv28PqDwNZbaZiK4w35XbC4"// your API key, that you get from Google Developer Console
            });

            String text_to_translate = textBox1.Text;
            String target_language_shortname = "ko";

            string[] srcText = new[] { text_to_translate };
            var response = service.Translations.List(srcText, target_language_shortname).Execute();
            textBox2.Text= response.Translations[0].TranslatedText;

        }
    }
}
