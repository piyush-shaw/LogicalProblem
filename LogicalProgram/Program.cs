using LogicalProgram;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Logical Problems");
        Console.WriteLine("\n1.Fibonacci Series");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            //Fibonacci Series
            case 1:
                FibonacciSeries.Series();
                break;
            default:
                Console.WriteLine("Choose from above options only ");
                break;
        }
    }
}