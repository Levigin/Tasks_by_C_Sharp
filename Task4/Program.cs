public class Task4 
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int value = rnd.Next(10,100);
        int value1 = value % 10;
        int value2 = value / 10;
        if (value1 > value2) Console.WriteLine(value1);
        else if (value1 < value2) Console.WriteLine(value2);
        else Console.WriteLine("equal");
    }
}