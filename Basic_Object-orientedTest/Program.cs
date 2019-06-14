using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Object_orientedTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Person.count);
            Person p1=new Person("ssh");
            Person p2 = new Person("sjl");
            Console.WriteLine(Person.count);


            Racer R1 = new Racer("레이서");
            if ((R1 as Person)!= null) {//as 는 null
                
                Console.WriteLine(p2.GetType());
            }

            if (R1 is Person)
            {//bool형 반환

                Console.WriteLine(R1.GetType());
            }

            // Console.WriteLine(R1.GetType());

            Console.WriteLine(p1.Equals(p2));//참조형식은 힙에 할당된 데이터주소를 비교

            Runer R2 = new Runer("뛰기선수");
            R2.Move();
            Person R3 = R2;
            R3.Move();

            DrawT D1 = new DrawT();
            D1.Drawing();

            Console.ReadLine();
        }
    }
}
