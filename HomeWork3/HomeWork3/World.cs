/*
 * Created by SharpDevelop.
 * User: Слава
 * Date: 06.10.2018
 * Time: 15:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;


	public static class City
		{
			public static string Name;
			public static ulong Population;
			
			public static void Show()
			{
				Console.WriteLine("{1}: {0}", Population, Name);
			}
		}

	namespace Belarus
	{
		public static class Capital
		{
			public static string Name = "Minsk";
			public static ulong Population = 2000000;
			public static void Show()
			{
				Console.WriteLine("{1}: {0}", Population, Name);
			}	
		}
	}

	
	namespace Russia
	{
		public static class Capital
		{
			public static string Name = "Moscow";
			public static long Population = 15000000;
			public static void Show()
			{
				Console.WriteLine("{1}: {0}", Population, Name);
			}
		}	
	}

	
	namespace Ukraine
	{
		public static class Capital
		{
			public static string Name = "Kiew";
			public static long Population = 4000000;
			public static void Show()
			{
				Console.WriteLine("{1}: {0}", Population, Name);
			}
		}
	}

	
	namespace Poland
	{
		public static class Capital
		{
			public static string Name = "Warsaw";
			public static long Population = 6000000;
			public static void Show()
			{
				Console.WriteLine("{1}: {0}", Population, Name);
			}
		}
	}
	
	
	
	
	
	
	
	
	
