using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Translate.v2;
using Google.Apis.Services;

namespace FileManager
{
    public partial class ucGoogleTrans : UserControl
    {
        private static ucGoogleTrans _instance;

        private string TransLng = "ko";
        
        public static  ucGoogleTrans Instance
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new ucGoogleTrans();
                }
                return _instance;
            }
        }


        public ucGoogleTrans()
        {
            InitializeComponent();
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            txtOutput.Text = googleTranslate(txtInput.Text,TransLng); 
        }


        #region 구글번역
        public string googleTranslate(string _input, string _code)
        {
            if (_input == "")
            {
                return "";
            }
            var service = new TranslateService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyBvpSXJCzxqrv28PqDwNZbaZiK4w35XbC4"// your API key, that you get from Google Developer Console
            });

            String text_to_translate = _input;
            String target_language_shortname = _code;

            string[] srcText = new[] { text_to_translate };
            var response = service.Translations.List(srcText, target_language_shortname).Execute();

            return response.Translations[0].TranslatedText;
        }

        #endregion

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                TransLng = "ko";
            }
            else if (radioButton2.Checked)
            {
                TransLng = "en";
            }

        }

        private void ucGoogleTrans_MouseEnter(object sender, EventArgs e)
        {
            if (chkAutoTrans.Checked)
            {
                txtInput.Text = Clipboard.GetText();
                txtOutput.Text = googleTranslate(txtInput.Text, TransLng);
            }
        }
    }
}
