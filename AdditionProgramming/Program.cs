using System;

namespace AdditionProgramming
{
    public struct GetNumbers
    {
        public static int Num_1 { get; set; }
        public static int Num_2 { get; set; }

        public int Calc => (Num_1 + Num_2);
    
        public GetNumbers(int number_1, int number_2)
        {
            Num_1 = number_1;
            Num_2 = number_2;
        }

        public override string ToString()
        {
            return $"{Num_1} + {Num_2} = {Calc}";
        }

    }

    class Program
    {
        public static Random r = new Random();

        static void Main(string[] _)
        {


            GetNumbers n = new GetNumbers();

            GetNumbers.Num_1 += r.Next(0, 10);
            GetNumbers.Num_2 += r.Next(1, 10);

            Console.WriteLine($"Number 1: {GetNumbers.Num_1}");
            Console.WriteLine($"Number 2: {GetNumbers.Num_2}");
            Console.WriteLine();
            
            Console.WriteLine($"What is: {GetNumbers.Num_1} + {GetNumbers.Num_2} ");
            var result = n.ToString();

            var answer = int.Parse(Console.ReadLine());
            if (answer == n.Calc)
            {
                Console.WriteLine($"Correct: {result}");
            }

            Console.ReadLine();

        }
    }
}
