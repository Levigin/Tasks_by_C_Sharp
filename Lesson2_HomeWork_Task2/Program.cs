public class Lesson2_HomeWork_Task2
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int value = rnd.Next(100, 1000);
        Console.WriteLine(value);
        Console.WriteLine((value % 100 ) / 10);
    }
}