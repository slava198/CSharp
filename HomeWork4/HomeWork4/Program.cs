/*
 * Created by SharpDevelop.
 * User: Слава
 * Date: 07.10.2018
 * Time: 9:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;


namespace HomeWork4
{
	class Program
	{
		public static void Main(string[] args)
		{
			var tr = new Triangle(3, 4, 5);
			tr.Show();
			
			var rh = new Rhombus(10, 60);
			rh.Show();
			
			
			var rct = new Rectangle(10, 10);
			rct.Show();
			
			
			var prl = new Parallelogram(10, 10, 120);
			prl.Show();
			
			var trp = new Trapeze(20, 10, 5, 120);
			trp.Show();
			
			var cpst_fgr = new CompositeShape(rh, trp, rct);
			cpst_fgr.Show();
			//Console.WriteLine("{1}'s area: {0:0.000}", cpst_fgr.Area(), cpst_fgr.name);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}