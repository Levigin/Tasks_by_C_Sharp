//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
public class Lesson8_HomeWork_Task2
{
    public static Random random = new Random();
    static void Main(string[] args)
    {
        int[,] array = new int[5, 7];
        SumElement(array);
    }
    public static void SumElement(int[,] nums)
    {
        int sum = 0;  
        int index = 0;
        int sumMin = int.MaxValue;
        
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                nums[i, j] = random.Next(20);
                sum += nums[i, j];
                Console.Write(nums[i,j] + " ");
            }
            Console.WriteLine();
            if (sum < sumMin)
            {
                sumMin = sum;
                index = i;
            }
        }
        Console.WriteLine($"Index = {index}, min sum = {sumMin}");
    }
}