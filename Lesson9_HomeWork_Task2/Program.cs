//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
public class Task2
{
    public static int sum = 0;
    static void Main(string[] args)
    {
        int m = 4;
        int n = 8;
        Rec(m, n);
        Console.WriteLine(sum);
    }
    public static void Rec(int m, int n)
    {
        if (m == n+1) return;
        sum += m;
        Rec(m + 1, n);
    }
}