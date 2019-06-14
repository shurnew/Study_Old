using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtubeTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_ClickAsync(object sender, EventArgs e)
        {
            // YouTubeService 객체 생성
            var youtube = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyBvpSXJCzxqrv28PqDwNZbaZiK4w35XbC4"// 키 지정

            });
            // Search용 Request 생성
            var request = youtube.Search.List("snippet");
            request.Q = textBox1.Text;  
            request.MaxResults = 50;

            // Search용 Request 실행
            var result = request.Execute();

            // Search 결과를 리스트뷰에 담기
            foreach (var item in result.Items)
            {
                if (item.Id.Kind == "youtube#video")
                {
                    listView1.Items.Add(item.Id.VideoId.ToString(), item.Snippet.Title, 0);
                }
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // YouTube 비디오 Play를 위한 URL 생성 
                string videoId = listView1.SelectedItems[0].Name;
                string youtubeUrl = "http://youtube.com/watch?v=" + videoId;

                // 디폴트 브라우져에서 실행
                Process.Start(youtubeUrl);
            }
        }
    }
}
