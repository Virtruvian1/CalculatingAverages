using System;

namespace CalculatingAverages
{
    class Program
    {
        public static int formula;
        static void Main(string[] args)
        {
            CheckInput();
            var result = Calculate();
            var letterGrade = Grade(result);
            if (formula == 1)
            {
                Console.WriteLine($"The sum of integers is {result}");
            }
            else if (formula == 2 || formula == 3 || formula == 4)
            {
                Console.WriteLine($"The average of grades is {result} -- {letterGrade}");
            }
            else
            {
                Console.WriteLine("Something went wrong.");
            }
        }

        public static int CheckInput()
        {
            bool validInput = false;
            

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
        public static int Calculate()
        {
            bool validInput = false;
            int i, temp; // Counter, Storage
            var n = Iterations(); // Specifies value from Iterations()
            int[] array1 = new int[n];

            for (i = 0; i < n && formula == 1 && formula == 2 && formula == 3; i++)
            { 

                do
                {
                    Console.Write($"Input {i + 1} grades (0-100): ", array1); // Asks for grades
                    temp = int.Parse(Console.ReadLine()); // Accepts grades and store in temp
                    if (temp >= 0 && temp <= 100) // Checks temp if in range
                    {
                        validInput = true; // Verfies true
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!"); // Not an acceptable answer, repeat
                    }
                } while (!validInput);
                array1[i] = temp; // stores temp in array

            }
            for (i = 0; i <= n && formula == 4; i++, n++)
            {

                do
                {
                    Console.Write($"Input {i + 1} grades (0-100): ", array1); // Asks for grades
                    temp = int.Parse(Console.ReadLine()); // Accepts grades and store in temp
                    if (temp >= 0 && temp <= 100) // Checks temp if in range
                    {
                        validInput = true; // Verfies true
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!"); // Not an acceptable answer, repeat
                    }
                    Console.WriteLine("Continue (Y/N)? ");
                    string cont = Console.ReadLine();
                    if (cont == "n" || cont == "N")
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                } while (!validInput);
                array1[i] = temp; // stores temp in array

            }
            // return array1; // returns array
            var userInput = formula; // Checks user input
            if (userInput == 1)
            {
                int sum = 0;
                Array.ForEach(array1, delegate (int count) { sum += count; });
                return sum;
            }
            else if (userInput == 2 || userInput == 3 || userInput == 4)
            {
                int sum = 0;
                Array.ForEach(array1, delegate (int count) { sum += count; });
                int result = sum / array1.Length;
                return result;
            }
            else
                return 0;
        }
        public static int Iterations()
        {
            var userInput = formula; // Check User Input
            if (userInput == 1 || userInput == 2)
            {
                int n = 10;
                return n;
            }
            else if (userInput == 3)
            {
                Console.Write("How many grades do you have? ");
                int n = int.Parse(Console.ReadLine());
                return n;
            }
            else if (userInput == 4)
            {
                int n = 1;
                return n;
            }
            else
                return 10;
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
