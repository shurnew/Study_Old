using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using Google.Cloud.Translation.V2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
  
                Program p = new Program();
                p.AuthExplicit("maximal-digit-225901", "D:\\C_Projects\\Basic_Consle01\\My First Project-81d15a3666fd.json");
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                TranslationClient client = TranslationClient.Create();
                var response = client.TranslateText("Hello World.", "kr");
                Console.WriteLine(response.TranslatedText);
  
            Console.ReadLine();

        }

        public object AuthExplicit(string projectId, string jsonPath)
        {
            // Explicitly use service account credentials by specifying 
            // the private key file.
            var credential = GoogleCredential.FromFile(jsonPath);
            var storage = StorageClient.Create(credential);
            // Make an authenticated API request.
            var buckets = storage.ListBuckets(projectId);
            foreach (var bucket in buckets)
            {
                Console.WriteLine(bucket.Name);
            }
            return null;
        }
  
    }
}
