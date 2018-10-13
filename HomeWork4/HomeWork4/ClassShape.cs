/*
 * Created by SharpDevelop.
 * User: Слава
 * Date: 07.10.2018
 * Time: 9:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace HomeWork4
{
	/// <summary>
	/// Description of ClassShape.
	/// </summary>
	public abstract class Shape
	{
		public string name;
		public abstract double Area();
		public abstract double Perimeter();
		
		public void Show()
		{
			Console.WriteLine("{0}'s area: {1:0.000}, perimeter: {2:0.000}", name, Area(), Perimeter());
		}		
	}
	
	
	public class CompositeShape : Shape
	{
		Shape[] figure;
		
		public CompositeShape(params Shape[] array)
		{
			figure = array;
			name = "Composite figure";
		}
		
		public override double Area()
		{
			double result = 0;
			foreach (var element in figure)
			{
				result += element.Area();
			}
			return result;
		}
		
		public override double Perimeter()
		{
			double result = 0;
			foreach (var element in figure)
			{
				result += element.Perimeter();
			}
			return result;
		}		
	}
		

	public class Triangle : Shape
	{
		double a, b, c;
		
		public Triangle(int side_a, int side_b, int side_c)
		{
			name = "Triangle";
			a = side_a;
			b = side_b;
			c = side_c;
		}
		
		public override double Area()
		{
			double p = (a + b + c) / 2;
			return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
		}
		

		public override double Perimeter()
		{
			return a + b + c;
		}		
		
	}
	
	
	public class Square : Shape
	{
		public double a;
		
		public Square(double side_a)
		{
			name = "Square";
			a = side_a;
		}
		
		public override double Area()
		{
			return a * a;
		}
		

		public override double Perimeter()
		{
			return a * 4;
		}		
	}
	
	
	public class Circle : Shape
	{
		public double d;
		
		public Circle(double diameter)
		{
			name = "Circle";
			d = diameter;
		}
		
		public override double Area()
		{
			return d * d * Math.PI / 4;
		}

		public override double Perimeter()
		{
			return Math.PI * d;
		}		
	}
	
	
	public class Elipse : Circle
	{
		public double d2;
		
		public Elipse(double diameter, double diameter2) : base(diameter)
		{
			name = "Elipse";
			d2 = diameter2;
		}
		
		public override double Area()
		{
			return d * d2 * Math.PI / 4;
		}

		public override double Perimeter()
		{
			return Math.PI * (d + d2) / 2;
		}		
	}
	
	
	public class Rhombus : Square
	{
		public double alpha;
		
		public Rhombus(double side_a, double angle_alpha) : base(side_a)
		{
			name = "Rhombus";
			alpha = angle_alpha / 180 * Math.PI;
		}
		
		public override double Area()
		{
			return a * a * Math.Sin(alpha);
		}

		public override double Perimeter()
		{
			return a * 4;
		}		
	}
	
	
		public class Rectangle : Square
		{
			public double b;
			
			public Rectangle(double side_a, double side_b) : base(side_a)
			{
				name = "Rectangle";
				b = side_b;
			}
			
			public override double Area()
			{
				return a * b;
			}
			
			public override double Perimeter()
			{
				return (a + b) * 2;
			}		
		}
		
		
		public class Parallelogram : Rectangle
		{
			public double alpha;
			
			public Parallelogram(double side_a, double side_b, double angle_alpha) : base(side_a, side_b)
			{
				name = "Parallelogram";
				alpha = angle_alpha / 180 * Math.PI;
			}
			
			public override double Area()
			{
				return a * b * Math.Sin(alpha);
			}
		}
		
		public class Trapeze : Parallelogram
		{
			public double c;
			
			public Trapeze(double side_a, double side_b, double side_c, double angle_alpha) : base(side_a, side_b, angle_alpha)
			{
				name = "Trapeze";
				c = side_c;
			}
			
			public override double Area()
			{
				return b * Math.Sin(alpha) * (a + c) / 2;
			}
			
			public override double Perimeter()
			{
				return Math.Sqrt(b * b + (a - c) * (a - c) - 2 * b * (a - c) * Math.Cos(alpha)) + a + b + c;
			}
		}
}
