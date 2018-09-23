using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonWork2additional
{
    class Program
    {

        class Car
        {

            public string driver;
            public int currentSpeed;

            public Car(string name = "Michael", int speed = 0)
            {
                driver = name;
                currentSpeed = speed;

            }
            
            


            public void UpSpeed(int add)
            {
                currentSpeed += add;

            }


            public void Print()
            {
                Console.WriteLine($"Driver {driver} is going with speed {currentSpeed} km/h!");

            }
        }











        static void Main(string[] args)
        {
            var car = new Car { currentSpeed = 200, driver = "Luis"};
            
            
            for (int i = 0; i < 10; i++)
            {
                car.UpSpeed(10);
                car.Print();
            }
            
        }
    }
}
