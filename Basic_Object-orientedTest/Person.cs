using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Object_orientedTest
{
    class Person
    {
        public string name;
        static public int count ;
        static public Person President;

        public Person(string name)
        {
            Console.WriteLine("생성");
            count++;
            this.name = name;
        }

        static Person() {//최초 프로그램 실행시 가장먼저 로드 
            Console.WriteLine("대통령");
            President = new Person("대통령");//기존 생성자 호출
        }

        public void Move() {
            Console.WriteLine("걷는다");
        }

    }
    class Racer : Person
    {
        public Racer(string name) : base(name)
        {
            base.name = name;
          
        }

    }

    class Runer : Person
    {
        public Runer(string name) : base(name)
        {
            base.name = name;
        }

        new public void Move() {//오버라이드하지않음
            Console.WriteLine("뛰어간다");
        }

    }
}
