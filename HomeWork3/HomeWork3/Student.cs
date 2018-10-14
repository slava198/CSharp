/*
 * Created by SharpDevelop.
 * User: Слава
 * Date: 11.10.2018
 * Time: 23:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
using System;

namespace HomeWork3
{

	public enum Course
	{
		Programing, Design, Modeling3D
	}
	
	class Student
	{
		string studentName;
		string studentGroup;
		int studentAge;
		int[][] studentMarks;
		
		public Student(string name = "Ivan", string _group = "a0001", int age = 18)
		{
			studentName = name;
			studentGroup = _group;
			studentAge = age;
			studentMarks = new int[3][] {new int[20], new int[20], new int[20]};
		}
		
		public void ShowStudent()
		{
			Console.WriteLine("Student {0} ({1} years old), group {2}:", studentName, studentAge, studentGroup);
			ShowAverageMark(Course.Programing);
			ShowAverageMark(Course.Design);
			ShowAverageMark(Course.Modeling3D);
		}
		
		public void AddMark(Course course, int mark)
		{
			int i = 0;
			int j = 0;
			if (course == Course.Design)
			{
				j = 1;
			}
			else if (course == Course.Modeling3D)
			{
				j = 2;
			}	
			
			while (studentMarks[j][i] != 0) { i++; }
			studentMarks[j][i] = mark;
		}
		
		public void ShowAverageMark(Course course)
		{
			int result = 0;
			int i = 0;
			int j = 0;
			if (course == Course.Design)
			{
				Console.Write("Average mark of course <Design>: ");
				j = 1;
			}
			else if (course == Course.Modeling3D)
			{
				Console.Write("Average mark of course <Modeling3D>: ");
				j = 2;
			}
			else
			{
				Console.Write("Average mark of course <Programming>: ");
			}
			while (studentMarks[j][i] != 0) {
				
				result += studentMarks[j][i++];
			}
			
			if (i != 0)
			{
				Console.WriteLine(result / i);
			}
			else
			{
				Console.WriteLine("0");
			}	
		}
		
		public void ShowMarks(Course course)
		{
			
			int j = 0;
			if (course == Course.Design)
			{
				Console.Write("Marks of course <Design>: ");
				j = 1;
			}
			else if (course == Course.Modeling3D)
			{
				Console.Write("Marks of course <Modeling3D>: ");
				j = 2;
			}
			else
			{
				Console.Write("Marks of course <Programming>: ");
			}
			foreach (var element in studentMarks[j])
			{
				if (element !=0)
				{
					Console.Write("{0,3}", element);	
				}
				
			}
			Console.Write("\n");
		}	
	}
	
	
}