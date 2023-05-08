using System;
using System.ComponentModel;

namespace Homework
{
    class Program
    {
        static void Task3() //Задание 3
        {
            Console.WriteLine("Class Passport");
            Passport passport1 = new Passport("hy356942", "USA", "George", "Baker", 'M', "04.05.1974", "Chicago, USA", "16.06.2003", "16.06.2013");
            Console.WriteLine();
            passport1.Print();
            Console.WriteLine();
        }
        static void Task4() //Задание 4
        {
            Console.Write("Enter a simple inequality: ");
            string inequality = " "; 
            inequality = Console.ReadLine(); //Ввод неравенства в строку
            bool checkInequality = false; //Проверка неравенства
            try
            {
                if (inequality.Contains("<")) 
                {
                    try
                    {
                        if (inequality.Contains("<=")) //Если в строке есть знаки меньше и равно
                        {
                            char[] less_equal = { '<', '=' };
                            string[] elem = inequality.Split(less_equal);
                            int num1 = int.Parse(elem[0]);
                            int num2 = int.Parse(elem[2]);
                            checkInequality = num1 <= num2;
                        }
                        else //Если в строке есть только знак меньше
                        {
                            string[] elem = inequality.Split('<');
                            int num1 = int.Parse(elem[0]);
                            int num2 = int.Parse(elem[1]);
                            checkInequality = num1 < num2;
                        }
                    }
                    catch (FormatException ex) //Исключение при вводе значения не того типа данных
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (inequality.Contains(">"))
                {
                    try
                    {
                        if (inequality.Contains(">=")) //Если в строке есть знаки больше и равно
                        {
                            char[] greater_equal = { '>', '=' };
                            string[] elem = inequality.Split(greater_equal);
                            int num1 = int.Parse(elem[0]);
                            int num2 = int.Parse(elem[2]);
                            checkInequality = num1 >= num2;
                        }
                        else //Если в строке есть только знак больше
                        {
                            string[] elem = inequality.Split('>');
                            int num1 = int.Parse(elem[0]);
                            int num2 = int.Parse(elem[1]);
                            checkInequality = num1 > num2;
                        }
                    }
                    catch (FormatException ex) //Исключение при вводе значения не того типа данных
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (inequality.Contains("="))
                {
                    try
                    {
                        if (inequality.Contains("!=")) //Если в строке есть восклицательный знак и знак равно (знак неравно)
                        {
                            char[] not_equal = { '!', '=' };
                            string[] elem = inequality.Split(not_equal);
                            int num1 = int.Parse(elem[0]);
                            int num2 = int.Parse(elem[2]);
                            checkInequality = num1 != num2;
                        }
                        else //Если в строке есть только знак равно
                        {
                            string[] elem = inequality.Split('=');
                            int num1 = int.Parse(elem[0]);
                            int num2 = int.Parse(elem[1]);
                            checkInequality = num1 == num2;
                        }
                    }
                    catch (FormatException ex) //Исключение при вводе значения не того типа данных
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    throw new Exception("Operation is not available.");
                }
            }
            catch (Exception ex) //Исключение при вводе недопустимого оператора или символа
            {
                Console.WriteLine($"{ex.Message}");
            }
            Console.WriteLine(checkInequality); //Вывод результата
        } 
        static void Main()
        {
            Task3();
            //Task4();
        }
    }
}
