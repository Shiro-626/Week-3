using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //FOR LOOPS EXAMPLES

            //for (statement1; statement2; statement3){code block to be executed}
            //for (variable; condition; iteration)
            //for (i = 0; i < 11; i++){ Console.WriteLine($"10 x {i} = {10 * i}")}   10 times table
            //for (i=1; i <=5; i++){Console.WriteLine("{0} x {1} = {2}", i, table, (i*table))}   - table is a variable that has been declared beforehand
            //{Console.WriteLine($"{i}x{table}={i*table}")}


            //WHILE LOOPS EXAMPLES

            //while(condition){code block to be executed}
            //int counter = 1; while(i <= 10){Console.WriteLine($"3 x {i} = {3* i}"); i++;}


            //DO WHILE LOOPS EXAMPLES

            //do{code block to be executed} while(condition)
            //int i =1; int xtable= 3; 
            //do{Console.WriteLine($"{i} x {xtable} = {i * xtable}"); i ++} while(i <=10)

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

            //Task 1

            int userNum = 0;

            Console.WriteLine("Please enter a number");
            userNum = Int32.Parse(Console.ReadLine());

            Console.WriteLine("N\t10*N\t100*N\t1000*N");
            Console.WriteLine("\n-\t----\t-----\t------");


            Console.WriteLine("\n\n>>> for loop <<<");
            int i = userNum;
            for (i = userNum; i <= 7; i++)
            {
                Console.WriteLine($"{i}\t{10 * i}\t{100 * i}\t{1000 * i}");

            }


            Console.WriteLine("\n\n>>> while loop <<<");

            int j = userNum;
            while (j <= 7)
            {
                Console.WriteLine($"{j}\t{10 * j}\t{100 * j}\t{1000 * j}");
                j++;
            }

            Console.WriteLine("\n\n>>> do while loop <<<");

            int k = userNum;
            do
            {
                Console.WriteLine($"{k}\t{10 * k}\t{100 * k}\t{1000 * k}");
                k++;

            } while (k <= 7);

            Console.ReadLine();

        }

        public static void Task2()
        {
            //Task2


            int userNum = 0;
            Console.WriteLine("Please enter a number to output a times tables");
            userNum = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"{userNum} Times Table:");
            Console.WriteLine("--------------");


            Console.WriteLine(">>>for loop<<<");
            
            for(int i = 1; i<=12; i++)
            {
                Console.WriteLine($"{i} x {userNum} = {i*userNum}");
            }

            Console.WriteLine(">>>while loop<<<");
            int j = 1;
            while (j <= 12)
            {
                Console.WriteLine($"{j} x {userNum} = {j * userNum}");
                j++;
            }

            Console.WriteLine(">>>do while loop <<<");
            int k = 1;
            do
            {
                Console.WriteLine($"{k} x {userNum} = {k * userNum}");
                k++;

            } while (k <= 12);

            Console.ReadLine();
        }

        public static void Task3()
        {

            //Task3

            Console.WriteLine("Number\tSquare\tCube");
            Console.WriteLine("------\t------\t----");

            Console.WriteLine(">>>for loop<<<");
            for (int i= 0; i <= 10; i++)
            {
                Console.WriteLine($"{i}\t{i*i}\t{i*i*i}");
            }

            Console.WriteLine(">>>while loop<<<");
            int j = 0;
            while (j <= 10)
            {
                Console.WriteLine($"{j}\t{j * j}\t{j * j * j}");
                j++;
            }

            Console.WriteLine(">>>do while loop<<<");
            int k = 0;
            do
            {
                Console.WriteLine($"{k}\t{k*k}\t{k*k*k}");
                k++;

            } while (k <= 10);

            Console.ReadLine();
        }
    }
}
