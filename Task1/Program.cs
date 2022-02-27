public class Task1
{
    public static void Main(String[] args)
    {
        Console.Write("Введите число: ");
        string str = Console.ReadLine();

        int value = int.Parse(str);

        int result = value * value;
        Console.WriteLine(result);

    }
}