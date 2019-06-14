using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Type_Cast_control
{
    class CastTest
    {
        public CastTest(int a, float f, char c, string d)
        {
            float q = a;
            // int w = f; //불가능
            int w = (int)f;//가능
            int e = c;//결과값:52(스택) 
            //int r = d;//불가
            Console.WriteLine("암시적 int >float:"+q);
            Console.WriteLine("명시적 float>int:" + w);
            Console.WriteLine("암시적 char>int:" + e);
        }


    }
}
