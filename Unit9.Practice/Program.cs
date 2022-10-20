using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit9.Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var exceptionArray = new Exception[] { new StackOverflowException(), new MyException("Невероятное исключение!"), new FormatException(), new IndexOutOfRangeException(), new DivideByZeroException() };
            bool checkExit = false;
            int iter = 0;
            do
            {
                try
                {
                    do
                    {
                        switch (iter)
                        {
                            case 0:
                                //throw exceptionArray[i];
                                Console.WriteLine("Введите первое число: ");
                                var number1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Введите второе число: ");
                                var number2 = int.Parse(Console.ReadLine());
                                var totalNumber = number1 / number2;
                                continue;
                            case 1:
                                //throw exceptionArray[i];
                                for (int k = 0; k < 7; k++)
                                {
                                    Console.WriteLine($"Номер {k} в массиве - {exceptionArray[k]}");
                                }
                                continue;
                            case 2:
                                throw exceptionArray[iter];
                                //static void StackOverflow(string text)
                                //{
                                //    StackOverflow(text);
                                //    Console.WriteLine(text);
                                //}
                                //StackOverflow("test");
                                //continue;
                            case 3:
                                throw exceptionArray[iter];
                            case 4:
                                throw exceptionArray[iter];
                        }
                    } while (iter < 6);
                }
                catch (StackOverflowException stackOverflowEx)
                {
                    Console.WriteLine($"Блок ArgumentNullException:\nMessage - {stackOverflowEx.Message}");
                    Console.WriteLine($"Stack - {stackOverflowEx}");
                }
                catch (FormatException argEx)
                {
                    Console.WriteLine($"Блок FormatException:\nMessage - {argEx.Message}");
                    Console.WriteLine($"Stack - {argEx}");
                }
                catch (IndexOutOfRangeException indOutOfRangeEx)
                {
                    Console.WriteLine($"Блок IndexOutOfRangeException:\nMessage - {indOutOfRangeEx.Message}");
                    Console.WriteLine($"Stack - {indOutOfRangeEx}");
                }
                catch (DivideByZeroException divByZeroEx)
                {
                    Console.WriteLine($"Блок DivideByZeroException:\nMessage - {divByZeroEx.Message}");
                    Console.WriteLine($"Stack - {divByZeroEx}");
                }
                catch (MyException myEx)
                {
                    Console.WriteLine($"Блок MyException:\nMessage - {myEx.Message}");
                    Console.WriteLine($"Stack - {myEx}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Блок Exception - {ex}");
                }
                finally
                {
                    Console.WriteLine("Если хотите продолжить нажмите Enter.\nДля выхода напишите - да\nХотите выйти?");
                    string exit = Console.ReadLine();
                    if (exit == "Да" || exit == "да")
                    {
                        checkExit = true;
                    }
                    iter++;
                }

            } while (!checkExit);
        }
    }
    public class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
        }
    }
}
