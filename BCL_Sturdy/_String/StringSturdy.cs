using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace BCL_Sturdy._String
{
    class StringSturdy
    {
        public void PrintString(string str)
        {
            
            Console.WriteLine(str+"은 'a'를 "+(str.Contains("a")?"포함했습니다":"포함하지않았습니다"));
            Console.WriteLine("'a'는 "+str.IndexOf("a")+"번째에 존재합니다");
            Console.WriteLine(str.Split(';'));//배열로 반환
            Console.WriteLine(str.Substring(0,4));
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.Trim());
            Console.WriteLine(str.Length);
        }

        public void BuilderTest(string str) {
            StringBuilder sb = new StringBuilder();
            sb.Append(str);
            for (int i=0;i==20000;i++)
            {
                sb.Append('0');
            }
            Console.WriteLine(sb.ToString());
        }

        public void EncodingTest(string str)
        {
            byte[] buf = Encoding.UTF8.GetBytes(str);

        }
        public void EmailCheck(string str)
        {
            if (str.Contains("@"))
            {
                String[] list = str.Split('@');
                if (list[1].Contains(".")) {
                    Console.WriteLine("허용");
                }
                else
                {
                    Console.WriteLine("잘못됨");
                }
            }
            else
            {
                Console.WriteLine("잘못됨");
            }
        }

        public void EmailCheck2(string str)
        {
            Regex regex = new Regex(@"^([0-9a-zA-A]+)@([0-9a-zA-A]+).([0-9a-zA-A]+){1,}$");
            Console.WriteLine(regex.IsMatch(str));
        }

    }
}
