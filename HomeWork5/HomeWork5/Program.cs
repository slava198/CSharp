/*
 * Created by SharpDevelop.
 * User: Слава
 * Date: 21.10.2018
 * Time: 11:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace HomeWork5
{
	class Program
	{
		public static void Main(string[] args)
		{
			//LineEquation le = LineEquation.Parse("12,45");
			
			
			//var cplx1 = new Complex(3, 3);
			//var cplx2 = new Complex(1, 1);
			//var z = new Complex(1, 1);
			
			var fr1 = new Fraction(3, 4);
			var fr2 = fr1 * 10;
			Fraction fr3 = 10 * fr2;
			Fraction fr4 = fr1 + 1.5;
			
			Console.WriteLine(fr1);
			Console.WriteLine(fr2);
			Console.WriteLine(fr3);
			Console.WriteLine(fr4);
			
			Console.WriteLine(fr1 - 0.2);
			
			
			
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}