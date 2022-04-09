// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
public class Task1
{
    public static Random random = new Random();
    static void Main(string[] args)
    {
        int[,] arrays = new int[5,5];

        SortedArray(arrays);
    }
    public static void SortedArray(int[,] nums)
    {
        Console.WriteLine();
        int temp;
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                nums[i, j] = random.Next(20);

                for (int k = 0; k < nums.GetLength(1) - 1; k++)
                {
                    if (nums[i,k + 1] > nums[i, k])
                    {
                        temp = nums[i,k+1];
                        nums[i,k+1] = nums[i,k];
                        nums[i,k] = temp;
                    }
                }
                Console.Write(nums[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}