using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Methematics
    {
        delegate int CalcDelegate(int x,int y);

        static int Add(int x, int y) { return x + y; }
        static int Subract(int x, int y) { return x - y; }
        static int Multply(int x, int y) { return x * y; }
        static int Divide(int x, int y) { return x / y; }

        CalcDelegate[] methods;

        public Methematics()
        {
            methods = new CalcDelegate[] { Methematics.Add, Methematics.Subract, Methematics.Multply, Methematics.Divide };
        }

        public void Calculate(char opCode,int operand1, int operand2)
        {
            switch (opCode)
            {
                case '+':
                    Console.WriteLine("+ : " + methods[0](operand1,operand2));
                    break;
                case '-':
                    Console.WriteLine("- : " + methods[1](operand1, operand2));
                    break;
                case '*':
                    Console.WriteLine("* : " + methods[2](operand1, operand2));
                    break;
                case '/':
                    Console.WriteLine("/ : " + methods[3](operand1, operand2));
                    break;
            }
        }
    }
}
