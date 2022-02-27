public class Task2
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        string value1 = Console.ReadLine();
        int number1 = int.Parse(value1);
        Console.Write("Введите второе число: ");
        string value2 = Console.ReadLine();
        int number2 = int.Parse(value2);

        if (number1*number1 == number2)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}