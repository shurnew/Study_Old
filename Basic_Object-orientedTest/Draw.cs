using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Object_orientedTest
{
    class DrawT : DrawObject
    {
        public override void Drawing()
        {
            Move();
            Console.WriteLine("삼각형을 그린다");
         }
    }
    abstract class DrawObject
    {
        public abstract void Drawing();
        public void Move() {
            Console.WriteLine("움직인다");
        }
    }


}
