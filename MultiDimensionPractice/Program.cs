internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Rows :");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Columns :");
        int cols = int.Parse(Console.ReadLine());

        int[,] mtrx = new int[rows, cols];
    }
}