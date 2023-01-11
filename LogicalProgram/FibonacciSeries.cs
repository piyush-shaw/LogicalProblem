using System;
namespace LogicalProgram
{
	internal class FibonacciSeries
	{
		public static void Series()
		{
			int a = 0, b = 1, c;
			Console.WriteLine("Enter a number of element ");
			int num = Convert.ToInt32(Console.ReadLine());
			Console.Write(a + "," + b);
			for(int i = 2; i <= num; i++)
			{
				c = a + b;
				Console.WriteLine("," + c);
				a = b;
				b = c;
			}
		}
	}
}

