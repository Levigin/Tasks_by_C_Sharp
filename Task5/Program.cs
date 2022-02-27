public class Task5
{
    static void Main(string[] args)
    {
        int value1 =Int32.Parse(Console.ReadLine());
        int value2 = Int32.Parse(Console.ReadLine());
        if (value1 % value2 == 0) Console.WriteLine("multiply");
        else Console.WriteLine(value1%value2);
    }
}