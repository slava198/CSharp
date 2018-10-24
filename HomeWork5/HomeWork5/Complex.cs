/*
 * Created by SharpDevelop.
 * User: Слава
 * Date: 21.10.2018
 * Time: 12:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace HomeWork5
{
	/// <summary>
	/// Description of Complex.
	/// </summary>
	public class Complex
	{
		internal double realPart {get; set;}
		internal double imaginePart {get; set;}
		
		public Complex(double rP, double iP)
		{
			realPart = rP;
			imaginePart = iP;
		}
		
		public override string ToString()
		{
			return imaginePart < 0? string.Format("{0} - i{1}", realPart, imaginePart * (-1)) : string.Format("{0} + i{1}", realPart, imaginePart);			
		}
		
		public override bool Equals(object obj)
		{
			return this.ToString() == obj.ToString();
		}
		
		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}
		
		public static bool operator == (Complex firstCplx, Complex secondCplx)
		{
			return firstCplx.Equals(secondCplx);
		}
		
		public static bool operator != (Complex firstCplx, Complex secondCplx)
		{
			return !(firstCplx == secondCplx);
		}

		public static Complex operator + (Complex firstCplx, Complex secondCplx)
		{
			return new Complex(firstCplx.realPart + secondCplx.realPart, firstCplx.imaginePart + secondCplx.imaginePart);
		}
		
		public static Complex operator - (Complex firstCplx, Complex secondCplx)
		{
			return new Complex(firstCplx.realPart - secondCplx.realPart, firstCplx.imaginePart - secondCplx.imaginePart);
		}
		
		public static Complex operator - (Complex firstCplx, double secondDbl)
		{
			firstCplx.realPart -= secondDbl;
			return firstCplx;
		}
		
		
		public static Complex operator * (Complex firstCplx, Complex secondCplx)
		{
			double a = firstCplx.realPart;
			double b = firstCplx.imaginePart;
			double c = secondCplx.realPart;
			double d = secondCplx.imaginePart;
			return new Complex((a * c - b * d), (b * c + a * d));
		}
		
		public static Complex operator * (double firstDbl, Complex secondCplx)
		{
			secondCplx.realPart *= firstDbl;
			secondCplx.imaginePart *= firstDbl;
			return secondCplx;
		}
		
		public static Complex operator / (Complex firstCplx, Complex secondCplx)
		{
			double a = firstCplx.realPart;
			double b = firstCplx.imaginePart;
			double c = secondCplx.realPart;
			double d = secondCplx.imaginePart;
			return new Complex((a * c + b * d) / (c * c + d * d), (b * c - a * d) / (c * c + d * d));		}
		
		
		public static Complex operator ++ (Complex Cplx)
		{
			Cplx.realPart++;
			Cplx.imaginePart++;
			return Cplx;
		}
		
	}
}
