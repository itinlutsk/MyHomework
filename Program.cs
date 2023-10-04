using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
	class Program
	{
		static void Main(string[] args)
		{
			Homework_9();
		}

		// введення та виведення
		static void Homework_1()
		{
			Console.WriteLine("Enter your name:");
			string str = Console.ReadLine();

			Console.WriteLine($"Hello, {str}");

			Console.WriteLine($"{str}, enter first number");
			int a = int.Parse(Console.ReadLine());

			Console.WriteLine($"{str}, enter second number");
			int b = int.Parse(Console.ReadLine());

			Console.WriteLine($"a = {a}, b = {b}");

			Console.WriteLine("Replace a and b");
			int z = a;
			a = b;
			b = z;

			Console.WriteLine($"a = {a}, b = {b}");

			Console.WriteLine("Enter int value");
			string str1 = Console.ReadLine();
			Console.WriteLine($"Length - {str1.Length}");



		}

		// формула Герона
		static void Homework_2()
		{
			Console.WriteLine("Enter 3 value:");
			double a, b, c;

			a = Double.Parse(Console.ReadLine());
			b = Double.Parse(Console.ReadLine());
			c = Double.Parse(Console.ReadLine());

			double p = (a + b + c) / 2;
			double res = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

			Console.WriteLine();
			Console.WriteLine(res);

		}

		// профіль користувача
		static void Homework_3()
		{
			// прізвище
			Console.WriteLine("Enter surname");
			string surname = Console.ReadLine();
			
			// імя
			Console.WriteLine("Enter name");
			string name = Console.ReadLine();

			// вік
			Console.WriteLine("Enter age");
			int age = int.Parse(Console.ReadLine());
			
			// вага
			Console.WriteLine("Enter weight");
			double weight = Double.Parse(Console.ReadLine());

			// ріст
			Console.WriteLine("Enter height (cm)");
			double height = double.Parse(Console.ReadLine());

			//ИМТ = вес (кг) / (рост (м) * рост (м))
			double itm = weight / (height / 100 * height / 100);

			//Your profile:
			//Full Name: фамилия, имя
			//Age: возраст
			//Weight: вес
			//Height: рост
			//Body Mass Index: ИМТ

			string str = $"Your profile:\nFull Name: {surname}, {name}\n";
			str += $"Age: {age}\n";
			str += $"Weight: {weight}\n";
			str += $"Height: {height}\n";
			str += $"Body Mass Index: {itm}\n\n";

			Console.WriteLine(str);

		}

		// a > b or b > a
		static void Homework_4()
		{
			Console.WriteLine("Enter first int value");
			int a = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter secont int value");
			int b = int.Parse(Console.ReadLine());

			if (a > b)
			{
				Console.WriteLine($"{a} > {b}");
			}
			else if(a == b)
			{
				Console.WriteLine($"{a} = {b}");
			}
			else
			{
				Console.WriteLine($"{a} < {b}");
			}
		}

		//Фібоначчі
		static void Homework_5()
		{
			Console.WriteLine("Enter count value");
			int count = int.Parse(Console.ReadLine());

			int [] res = new int[count];
			
			res[0] = 1;

			for (int i = 1; i < count; i++)
			{
				if (i > 1)
				{
					res[i] = res[i - 1] + res[i - 2];
				}
				else
				{
					res[i] = res[i - 1];
				}
				
			}

			foreach (int a in res)
			{
				Console.WriteLine(a);				
			}
		}

		//середнє арифметичне
		static void Homework_6()
		{
			int[] res = new int[10];

			for (int a = 0; a < res.Length; a++)
			{
				Console.WriteLine("Enter int value:");

				res[a] = int.Parse(Console.ReadLine());
				if (res[a] == 0)
					break;
			}

			int sum = 0;
			int count = 0;

			foreach (int q in res)
			{
				if (q > 0 && q % 3 == 0)
				{
					sum += q;
					count++;
				}
			}
			Console.WriteLine();
			Console.WriteLine($"result: {sum / count}");
		}

		// логін-пароль
		static void Homework_7()
		{
			Console.WriteLine("Register");
			Console.WriteLine();

			Console.WriteLine("Enter login:");
			string login = Console.ReadLine();
			Console.WriteLine();

			Console.WriteLine("Enter password:");
			string password = Console.ReadLine();
			Console.Clear();

			int count = 0;

			for (int a = 0; a < 3; a++)
			{
				Console.WriteLine("Login");
				Console.WriteLine();

				Console.WriteLine("Enter login:");
				string str = Console.ReadLine();
				Console.WriteLine();

				Console.WriteLine("Enter password:");
				string str1 = Console.ReadLine();
				Console.WriteLine();

				if (str == login && str1 == password)
				{
					Console.Clear();
					Console.WriteLine("Enter the System");
					break;
				}
				else if (str == login && a != 2)
				{
					Console.WriteLine("Incorect password!");
					count++;
				}
				else if (str1 == password && a != 2)
				{
					Console.WriteLine("Incorect login!");
					count++;
				}		
				else
				{
					Console.Clear();
					Console.WriteLine("Incorect password and login!");
					count++;
				}
				if (count == 3)
				{
					Console.Clear();
					Console.WriteLine("The number of available tries have been exceeded!");
				}
			}
		}

		// do not work
		static void Homework_8()
		{
			Console.WriteLine("Enter roman value:");

			string str = Console.ReadLine();
			Console.WriteLine();
			Console.WriteLine(Arifmetic.ReplaceStringToInt(str));
		}

		// перегрузка методів
		static void Homework_9()
		{
			Arifmetic.HomeTriangle(10, 20, 5);
			Arifmetic.HomeTriangle(10, 20, 0.5);
		}
	}
}
