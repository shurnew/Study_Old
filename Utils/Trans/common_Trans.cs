using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace Utils.Trans
{
    class TT
    {
        //HttpClient client;
        string apikey = "a727184c1a1ae5927c7cc4fc75dd76b4";//api키 입력

        public TT()
        {
            //client = new HttpClient();
            //client.BaseAddress = new Uri("https://kapi.kakao.com/v1/translation/translate");
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public String Translat(string text,string src_lang,string target_lang)
        {

            // 헤더 세팅 : API KEY 적용 KakaoAK+공백+apikey
            string header = "KakaoAK " + apikey;
            string TlText = "";
            #region 카카오 번역
            try
            {
                string apiURL = "https://kapi.kakao.com/v1/translation/translate"; // 장소검색 API
                apiURL += string.Format("?query={0}&src_lang={1}&target_lang={2}",text,src_lang,target_lang);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiURL);
                request.Headers.Add("Authorization", header);
                request.ContentType = "application/json;charset=UTF-8";
                request.Method = "POST";
                request.KeepAlive = true;
                HttpWebResponse wRes;
                using (wRes = (HttpWebResponse)request.GetResponse())
                {
                    Stream respPostStream = wRes.GetResponseStream();
                    StreamReader readerPost = new StreamReader(respPostStream, Encoding.GetEncoding("UTF-8"), true);

                    string strJson = readerPost.ReadToEnd();
                    if (strJson.Contains("translated_text"))
                    {
                        string[] arry = strJson.Split(':');
                        arry[1] = arry[1].Replace("[[\"", "");
                        arry[1] = arry[1].Replace("\"]]}", "");
                        TlText = arry[1];
                    }

                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
            #endregion
            return TlText;
        }
    }
}
