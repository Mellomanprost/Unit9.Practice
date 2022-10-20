using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit9.Practice2
{
    class Program
    {
        public delegate void Notify();
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
            List<string> listOfHuman = new List<string>
            {
                "Сидоров",
                "Иванов",
                "Петров",
                "Бодров",
                "Васильев"
            };

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
                foreach (var item in listOfHuman)
                {
                    Console.WriteLine(item);
                }

            }
            catch(MyException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            MyEvent myEvent = new MyEvent();
            Console.WriteLine("Для сортировки \"А-Я\" введите 1, для сортировки \"Я-А\" введите 2.");
            Console.Write("Выберите тип сортировки: ");
            myEvent.SomeEvent += Handler;
            myEvent.OnSomeEvent();
        }

    }
    class MyException : Exception
    {
        public MyException(string message) : base(message)
        {

        }
    }
}
