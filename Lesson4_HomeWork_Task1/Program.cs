public class Task1
{
    static void Main(string[] args)
    {
        Random rmd = new Random();
        int val = rmd.Next(10);
        int pow = rmd.Next(10);
        Console.WriteLine(MathPow(val, pow));

    }
    static int MathPow(int val, int pow)
    {
        if (pow == 0) return 1;

        for (int i = 0; i < pow; i++)
        {
            val *= val;
        }
        return val;
    }
}