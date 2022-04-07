//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
public class Task1
{

    public static Random random = new Random();
    static void Main(string[] args)
    {
        int m = random.Next(1,11);
        int n = random.Next(1,11);  
        int[,] nums = new int[m,n];

        Console.WriteLine($"m = {m}, n = {n}");

        Arrays(nums);

    }
    public static int[,] Arrays(int[,] nums)
    {
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                nums[i,j] = random.Next(50);
                Console.Write(nums[i,j] + " ");
            }
            Console.WriteLine();
        }
        return nums;
    }
}