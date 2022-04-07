//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
public class Task2
{
    public static Random random = new Random();
    static void Main(string[] args)
    {
        int m = random.Next(20);
        int n = random.Next(20);  

        ValueReturn(m,n);
    }
    public static void ValueReturn(int m, int n)
    {
        int[,] nums = new int[10, 10];
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                nums[i, j] = random.Next(50);
            }
        }
        if (m < nums.GetLength(0) && n < nums.GetLength(1))
        {
            Console.WriteLine(nums[m, n]); 
        }
        else Console.WriteLine("This value is not found");
    }
}