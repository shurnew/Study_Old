using Google.Apis.Services;
using Google.Apis.Translate.v2;
using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TESTAPP.Commons
{
    class Common_Func
    {

        #region 구글번역
        public string googleTranslate(string _input,string _code)
        {
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

        #region 유튜브 검색
        public void youtubeSearch(string _input)
        {
            // YouTubeService 객체 생성
            var youtube = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyBvpSXJCzxqrv28PqDwNZbaZiK4w35XbC4"// 키 지정

            });
            // Search용 Request 생성
            var request = youtube.Search.List("snippet");
            request.Q = _input;
            request.MaxResults = 50;

            // Search용 Request 실행
            var result = request.Execute();

            result.GetType();
            List<object> list = new List<object>();

            //return result;
            // Search 결과를 리스트뷰에 담기
            foreach (var item in result.Items)
            {
                if (item.Id.Kind == "youtube#video")
                {

                    list.Add(item.Id.VideoId.ToString(), item.Snippet.Title, 0);
                }
            }

        }
        #endregion

        #region 카카오 번역
        //public String Translat(string text, string src_lang, string target_lang)
        //{
        //    string apikey = "a727184c1a1ae5927c7cc4fc75dd76b4";//api키 입력
        //    // 헤더 세팅 : API KEY 적용 KakaoAK+공백+apikey
        //    string header = "KakaoAK " + apikey;
        //    string TlText = "";

        //    try
        //    {
        //        string apiURL = "https://kapi.kakao.com/v1/translation/translate"; // 장소검색 API
        //        apiURL += string.Format("?query={0}&src_lang={1}&target_lang={2}", text, src_lang, target_lang);
        //        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiURL);
        //        request.Headers = ("Authorization", header);
        //        request.ContentType = "application/json;charset=UTF-8";
        //        request.Method = "POST";
        //        request.KeepAlive = true;
        //        HttpWebResponse wRes;
        //        using (wRes = (HttpWebResponse)request.GetResponse())
        //        {
        //            Stream respPostStream = wRes.GetResponseStream();
        //            StreamReader readerPost = new StreamReader(respPostStream, Encoding.GetEncoding("UTF-8"), true);

        //            string strJson = readerPost.ReadToEnd();
        //            if (strJson.Contains("translated_text"))
        //            {
        //                string[] arry = strJson.Split(':');
        //                arry[1] = arry[1].Replace("[[\"", "");
        //                arry[1] = arry[1].Replace("\"]]}", "");
        //                TlText = arry[1];
        //            }
        //        }
        //    }
        //    catch (WebException ex)
        //    {
        //        Console.WriteLine(ex);
        //    }

        //    return TlText;
        //}
        #endregion
    }
}
