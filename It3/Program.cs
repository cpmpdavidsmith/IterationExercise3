// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Through()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void Through999()
        {
            for (int i = 3; i <= 999; i++)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void EqualOr(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("These numbers are equal to each other");
            }
            else
            {
                Console.WriteLine("These numbers are not equal to each other");
            }
        }
        //Write a method to check whether a given number is even or odd

        public static void IsEven()
        {
            Console.WriteLine("Enter in a number. Our system will check if it's even or odd.");
            var userInput = int.TryParse(Console.ReadLine(), out int number);
            if (userInput ==true)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("this number is even");
                }
                else
                {
                    Console.WriteLine($"This number is odd");
                }
            }
            else
            {
                Console.WriteLine("Sorry, invalid input");
            }
        }

        public static void EvenOr(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("This number is even");
            }
            else
            {
                Console.WriteLine("This number is odd");
            }
        }
        //Write a method to check whether a given number is positive or negative

        public static void PositiveOr(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("This number is Positive");
            }
            else
            {
                Console.WriteLine("This number is Negative");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void Vote(int num)
        {
            if (num >= 18)
            {
                Console.WriteLine("You are old enough to vote");
            }
            else
            {
                Console.WriteLine("Sorry, You are not old enough to vote");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void Range10(int num)
        {
            if (num > -10 && num < 10)
            {
                Console.WriteLine("This number is within range");
            }
            else
            {
                Console.WriteLine("This number is not within range");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultiTable(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //Through();
            //Through999();
            //EqualOr(5,6);
            //IsEven();
            //EvenOr(6);
            //PositiveOr(-654);
            //Vote(17);
            //Range10(11);
            //MultiTable(5);

        }
    }
}