using System;
namespace LogicalProgram
{
	internal class ReverseNumber
	{
		public static void Reverse()
		{
			Console.WriteLine("Enter a number to make it Reverse");
			int number = Convert.ToInt32(Console.ReadLine());
			int rem = 0, rev = 0;
			while (number != 0)
			{
				rem = number % 10;
				rev = rev * 10 + rem;
				number = number / 10;
			}
			Console.WriteLine("After reversing the number "+rev);
		}
	}
}

