public class Task8
{
    static void Main(string[] args)
    {
        Console.Write("Enter the quater: ");
        int N = int.Parse(Console.ReadLine());
        int k = 1;

        while(k <= N)
        {
            Console.WriteLine(k*k);
            k++;
        }

    }
}