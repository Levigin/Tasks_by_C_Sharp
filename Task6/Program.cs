public class Task6 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value: ");
        int value1 = Int32.Parse(Console.ReadLine());
        if (value1 % 7 == 0 && value1 % 23 == 0) Console.WriteLine("YES!!");
        else Console.WriteLine("NO!!!");

    }
}