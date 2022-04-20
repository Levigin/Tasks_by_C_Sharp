public class Task2
{
    static void Main(string[] args)
    {
        int n = 50;
        Console.WriteLine(Rec(n));
        
    }
    static string Rec(int value)
    {
        if (value <= 2) return "Not simple";
        for (int i = 2; i < value; i++)
        {
            if (value % i == 0)
            {
                return "Not simple";
            }
        }
        return "Simple";
    }
}