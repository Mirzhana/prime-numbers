using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string Number = Console.ReadLine();
            string[] Array = Number.Split(' ');
            for (int i = 0; i < Array.Length; ++i)
            {
                string ElementST = Array[i];
                int Element = Convert.ToInt32(ElementST);
                bool value = IsPrime(Element);
                if (value)
                {
                    Console.WriteLine(Element +"Is Prime");
                }
                else
                {
                    Console.WriteLine(Element + "Is NOT Prime");
                }
            }Console.ReadKey();
        }

        private static bool IsPrime(int s)
        {
            bool ok = false;
            for(int j=2; j<=Math.Sqrt(s); ++j)
            {
                if (s % j == 0)
                {
                    ok = true;
                    break;
                } 
            }
            return ok;
        }
    }
}
