﻿public class Task1
{
    static void Main(string[] args)
    {
        int[] data = new int[] { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
        int[] info = new int[] { 2, 3, 3, 1 };

        ResultDecimal(data, info);
    }

    static int[] ResultDecimal(int[] data, int[] info)
    {
        int[] result = new int[info.Length];
        int count = 0;
        int decim = 0;
        int k = 0;  

        while (k < data.Length)
        {
            for (int j = info[count]-1; j >= 0; j--)
            {
                decim += data[k] * (int)Math.Pow(2,j);
                k++;
            }
            result[count] = decim; 
            decim = 0;
            count++;
        }

        foreach (int i in result) Console.Write(i + " ");
        return result;
    }
}