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
			
			///////////////////// FIRST 
			/*
			
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
			
			*/
			
			
			////////////////////////SECOND
			/// 
			
			Console.Write("Enter first dimension of a rectangle:");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter second dimension of a rectangle:");
			int b = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter dimension of a quad:");
			int c = Convert.ToInt32(Console.ReadLine());
			int numberOfQuads = (a / c) * (b / c);
			int freeArea = a * b - numberOfQuads * c * c;
			
			Console.WriteLine("{0} quads {1}x{1} can place on rectangle {2}x{3}, free area is {4}", numberOfQuads, c, a, b, freeArea);
			
			
			
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}