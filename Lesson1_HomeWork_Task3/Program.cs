public class Lesson1_HomeWork_Task3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value: ");
        int value1 = Int32.Parse(Console.ReadLine());
        if (value1 % 2 == 0) Console.WriteLine("YES!!");
        else Console.WriteLine("NO!!!");
    }
}