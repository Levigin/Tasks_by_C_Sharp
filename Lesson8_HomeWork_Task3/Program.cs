//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
public class Task3
{
    public static Random random = new Random();
    static void Main(string[] args)
    {
        int[,] arrays1 = new int[2, 2];
        int[,] arrays2 = new int[2, 2];

        for (int i = 0; i < arrays1.GetLength(0); i++)
        {
            for (int j = 0; j < arrays1.GetLength(1); j++)
            {
                arrays1[i, j] = random.Next(2, 10);
                Console.Write(arrays1[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        for (int i = 0; i < arrays2.GetLength(0); i++)
        {
            for (int j = 0; j < arrays2.GetLength(1); j++)
            {
                arrays2[i, j] = random.Next(2,10);
                Console.Write(arrays2[i, j] + " ");
            }
            Console.WriteLine();
        }

        MultiplicationMat(arrays1 , arrays2);
    }

    public static void MultiplicationMat(int[,] nums1, int[,] nums2)
    {
        int[,] multMat = new int[nums1.GetLength(0), nums2.GetLength(1)];

        Console.WriteLine();

        for (int i = 0; i < nums1.GetLength(0); i++)
        {
            for (int j = 0; j < nums2.GetLength(1); j++)
            {

                for (int k = 0; k < nums2.GetLength(1); k++)
                {
                   multMat[i,j] += nums1[i,k] * nums2[k,j];
                }
                
                Console.Write(multMat[i, j] + " ");   
            }
            Console.WriteLine();
        }
    }
} 