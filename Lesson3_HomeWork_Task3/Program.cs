public class Lesson3_HomeWork_Task3
{
    static void Main(string[] args)
    {
        Console.WriteLine(recursiveSeeker(100));
    }

    static int recursiveSeeker(int n)
    {
       
        if (n == 1) return 1; // Условие выхода 

        int x = n * n * n;
        Console.WriteLine(x);
        return recursiveSeeker(n - 1);
     
    }
}