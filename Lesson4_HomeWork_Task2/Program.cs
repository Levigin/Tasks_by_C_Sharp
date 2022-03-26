public class Task2
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int val = rnd.Next();

        Console.WriteLine(val);

        Console.WriteLine(DigitSum(val));

    }

    static int DigitSum(int val)
    {
        int result = 0;

        while (val > 0)
        {
            result = result + (val % 10);
            val /= 10;
        }
        return result;
    }

}