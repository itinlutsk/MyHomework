using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
	class Arifmetic
	{
		private static Dictionary<char, int> intList = new Dictionary<char, int>()
		{
		  {'I', 1},{'V', 5},{'X', 10},{'L', 50},{'C', 100},{'D',  500},{'M', 1000}
        };

		public static int ReplaceStringToInt(string value)
		{

			int res = 0;

			if (value.Length > 1)
			{

				List<int> collectionInt = new List<int>();

				for (int a = 0; a < value.Length; a++)
				{
					collectionInt.Add(intList.SingleOrDefault(t => t.Key == value[a]).Value);
				}

				for (int a = 1; a < collectionInt.Count; a++)
				{
					if (collectionInt[a - 1] < collectionInt[a])
					{
						res += collectionInt[a] - collectionInt[a - 1];
					}

					else
					{
						res += collectionInt[a] + collectionInt[a - 1];
					}
				}

				return res;
			}
			else
			{
				return intList.SingleOrDefault(t => t.Key == value[0]).Value;
			}
		}

		public static void HomeTriangle(double a, double b, double c)
		{
			double res = c * Math.PI / 180;
			Console.WriteLine(0.5 * a * b * Math.Sin(res));
		}
		public static void HomeTriangle(double a, double b, int c)
		{
			double res = c * Math.PI / 180;
			Console.WriteLine(0.5 * a * b * Math.Sin(res));
		}

	}




}
