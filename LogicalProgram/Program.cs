using LogicalProgram;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Logical Problems");
        Console.WriteLine("\n1.Fibonacci Series\n2.Perfect Number\n3.PrimeNumber\n4.ReverseNumber");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            //Fibonacci Series
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
            default:
                Console.WriteLine("Choose from above options only ");
                break;
        }
    }
}