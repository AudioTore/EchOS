using System;
using System.Threading;

namespace EchOS
{

    class Calculator
    {

        // Important for labels.
        private static string num1;
        private static string num2;

        private static Double a;
        private static Double a1;

        private static Double answer;
        public static void calculator()
        {

            while (true)
            {

                // Tryparse will see if input is a vaild number.

                Console.Write("Enter your a number: ");
                num1 = Console.ReadLine();


                if (Double.TryParse(num1, out a))
                {

                    goto start;

                }

                else
                {

                    Console.WriteLine("Input invaild..");

                }

            start:
                while (true)
                {

                    Console.Write("Enter another number: ");
                    num2 = Console.ReadLine();

                    if (Double.TryParse(num2, out a1))
                    {

                        Console.Clear();
                        goto end;

                    }

                    else
                    {

                        Console.WriteLine("Input invaild..");

                    }

                }


            end:
                while (true)
                {

                    Console.WriteLine("[+, - /, *]");
                    Console.Write("Enter a operation: ");

                    string op = Console.ReadLine();

                    if (op == "+")
                    {

                        Console.Clear();
                        answer = a + a1;
                        Console.WriteLine("Answer: " + answer);
                        Thread.Sleep(1000);

                        Cmdman.Clear_Src();
                        return;

                    }

                    else if (op == "-")
                    {

                        Console.Clear();
                        answer = a - a1;
                        Console.WriteLine("Answer: " + answer);
                        Thread.Sleep(1000);

                        Cmdman.Clear_Src();
                        return;

                    }

                    else if (op == "/") // Test this when you get back.
                    {

                        Console.Clear();
                        answer = a / a1;
                        Console.WriteLine("Answer: " + answer);
                        Thread.Sleep(1000);

                        Cmdman.Clear_Src();
                        return;

                    }

                    else if (op == "*")
                    {

                        Console.Clear();
                        answer = a * a1;
                        Console.WriteLine("Answer: " + answer);
                        Thread.Sleep(1000);

                        Cmdman.Clear_Src();
                        return;

                    }

                    else
                    {

                        Console.WriteLine("Invaild command..");

                    }

                }

            }

        }

        public static void Main(String[] args)
        {

            Console.Clear();

            while (true)
            {

                Console.WriteLine("You are about to open the Calculator. Continue?");
                Console.Write("[YES/NO]: ");
                string input = Console.ReadLine();

                if (input == "YES")
                {

                    Console.Clear();
                    calculator();
                    break;

                }

                else if (input == "NO")
                {
                    Cmdman.Clear_Src();
                    Console.WriteLine("Going back..");
                    break;

                }

                else
                {

                    Console.WriteLine("Invaild command..");

                }

            }

        }

    }

}
