using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        delegate void WorkDelegate(char arg1,int arg2,int arg3); 

        static void Main(string[] args)
        {
            Methematics meth = new Methematics();
            WorkDelegate work = meth.Calculate;
            work('+', 3, 2);
            work('-', 3, 2);
            work('*', 3, 2);
            work('/', 3, 2);
            Console.ReadLine();
        }
    }
}
