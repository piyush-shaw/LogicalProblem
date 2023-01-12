using LogicalProgram;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Logical Problems");
        Console.WriteLine("\n1.Fibonacci Series\n2.Perfect Number\n3.Prime Number\n4.Reverse Number\n5.Coupon Number\n6.StopWatch");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                FibonacciSeries.Series();
                break;
            case 2:
                PerfectNumber.Number();
                break;
            case 3:
                PrimeNumber.Prime();
                break;
            case 4:
                ReverseNumber.Reverse();
                break;
            case 5:
                CouponNumber.Coupon();
                break;
            case 6:
                StopWatch.Watch();
                break;
            default:
                Console.WriteLine("Choose from above options only ");
                break;
        }
    }
}