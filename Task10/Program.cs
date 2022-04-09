public class Task10
{
    public static int sum = 0;
    static void Main(string[] args)
    {
        int n = 410;
        Recursive(n);   
    }
    static void Recursive(int n)
    {
        if (n == 0) return;
        sum += n % 10;
        Console.Write(sum + " ");
        Recursive(n/10);
    }
}