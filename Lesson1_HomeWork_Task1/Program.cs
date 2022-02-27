public class Lesson1_HomeWork_Task1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value: ");
        int value1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value: ");
        int value2 = Int32.Parse(Console.ReadLine());
        if (value1 > value2) Console.WriteLine(value1);
        else if (value2 > value1) Console.WriteLine(value2);
        else Console.WriteLine("equal");
    }
}