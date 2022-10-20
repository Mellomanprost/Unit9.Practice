using System;
using System.IO;
using System.Collections;


namespace Unit9
{
    /// <summary>
    /// Тестовый вариант практического задания.
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            int num = 0;
            Exception[] exceptionArray = new Exception[] { new ArgumentNullException(), new MyException("Невероятное исключение!"), new ArgumentException(), new IndexOutOfRangeException(), new DivideByZeroException() };
            do
            {
                try
                {
                    for (int i = 0; i < exceptionArray.Length; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                throw exceptionArray[num];
                            case 1:
                                throw exceptionArray[num];
                            case 2:
                                throw exceptionArray[num];
                            case 3:
                                throw exceptionArray[num];
                            case 4:
                                throw exceptionArray[num];
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (ex is ArgumentNullException)
                    {
                        Console.WriteLine("Это - " + ex.GetType());
                        Console.WriteLine(ex.Message);
                    }
                    else if (ex is MyException)
                    {
                        Console.WriteLine("Это - " + ex.GetType());
                        Console.WriteLine(ex.Message);
                    }
                    else if (ex is ArgumentException)
                    {
                        Console.WriteLine("Это - " + ex.GetType());
                        Console.WriteLine(ex.Message);
                    }
                    else if (ex is IndexOutOfRangeException)
                    {
                        Console.WriteLine("Это - " + ex.GetType());
                        Console.WriteLine(ex.Message);
                    }
                    else if (ex is DivideByZeroException)
                    {
                        Console.WriteLine("Это - " + ex.GetType());
                        Console.WriteLine(ex.Message);
                    }
                }
                num++;
            } while (num < 6);
        }
    }

    public class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
        }
    }
}
