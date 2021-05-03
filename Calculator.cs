using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeCalculator
{
    class Calculator
    {
        public static int Add(int one, int two)
        {
            int answer = one + two;
            return answer;
        }
        public static int Subtract(int one, int two)
        {
            return one - two;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
