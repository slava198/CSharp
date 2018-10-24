using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System;
using System.Collections.Generic;
using static System.Console;
namespace SimpleProject
{
    interface IMyFirstInterface
    {
        string Name  { get; }
        int Age { set; }
        void Print();
    }
    public class A : IMyFirstInterface
    {
        private int age;
        public int Age
        {
            set
            {
                if (value > 18)
                { age = value; }
                else
                {
                    Name = "N/a";
                    age = -1;
                }
            }
            private get { return age; }
        }

        public string Name
        {
            get;
            private set;
            
        }

        public void Print()
        {
            WriteLine($"Class A: {nameof(Name)}={Name}, {nameof(Age)}={Age}");
        }
    }

    public class B : IMyFirstInterface
    {
        private int age;
        public int Age
        {
            set
            {
                if (value > 18)
                { age = value; }
                else
                {
                    Name = "N/a";
                    age = -1;
                }
            }
            private get { return age; }
        }

        public string Name
        {
            get;
            private set;

        }

        public void Print()
        {
            WriteLine($"Class B: {nameof(Name)}={Name}, {nameof(Age)}={Age}");
        }
    }

    public class C : IMyFirstInterface
    {
        private int age;
        public int Age
        {
            set
            {
                if (value > 18)
                { age = value; }
                else
                {
                    Name = "N/a";
                    age = -1;
                }
            }
            private get { return age; }
        }

        public string Name
        {
            get;
            private set;

        }

        public void Print()
        {
            WriteLine($"Class C: {nameof(Name)}={Name}, {nameof(Age)}={Age}");
        }
    }




    abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString()
        {
            return $"\nФамилия: { LastName} Имя: { FirstName} Дата рождения: { BirthDate.ToLongDateString()}";
        }
    }
    abstract class Employee : Human
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"\nДолжность: { Position} Заработная плата: { Salary} $";
        }
    }
    interface IWorker
    {
        bool IsWorking { get; }
        string Work();
    }

interface IManager
    {
        List<IWorker> ListOfWorkers { get; set; }
        void Organize();
        void MakeBudget();
        void Control();
    }
    class Director : Employee, IManager
    {
        public List<IWorker> ListOfWorkers { get; set; }
        public void Control()
        {
            WriteLine("Контролирую работу!");
        }
        public void MakeBudget()
        {
            WriteLine("Формирую бюджет!");
        }
        public void Organize()
        {
            WriteLine("Организую работу!");
        }
    }
    class Seller : Employee, IWorker
    {
        bool isWorking = true;
        public bool IsWorking
        {
            get
            {
                return isWorking;
            }
        }

    public string Work()
        {
            return "Продаю товар!";
        }
    }
    class Cashier : Employee, IWorker
    {
        bool isWorking = true;
        public bool IsWorking
        {
            get
            {
                return isWorking;
            }
        }
        public string Work()
        {
            return "Принимаю оплату за товар!";
        }
    }
    class Storekeeper : Employee, IWorker
    {
        bool isWorking = true;
        public bool IsWorking
        {
            get
            {
                return isWorking;
            }
        }
        public string Work()
        {
            return "Учитываю товар!";

           
}
    }
    class Program
    {
        static void Main(string[] args)
        {
            var array = new IMyFirstInterface[] { new A(), new B(), new C() };

            foreach(var el in array)
            {
                el.Age = 80;
                el.Print();
            }


//            Director director = new Director
//            {
//                LastName = "Doe",
//                FirstName = "John",
//                BirthDate = new DateTime(1998, 10, 12),
//                Position = "Директор",
//                Salary = 12000
//            };
//            IWorker seller = new Seller
//            {
//                LastName = "Beam",
//                FirstName = "Jim",
//                BirthDate = new DateTime(1956, 5, 23),
//                Position = "Продавец",
//                Salary = 3780
//            };
//            if (seller is Employee)
//                WriteLine($"Заработная плата продавца: { (seller as Employee).Salary}");
//            // приведение интерфейсной ссылки
//            // к классу Employee
//            director.ListOfWorkers = new List<IWorker> {
//seller, new Cashier { LastName = "Smith",
//FirstName = "Nicole",
//BirthDate = new DateTime(1956, 5, 23),
//Position = "Кассир", Salary = 3780 },
//new Storekeeper { LastName = "Ross",
//FirstName = "Bob", BirthDate =
//new DateTime(1956, 5, 23),
//Position = "Кладовщик", Salary = 4500 }
//};
//            WriteLine(director);
//            if (director is IManager) // использование
//                                      // оператора is

//        {
//                director.Control();
//            }
//            foreach (IWorker item in director.
//            ListOfWorkers)
//            {
//                WriteLine(item);
//                if (item.IsWorking)
//                {
//                    WriteLine(item.Work());
//                }
//            }
        }
    }
}