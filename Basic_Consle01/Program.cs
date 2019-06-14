using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Consle01
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.Num();
            t.ItemAdd("안");
            t.ItemAdd("녕");
            t.ItemAdd("하");
            t.ItemAdd("세");
            t.ItemAdd("요");
            Console.ReadLine();
        }
    }
}
