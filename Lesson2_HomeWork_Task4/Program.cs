public class Lesson2_HomeWork_Task3
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int value =Int32.Parse(Console.ReadLine());
        if (value == 6 || value == 7) Console.WriteLine("YES!!!");
        else if (value > 0 && value < 6 ) Console.WriteLine("NO!!!");
        else Console.WriteLine("Incorrect input!");

    }
}