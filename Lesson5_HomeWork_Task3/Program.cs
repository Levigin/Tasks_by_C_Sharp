public class Task3
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Sum = {Arr()}");
    }
    static int Rnd()
    {
        Random rnd = new Random();
        int val = rnd.Next(-100, 100);
        return val;
    }
    static int Arr()
    {
        int max = int.MinValue;
        int min = int.MaxValue;
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Rnd();
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }else if (arr[i] > max) max = arr[i];
        }
        foreach (int i in arr) Console.Write(i + " ");
        Console.WriteLine();
        return max-min;
    }
}
