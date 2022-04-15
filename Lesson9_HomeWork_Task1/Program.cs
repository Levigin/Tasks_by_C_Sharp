//Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N.
public class Task1
{
    static void Main(string[] args)
    {
        int m = 1;
        int n = 5;
        Rec(m, n);
    }

    public static void Rec(int m, int n)
    {
        if (m == n + 1) return;
        if (m % 2 == 0)
        {
            Console.Write(m + " ");
        }
        Rec(m+1, n);
    }
}