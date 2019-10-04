using System;

namespace Arrays_uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write five numbers");
            int[] Number = new int[5];
            for(int i = 0; i < 5; i++)
            {
              string inputString = Console.ReadLine();
                Number[i] = int.Parse(inputString);
            }
            Console.WriteLine();
            for(int i = 4; i >= 0; i--)
            {
                Console.WriteLine(Number[i] + " ");
            }

        }
    }
}
