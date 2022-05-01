using System;

namespace hELLOwORLD10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //suma cifrelor unui numar intreg
            Console.WriteLine("Introduceti numarul");
            int x = int.Parse(Console.ReadLine());
            int SumaCifrelor = x / 10 + x % 10;
            Console.WriteLine("Suma cifrelor este" + SumaCifrelor); 
        }
    }
}
