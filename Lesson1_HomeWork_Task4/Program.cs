public class Lesson1_HomeWork_Task4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value: ");
        int value1 = Int32.Parse(Console.ReadLine());
        for (int i = 1; i < value1; i++)
        {
            if (i % 2 == 0 ) Console.WriteLine(i);
        }
    }
}