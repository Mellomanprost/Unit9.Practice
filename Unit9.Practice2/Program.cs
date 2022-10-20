using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit9.Practice2
{
    /// <summary>
    /// Класс содержащий основной код программы.
    /// </summary>
    class Program
    {
        public delegate void Notify();
        static List<string> listOfHuman = new List<string>      // Список фамлий для сортировки.
            {
                "Сидоров",
                "Иванов",
                "Петров",
                "Бодров",
                "Васильев"
            };

        /// <summary>
        /// Класс объявляющий событие.
        /// </summary>
        class MyEvent
        {
            public event Notify SomeEvent;

            public void OnSomeEvent()
            {
                SomeEvent?.Invoke();
            }
        }

        static void Handler()
        {
            try
            {
                var userChoice = int.Parse(Console.ReadLine());
                if (userChoice == 1)
                {
                    Console.WriteLine("Выбран тип сортировки \"А-Я\"");
                    listOfHuman.Sort();
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("Выбран тип сортировки \"Я-А\"");
                    listOfHuman.Sort();
                    listOfHuman.Reverse();
                }
                else
                    throw new MyException("Введены неверные данные!");
                WriteList(listOfHuman);
            }
            catch (MyException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void WriteList(List<string> humans)
        {
            foreach (var item in humans)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            MyEvent myEvent = new MyEvent();
            Console.WriteLine("Ваш список сотрудников: ");
            WriteList(listOfHuman);
            Console.WriteLine("Для сортировки \"А-Я\" введите 1, для сортировки \"Я-А\" введите 2.");
            Console.Write("Выберите тип сортировки: ");
            myEvent.SomeEvent += Handler;
            myEvent.OnSomeEvent();
        }
    }

    /// <summary>
    /// Свой собственный класс исключения.
    /// </summary>
    class MyException : Exception
    {
        public MyException(string message) : base(message)
        {

        }
    }
}
