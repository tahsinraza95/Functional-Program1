using System;

namespace Quotient_and_Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int divided = 50, divisor = 8;
            int quotient = divided / divisor;
            int remainder = divided % divisor;
            Console.WriteLine("Dividend:{0} Divisor:{1}",divided,divisor);
            Console.WriteLine("Quotient = + quotient");
            Console.WriteLine("Remainder = + remainder");
            Console.WriteLine();
        }
    }
}
