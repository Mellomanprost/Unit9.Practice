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
            var exceptionArray = new Exception[] { new DivideByZeroException(), new IndexOutOfRangeException(), new StackOverflowException(), new FormatException(), new MyException("Собственное исключение.\nНевероятное исключение!") };
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
                            case 0:     // Вариант кода, в котором происходит вызов исключения "DivideByZeroException".
                                //throw exceptionArray[i];
                                Console.WriteLine("Введите первое число: ");
                                var number1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Для вывода ошибки деления на ноль введите 0: ");
                                var number2 = int.Parse(Console.ReadLine());
                                var totalNumber = number1 / number2;
                                continue;
                            case 1:     // Вариант кода, в котором происходит вызов исключения "IndexOutOfRangeException".
                                //throw exceptionArray[i];
                                for (int k = 0; k < 7; k++)
                                {
                                    Console.WriteLine($"Номер {k} в массиве - {exceptionArray[k]}");
                                }
                                continue;
                            case 2:     // Вариант кода, в котором происходит вызов исключения "StackOverflowException". Хотел использовать рекурсию, но для этого нужно делать отдельный try{}catch{} в самом методе.
                                throw exceptionArray[iter];
                            case 3:     // Вариант кода, в котором происходит вызов исключения "FormatException". Дальше время стало поджимать и пришлось вызывать через throw.
                                throw exceptionArray[iter];     
                            case 4:     // Вариант кода, в котором происходит вызов исключения "MyException".
                                throw exceptionArray[iter];
                        }
                    } while (iter < 6);
                }
                catch (DivideByZeroException divByZeroEx)
                {
                    Console.WriteLine($"Блок DivideByZeroException:\nMessage - {divByZeroEx.Message}");
                    Console.WriteLine($"Stack - {divByZeroEx}");
                }
                catch (IndexOutOfRangeException indOutOfRangeEx)
                {
                    Console.WriteLine($"Блок IndexOutOfRangeException:\nMessage - {indOutOfRangeEx.Message}");
                    Console.WriteLine($"Stack - {indOutOfRangeEx}");
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
                    Console.WriteLine("\nЕсли хотите выйти напишите - выход.\nЕсли хотите продолжить нажмите Enter.");
                    string exit = Console.ReadLine();
                    if (exit == "Выход" || exit == "выход")
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
