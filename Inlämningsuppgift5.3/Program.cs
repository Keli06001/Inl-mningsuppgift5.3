using System;

namespace Inlämningsuppgift5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] heltalArray = new int[3];

            for (int i = 0; i < heltalArray.Length; i++)
            {
                Console.Write($"Ange heltal {i + 1}: ");
                heltalArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int summa = heltalArray[0] + heltalArray[1] + heltalArray[2];

            Console.WriteLine($"Summan av de tre heltalen är: {summa}");

        }
    }
}
