using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Sturdy03
{
    class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
            Console.WriteLine("마이익셉션:"+message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            String txt="";

            while (txt!="exit")
            {

                txt = Console.ReadLine();

                // if (string.IsNullOrEmpty(txt) == false)
                //{
                //  Console.WriteLine("사용자:" + txt);
                //}
                try
                {
                    if (txt=="")
                    {
                        MyException e = new MyException("빈값");
                        throw e;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
