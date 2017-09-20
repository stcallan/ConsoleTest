using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First change");
            Console.WriteLine("Second change bugfixing");
            Console.WriteLine("Third change bugfixing");

            var result = IsPalendrome("kayal");
        }

        public static bool IsPalendrome(string input)
        {
            if (input.Length == 1)
            {
                return true;
            }

            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            var chararray = input.ToCharArray();

            for (int i = 0; i < input.Length/2; i++)
            {
                if (chararray[i] != chararray[input.Length -i -1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
