using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            string strMsg = "Hi dude!" + (char)10;

            strMsg += "Please select the task from list below:" + (char)10; 
            strMsg += "1. Task No 1" + (char)10;
            strMsg += "2. Task No 2" + (char)10;
            strMsg += "3. Task No 3" + (char)10;
            strMsg += "4. Task No 4" + (char)10;
            strMsg += "5. Task No 5" + (char)10;
            strMsg += "6. Task No 6" + (char)10;
            strMsg += "7. Task No 7" + (char)10;
            strMsg += "8. Task No 8" + (char)10;
            strMsg += "9. Recursive Fibonacci" + (char)10;
            strMsg += "or press any key to exit" + (char)10;

            Console.WriteLine(strMsg);


            string strChoice = Console.ReadLine();


            if (strChoice != "")
            {
                int intChoice = int.Parse(strChoice);

                switch (intChoice)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("" + (char)10 + "Enter numbers");

                        Console.WriteLine("A = ");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "B = ");
                        b = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "Result of this task is:" + (char)10 + task_1(a, b) + (char)10 + (char)10 + "Press any key to exit...");

                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("" + (char)10 + "Enter numbers");

                        Console.WriteLine("A = ");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "B = ");
                        b = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "C = ");
                        c = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "Result of this task is:" + (char)10 + task_2(a, b, c) + (char)10 + (char)10 + "Press any key to exit...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("" + (char)10 + "Enter numbers");

                        Console.WriteLine("A = ");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "B = ");
                        b = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "C = ");
                        c = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "Result of this task is:" + (char)10 + task_3(a, b, c) + (char)10 + (char)10 + "Press any key to exit...");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("" + (char)10 + "Enter numbers");

                        Console.WriteLine("A = ");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "B = ");
                        b = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "C = ");
                        c = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "Result of this task is:" + (char)10 + task_4(a, b, c) + (char)10 + (char)10 + "Press any key to exit...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("" + (char)10 + "Enter numbers");

                        Console.WriteLine("A = ");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "B = ");
                        b = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "C = ");
                        c = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "Result of this task is:" + (char)10 + task_5(a, b, c) + (char)10 + (char)10 + "Press any key to exit...");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("" + (char)10 + "Enter numbers");

                        Console.WriteLine("A = ");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "B = ");
                        b = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "C = ");
                        c = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "Result of this task is:" + (char)10 + task_6(a, b, c) + (char)10 + (char)10 + "Press any key to exit...");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("" + (char)10 + "Enter numbers");

                        Console.WriteLine("A = ");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "B = ");
                        b = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "C = ");
                        c = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "Result of this task is:" + (char)10 + task_7(a, b, c) + (char)10 + (char)10 + "Press any key to exit...");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("" + (char)10 + "Enter numbers");

                        Console.WriteLine("A = ");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "B = ");
                        b = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "C = ");
                        c = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "Result of this task is:" + (char)10 + task_8(a, b, c) + (char)10 + (char)10 + "Press any key to exit...");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.WriteLine("" + (char)10 + "Enter position you'd like to discover");

                        Console.WriteLine("Position will be ");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine("" + (char)10 + "Member of Fibonacci sequence under number " + a + " is:" + (char)10 + Recurs_fib(a) + (char)10 + (char)10 + "Press any key to exit...");
                        Console.ReadKey();
                        break;
                }
            }

            double task_1(double A, double B)
            {
                if (A!=B)
                {
                    if (A < B) return -1;
                        return 1;
                }
                return 0;
            }


            double task_2(double A, double B, double C)
            {
                if (C != 0)
                {
                    if (C < 0) return 1;
                    return A+B;
                }
                return A;
            }

            double task_3(double A, double B, double C)
            {
                 if (B <2 && B >=-2) return Math.Pow(A,2);
                    return Math.Pow(A + C,2);        
            }

            object task_4(double A, double B, double C)
            {
                if (B == 1) return Math.Pow(A, 2) + 4*B+C;
                if (B == 2) return 1/(2*A+c);
                return "Entered values didn't return any result.";
            }

            object task_5(double A, double B, double C)
            {
                if (A >= B) return (A - (b / 2)) / (2 * Math.Pow(A + C, 2));
                        
                return Math.Sqrt(A+Math.Pow(B+1,2));
                
            }

            object task_6(double A, double B, double C)
            {
                if (A == 1) return Math.Log(B+C)/Math.Sqrt((Math.Abs(A)+Math.Abs(B)));
                if (A == 2 || A == 3) return Math.Pow(A - C,1/4);
                return "Entered values didn't return any result.";
            }

            object task_7(double A, double B, double C)
            {
                if (B <= A) return 2*Math.Cos(A + C);
                if (B > A) return (A*B)/2*(A-C);
                return "Entered values didn't return any result.";
            }

            object task_8(double A, double B, double C)
            {
                if (A < C) return (A - (B/2))/(2*(A + B));
                if (A >= C*B) return Math.Pow(Math.Sin(A),2)+ Math.Pow(Math.Cos(C), 2);
                return "Entered values didn't return any result.";
            }

            int Recurs_fib(double A)
            {
                if (A == 0 || A == 1) return 1;               
                return Recurs_fib(A - 1) + Recurs_fib(A - 2);
            }

            Tuple<double, double> get_2_values()
            {
                Console.WriteLine("" + (char)10 + "Enter numbers");

                Console.WriteLine("A = ");
                double num1 = double.Parse(Console.ReadLine());
                

                Console.WriteLine("" + (char)10 + "B = ");
                double num2 = double.Parse(Console.ReadLine());


                return Tuple.Create(num1,num2);

                    }
        }   
    }
}
