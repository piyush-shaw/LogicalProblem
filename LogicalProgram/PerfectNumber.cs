using System;
namespace LogicalProgram
{
	internal class PerfectNumber
	{
		public static void Number()
		{
			int sum = 0;
			Console.WriteLine("Enter the number to check perfect number");
			int num = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i < num; i++)
			{
				if (num % i == 0)
				{
					sum = sum + i;
					Console.WriteLine(" "+i);
				}
			}
			Console.WriteLine("Sum of factors "+sum);
			if (sum == num)
			{
				Console.WriteLine(num+" is a perfect number");
			}
			else
			{
				Console.WriteLine(num+" is not a perfect number");
			}
		}
	}
}

