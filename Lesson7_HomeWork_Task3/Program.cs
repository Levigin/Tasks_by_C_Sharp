//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
public class Task3
{
    public static Random random = new Random();
    static void Main(string[] args)
    {

        Avarage();
    }
    public static void Avarage()
    {
        
        int[,] nums = new int[5, 7];
        int[] arr = new int[nums.GetLength(1)];
        int sum = 0;

        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                nums[i, j] = random.Next(20);
                Console.Write(nums[i,j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < nums.GetLength(1); i++)
        {
            for (int j = 0; j < nums.GetLength(0); j++)
            {
                sum += nums[j, i];
            }
            arr[i] = sum/nums.GetLength(0);
            sum = 0;
        }
        Console.WriteLine();
        foreach (int i in arr) Console.Write(i + " ");
    }
}