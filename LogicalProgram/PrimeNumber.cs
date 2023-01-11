using System;
namespace LogicalProgram
{
	internal class PrimeNumber
	{
		public static void Prime()
		{
			Console.WriteLine("Enter the number to check Prime ");
			int number = Convert.ToInt32(Console.ReadLine());
			bool isPrime = true;
			for(int i = 2; i <= number / 2; i++)
			{
				if (number % i == 0)
				{
					isPrime = false;
					break;
				}
			}
			if (isPrime)
			{
				Console.WriteLine("It is Prime Number");
			}
			else
			{
				Console.WriteLine("It is not a Prime Number");
			}
		}
	}
}

