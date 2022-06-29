using System;

namespace Calculator
{
    internal class Program
    {
        static void info()
        {

            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division \n");

        }

        static void Main(string[] args)
        {




            do
            {
                info();



                int action = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 1st num");
                double num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd num");
                double num2 = Convert.ToInt32(Console.ReadLine());
                double result = 0;

                switch (action)
                {

                    case 1:
                        {
                            addition(num1, num2, result);

                            break;

                        }

                    case 2:
                        {
                            subtraction(num1, num2, result);


                            break;

                        }

                    case 3:
                        {
                            multiplication(num1, num2, result);

                            break;

                        }

                    case 4:
                        {
                            division(num1, num2, result);

                            break;

                        }

                    default:
                        Console.WriteLine("Wrong action!! try again");

                        break;

                }


                Console.WriteLine("Press any key to continue or prees e  then enter to Shut Down...");


            }

            while (Console.ReadKey().Key != ConsoleKey.E);
            Console.ReadLine();

            //  Addition 
            void addition(double num1, double num2, double result)
            {

                result = num1 + num2;
                Console.WriteLine("The result is {0}", result);
            }

            //  Subtraction
            void subtraction(double num1, double num2, double result)
            {

                result = num1 - num2;
                Console.WriteLine("The result is {0}", result);
            }


            //  Multiplication
            void multiplication(double num1, double num2, double result)
            {

                result = num1 * num2;
                Console.WriteLine("The result is {0}", result);

            }

            // Division
            void division(double num1, double num2, double result)
            {


                try
                {


                    result = num1 / num2;
                    if (num1 == 0 || num2 == 0)
                    {
                        Console.WriteLine("Division is not accepted by zero ");

                    }

                    else
                    {
                        Console.WriteLine(num1 / num2);


                    }
                }
                catch (Exception ex)
                {
                    string message = "Division is not accepted by zero ";

                    Console.WriteLine(message);

                }
            }

        }
    }
}
