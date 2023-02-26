using System;

namespace endirimcs
{
    internal class Program
    {
        static void Main(string[] args)

        { Console.WriteLine("Mebleq: ");

            int mebleq = Convert.ToInt32(Console.ReadLine());
            if (mebleq < 100)
            {
                Console.WriteLine(mebleq - (mebleq * 5 / 100));
            }
            else if (mebleq > 100 && mebleq < 1000) 
            {
                Console.WriteLine(mebleq - (mebleq * 8 / 100));
            }
            else
            {

                Console.WriteLine(mebleq - mebleq * 10 / 1000);
            }

            
        }
    }
}