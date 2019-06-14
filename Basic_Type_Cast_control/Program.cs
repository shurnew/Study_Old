using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Type_Cast_control
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeTest T1 = new TypeTest();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            CastTest T2 = new CastTest(1,5.5f,'5',"테스트");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            Control T3 = new Control();
            T3.test(5);
            T3.Test2(10);
            T3.Test3();
            Console.ReadLine();
        }
    }
}
