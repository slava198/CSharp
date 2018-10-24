/*
 * Created by SharpDevelop.
 * User: Слава
 * Date: 21.10.2018
 * Time: 11:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace HomeWork5
{
	/// <summary>
	/// Description of LineEquation.
	/// </summary>
	public class LineEquation
	{
		protected int A;
		protected int B;
		
		public LineEquation(int a, int b)
		{
			A = a;
			B = b;
		}
		
		public override string ToString()
		{
			return string.Format("[LineEquation A={0}, B={1}]", A, B);
		}

		
		public static LineEquation Parse(string s)
		{
			string result = "";
			int i = 0;
			
			while (s[i] != ' ' && s[i] != ',')
			{
				result += s[i];
				i++;
			}
			int a = int.Parse(result);
			i++;
			result = "";
			while (i < s.Length)
			{
				result += s[i];
				i++;
			}
			int b = int.Parse(result);
			
			return new LineEquation(a, b);
		}
		
		
	}
}
