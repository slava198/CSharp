/*
 * Created by SharpDevelop.
 * User: Слава
 * Date: 22.10.2018
 * Time: 13:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace HomeWork5
{
	public class Fraction
	{
		internal int nominator;
		internal int denominator;
		
		public Fraction(int nmntr, int dnmntr)
		{
			nominator = nmntr;
			denominator = dnmntr;
		}
		
		public override string ToString()
		{
			return string.Format("{0}/{1}", nominator, denominator);
		}
		
		public override bool Equals(object obj)
		{
			return this.ToString() == obj.ToString();
		}
		
		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}
		
		public static bool operator == (Fraction firstFrac, Fraction secondFrac)
		{
			return firstFrac.Equals(secondFrac);
		}
		
		public static bool operator != (Fraction firstFrac, Fraction secondFrac)
		{
			return !(firstFrac == secondFrac);
		}
		
		public static Fraction operator + (Fraction firstFrac, Fraction secondFrac)
		{
			var result = new Fraction(firstFrac.nominator * secondFrac.denominator + secondFrac.nominator * firstFrac.denominator, firstFrac.denominator * secondFrac.denominator);
			result.Cut();
			return result;
		}
		
		public static Fraction operator - (Fraction firstFrac, Fraction secondFrac)
		{
			var result = new Fraction(firstFrac.nominator * secondFrac.denominator - secondFrac.nominator * firstFrac.denominator, firstFrac.denominator * secondFrac.denominator);
			result.Cut();
			return result;
		}
		
		public static Fraction operator * (Fraction firstFrac, Fraction secondFrac)
		{
			var result = new Fraction(firstFrac.nominator * secondFrac.nominator, firstFrac.denominator * secondFrac.denominator);
			result.Cut();
			return result;
		}
		
		public static Fraction operator / (Fraction firstFrac, Fraction secondFrac)
		{
			var result = new Fraction(firstFrac.nominator * secondFrac.denominator, firstFrac.denominator * secondFrac.nominator);
			result.Cut();
			return result;
		}
		
		public static implicit operator Fraction (int number)
		{
			return new Fraction(number, 1);
		}
		
		public static implicit operator Fraction (double number)
		{
			return new Fraction((int)(Math.Round(number * 100)), 100);
		}
		
		public static bool operator	true (Fraction frac)
		{
			return (Math.Abs(frac.nominator) < Math.Abs(frac.denominator))? true : false;
		}
		
		public static bool operator	false (Fraction frac)
		{
			return (Math.Abs(frac.nominator) >= Math.Abs(frac.denominator))? true : false;
		}
		
		public void Cut()
		{
			int i = Math.Abs(nominator) < Math.Abs(denominator) ? nominator : denominator;
			
			if (nominator % i == 0 && denominator % i == 0)
			{
				nominator /= i;
				denominator /= i;
				return;
			}
			i /= 2;
			while (i > 1)
			{
				if (nominator % i == 0 && denominator % i == 0)
				{
					nominator /= i;
					denominator /= i;
					return;
				}
				i--;
			}
		}
	}
}
