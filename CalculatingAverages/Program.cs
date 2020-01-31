using System;

namespace CalculatingAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = CheckInput();
            if (userInput == 1)
            {   
                Console.WriteLine($"The sum of integers is {SumOfNum()}"); // Part 1
            }
            else if (userInput == 2)
            {
                var result = Average();
                var letter = Grade(result);
                Console.WriteLine($"The average of grades is {result} -- {letter}"); // Part 2 // Bug 01: Repeats CheckInput()
            }
            else if (userInput == 3)
            {
                var result = Average();
                var letter = Grade(result);
                Console.WriteLine($"The average of grades is {result} -- {letter}"); // Part 3
            }
            else if (userInput == 4)
            {

            }
        }

        public static int CheckInput()
        {
            bool validInput = false;
            int formula;

            do
            {
                Console.WriteLine("1. Sum of numbers \r\n2. Average ten scores \r\n3. Average a specific number of scores \r\n4. Average a non-specific number of scores"); // Print choices fo formulas
                Console.Write("Input selection [ 1 - 4 ]: _");
                formula = int.Parse(Console.ReadLine());
                if (formula >= 1 && formula <= 4)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }
            } while (!validInput);
            return formula;
        }

        public static int[] GradeInput()
        {
            var userInput = CheckInput();
            bool validInput = false;
            int i, temp, n = 10;
            int[] array1 = new int[n];
            
            if (userInput == 3) // Part 3
            {
                Console.Write("How many grades are you inputing? ");
                int g = int.Parse(Console.ReadLine());
                n = g;
            }
            for (i = 0; i < n; i++)
            {
                do
                {
                    Console.Write($"Input {i + 1} grades (0-100): ", array1);
                    temp = int.Parse(Console.ReadLine());
                    if (temp >= 0 && temp <= 100)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!");
                    }
                } while (validInput == false);
                array1[i] = temp;
            }
            return array1;
        }

        public static int SumOfNum()
        {
            int sum = 0;
            Array.ForEach(GradeInput(), delegate (int i) { sum += i; });
            return sum;
        }

        public static double Average()
        {
            var userInput = CheckInput();
            var sum = SumOfNum();
            var n = 10;
            if (userInput == 3) // Part 3
            {
                Console.Write("How many grades did you input? ");
                int g = int.Parse(Console.ReadLine());
                n = g;
            }
            double avg = sum / n;
            return avg;
        }

        public static string Grade(double grade)
        {
            if (grade >= 0 && grade <= 59)
            {
                return "F";
            }
            else if (grade >= 60 && grade <= 69)
            {
                return "D";
            }
            else if (grade >= 70 && grade <= 79)
            {
                return "C";
            }
            else if (grade >= 80 && grade <= 89)
            {
                return "B";
            }
            else if (grade >= 90 && grade <= 100)
            {
                return "A";
            }
            else
                return null;
        }
    }
}
