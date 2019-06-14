using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Type_Cast_control
{
    class Control
    {
        int[] Arrint = new int[4];
        string[] name = new string[10];
        int[] Arrint1 = new int[3] {1,2,3};
        int[][] Arrint2 = new int[4][];//가변 배열 배열안 배열

        public void test(int a) {

            switch (a) {
                case 1:
                    Console.Write("하나");
                    break;
                case 2:
                    Console.Write("둘");
                    break;
                case 3:
                    Console.Write("셋");
                    break;
                default :
                    Console.Write("없음");
                    break;
            }
        }

        public void Test2(int n) {
            Console.WriteLine("복합 대입 연산자-------------------------------------");
            n += 5;
            Console.WriteLine("n= n+5: "+n);
            n -= 5;
            Console.WriteLine("n= n-5: " + n);
            n /= 5;
            Console.WriteLine("n= n/5: " + n);
            n *= 5;
            Console.WriteLine("n= n*5: " + n);
            n %= 5;
            Console.WriteLine("n= n%5: " + n);
        }

        public void Test3()
        {
            Console.WriteLine("foreach문");
            foreach (int i in Arrint1) {//i 초기값은 1

                Console.WriteLine("길이:" + Arrint1.Length);
                Console.WriteLine(i);

                if (i==Arrint1.Length)//
                {
                    Console.WriteLine("끝");
                 
                }

            }
        }
    }
}
