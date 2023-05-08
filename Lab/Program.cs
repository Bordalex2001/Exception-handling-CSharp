using System;

namespace Lab
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Class Credit card");
            CreditCard card1 = new CreditCard("1234567890123456", "Benjamin", "Thompson", 445, 4, 27, 1863.56, -5000.00);
            Console.WriteLine();
            card1.Print();
            Console.WriteLine();
        }
    }
}
