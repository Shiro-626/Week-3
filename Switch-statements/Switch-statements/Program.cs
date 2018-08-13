using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_statements
{
    class Program
    {
        static void Main(string[] args)
        {

            Boolean restart = true;

            do
            {
                Console.WriteLine("Please choose which task you want to execute");
                Console.WriteLine("For task 1 push 1");
                Console.WriteLine("For task 2 push 2");
                Console.WriteLine("For task 3 push 3");
                int choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Task1();
                }
                else if (choice == 2)
                {
                    Task2();
                }
                else
                {
                    Task3();
                }
                Console.WriteLine("Do you want to run another task, Y/N");

                var check = Console.ReadLine().ToUpper();
                if (check == "N")
                {
                    restart = false;
                }
                Console.Clear();
            } while (restart);
           


        }
        public static void Task1()
        {
            //Task 1 - Guess my favourite pet


            Console.WriteLine("Please enter the name of a animal, to guess my favourite pet");

            string userChoice = Console.ReadLine().ToUpper();

            switch (userChoice)
            {
                case "DOG":
                    Console.WriteLine("Your guess was correct");
                    break;
                case "RABBIT":
                    Console.WriteLine("Your guess was incorrect");
                    break;
                case "CHICKEN":
                    Console.WriteLine("Your guess was incorrect");
                    break;
                case "PARROT":
                    Console.WriteLine("Your guess was incorrect");
                    break;
                default:
                    Console.WriteLine("The animal you entered is an unrecognised pet");
                    break;
            }

            Console.ReadLine();
        }

        public static void Task2()
        {
            //Task 2 - What is the price of the fruit

            Console.WriteLine("Please enter in a fruit variety");

            string fruitChoice = Console.ReadLine().ToUpper();

            switch (fruitChoice)
            {
                case "APPLE":
                    Console.WriteLine("Apples are $1.25 per kg");
                    break;
                case "BANANA":
                    Console.WriteLine("Bananas are $3.15 per kg");
                    break;
                case "KIWIFRUIT":
                    Console.WriteLine("Kiwifruit are $4.65 per kg");
                    break;
                case "ORANGE":
                    Console.WriteLine("Oranges are $2.75 per kg");
                    break;
                default:
                    Console.WriteLine("We do not have that type of fruit");
                    break;
            }

            Console.ReadLine();
        }

        public static void Task3()
        {
            //Task 3 - Calculator


            int result = 0;
            Console.WriteLine("Please enter your first number");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter in an operator");
            string userOperator = Console.ReadLine();

           

            switch (userOperator)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("The operator you entered is unknown");
                    break;
            }

            Console.WriteLine("{0} {1} {2} = {3}", num1, userOperator, num2, result);
            Console.ReadLine();

            /*   int add = num1 + num2;
               int subtract = num1 - num2;
               int multiply = num1 * num2;
               int divide = num1 / num2;

               switch (userOperator)
               {
                   case "+":
                       Console.WriteLine("{0} + {1} = {2}", num1, num2, add);
                       break;
                   case "-":
                       Console.WriteLine("{0} - {1} = {2}", num1, num2, subtract);
                       break;
                   case "*":
                       Console.WriteLine("{0} * {1} = {2}", num1, num2, multiply);
                       break;
                   case "/":
                       Console.WriteLine("{0} / {1} = {2}", num1, num2, divide);
                       break;
                   default:
                       Console.WriteLine("The operator you entered is unknown");
                       break;
               } */


        }
    }
}
