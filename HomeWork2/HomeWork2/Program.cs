/*
 * Created by SharpDevelop.
 * User: Слава
 * Date: 02.10.2018
 * Time: 19:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace HomeWork2
{
		
	class Program
	{
		
		public static void Exercise1()
		{
			var arr = new int[] {1, 4, 6, 45, -45, 0, 0, 4, -190, 9};
			foreach (var v in arr)
			{
				Console.Write(v + " ");
			}
			Console.WriteLine();
			
			
			for (int i = 0; i < 10; i++)
			{
				if (arr[i] == 0)
				{
					arr[i] = -1;
				}
			}
						
			foreach (var v in arr)
			{
				Console.Write(v + " ");
			}
			Console.WriteLine();
			
		}
		
		
		public static void Exercise2()
		{
			var arr = new int[] {1, 4, 6, 8, 1, 7, 45, -45, 0, -23, 56, -1, 0, 4, -190, 9};
			int arrayLength = arr.GetLength(0);
			var resultArr = new int[arrayLength];
			
			foreach (var v in arr)
			{
				Console.Write(v + " ");
			}
			Console.WriteLine();
			
			int indexStart = 0;
			int indexEnd = arrayLength - 1;
			
			for (int i = 0; i < arrayLength; i++)
			{
				if (arr[i] < 0)
				{
					resultArr[indexStart++] = arr[i];
				}
				else
				{
					resultArr[indexEnd--] = arr[i];
				}
			}
						
			foreach (var v in resultArr)
			{
				Console.Write(v + " ");
			}
			Console.WriteLine();
			
		}
		
		
		public static void Exercise3()
		{
			var arr = new int[] {1, 4, 6, 8, 1, 7, 45, -45, 0, -23, 56, -1, 0, 4, -190, 9};
			int arrayLength = arr.GetLength(0);
						
			foreach (var v in arr)
			{
				Console.Write(v + " ");
			}
			
			Console.Write("\nEnter a number to find it in array: ");
			int numberToFind = int.Parse(Console.ReadLine());
			int count = 0;
						
			foreach (var v in arr)
			{
				if (v == numberToFind)
				{
					count++;
				}
			}
			Console.WriteLine("Number {0} occurs in array {1} times", numberToFind, count);
			
		}
		
		
		public static void Exercise4()
		{
			Console.Write("Enter the first dimension of array: ");
			int m = int.Parse(Console.ReadLine());
			Console.Write("Enter the second dimension of array: ");
			int n = int.Parse(Console.ReadLine());
			var arr = new int[m,n];
						
			Random rnd = new Random();
			
			for (int x = 0; x < m; x++)
			{
				for (int y = 0; y < n; y++)
				{
					arr[x,y] = rnd.Next(0, 50);
					Console.Write("{0,3}", arr[x,y]);
				}
				Console.WriteLine();
			}
			Console.Write("Enter the first column to swap: ");
			int columnToSwap1 = int.Parse(Console.ReadLine());
			Console.Write("Enter the second column to swap: ");
			int columnToSwap2 = int.Parse(Console.ReadLine());
			
			int bufer;
			for (int x = 0; x < m; x++)
			{
				bufer = arr[x,columnToSwap1];
				arr[x, columnToSwap1] = arr[x, columnToSwap2];
				arr[x, columnToSwap2] = bufer;
			}
			
			for (int x = 0; x < m; x++)
			{
				for (int y = 0; y < n; y++)
				{
					Console.Write("{0,3}", arr[x,y]);
				}
				Console.WriteLine();
			}
			
		}
		
		
		
		public static void Main(string[] args)
		{
			
			Exercise2();
				
		
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}