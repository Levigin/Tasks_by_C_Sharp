//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
public class Task4
{
    public static Random random = new Random();
    static void Main(string[] args)
    {
        int[,,] arrays = new int[3, 3, 3];
        int n = 10;
        for (int i = 0; i < arrays.GetLength(0); i++)
        {
            for (int j = 0; j < arrays.GetLength(1); j++)
            {
                for (int k = 0; k < arrays.GetLength(2); k++)
                {
                    arrays[i, j, k] = n;
                    n++;
                    Console.Write($"arrays[{i},{j},{k}] {arrays[i, j, k]}\t ");

                }
                Console.WriteLine();
            }
        }
        }
    } 
