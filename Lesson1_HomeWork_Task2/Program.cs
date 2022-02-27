public class Lesson1_HomeWork_Task2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value: ");
        int value1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value: ");
        int value2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value: ");
        int value3 = Int32.Parse(Console.ReadLine());
        int max = value1;
        if (value2 > max) max = value2;
        if (value3 > max) max = value3;
        Console.WriteLine(max);
    }
}