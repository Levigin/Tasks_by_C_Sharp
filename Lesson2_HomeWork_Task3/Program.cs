public class Lesson2_HomeWork_Task3
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        string value = Console.ReadLine();

        if (value.Length < 3)
        {
            Console.WriteLine("digit is abcent");
        }
        else Console.WriteLine(value[2]);
    }
}