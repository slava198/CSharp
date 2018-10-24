using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonWork2additional
{
    


    class Program
    {
        static void GetDigit(ref int digit)
        {
            digit = new Random().Next(0,10);

        }

        static void Main(string[] args)
        {
            int i;
            GetDigit(ref i);


            Console.WriteLine(i);           
            
            
        }
    }
}
