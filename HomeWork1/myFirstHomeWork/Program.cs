/*
 * Created by SharpDevelop.
 * User: Слава
 * Date: 22.09.2018
 * Time: 13:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace myFirstHomeWork
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Program.task1();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}	
		
		
		
		
		public static int task1()  ///////////////////////FIRST
		{
			Console.Write("Enter first dimension of a rectangle: ");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter second dimension of a rectangle: ");
			int b = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter dimension of a square: ");
			int c = Convert.ToInt32(Console.ReadLine());
			int numberOfSquares = (a / c) * (b / c);
			int freeArea = a * b - numberOfSquares * c * c;
			if(a < c || b < c)
			{
				Console.WriteLine("The square can not be placed on the rectangle");
			}
			else
			{
				Console.WriteLine("{0} squares {1}x{1} can place on rectangle {2}x{3}, free area is {4}", numberOfSquares, c, a, b, freeArea);
			}
			
			return 0;
		}
		
		
		
		
		public static int task2()       ////////////////////SECOND
		{		
			const float startDeposite = 10000;
			const float finishDeposite = 11000;
			float currentDeposite = startDeposite;
			int month = 0;
			
			Console.Write("Enter an interest rate: ");
			float interestRate;
			if(float.TryParse(Console.ReadLine(), out interestRate))
			{
				if(interestRate < 0 || interestRate > 25)
				{
					Console.WriteLine("Interest rate must be between 0,00 and 25,00");
				}
				else
				{
					while(currentDeposite < finishDeposite)
					{
						currentDeposite += currentDeposite * (interestRate / 100);
						month++;
						Console.WriteLine("{0} -- {1}$", month, currentDeposite);
					}
			
					Console.WriteLine("After {0} monthes your deposite exceeded {1}$ and reached {2}$", month, finishDeposite, currentDeposite);
				}
			}
			else
			{
				Console.WriteLine("!!! Incorrect enter !!!!");
			}
			
			return 0;
		}
		

		
		
		public static int task3()    ////////////////////THRID
		{
			Console.Write("Enter a number A:");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter a number B:");
			int b = Convert.ToInt32(Console.ReadLine());
			
			for(int i = a; i <= b; i++)
			{
				for(int ii = 0; ii < i; ii++)
				{
					Console.Write("{0} ", i);
				}
				Console.Write("\n");
			}
			Console.Write("\n");
			
			
			return 0;
		}
		
		
		
		
		public static int task4()  ///////////////////// FOURTH 
		{		
			Console.Write("Enter a number: ");
			String num = Console.ReadLine();
			String numReverse = "";
			foreach(Char s in num)
			{
				numReverse = s + numReverse;
			}
			Console.WriteLine("Your reversed number is: " + numReverse);
						
			return 0;
		}
		
	}
}