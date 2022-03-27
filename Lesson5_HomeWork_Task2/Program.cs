public class Task2
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Sum = {Arr()}");
    }
    static int Rnd()
    {
        Random rnd = new Random();
        int val = rnd.Next(1, 100);
        return val;
    }
    static int Arr()
    {
        int sum = 0;
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Rnd();
            if (i %  2 == 1)
            {
                sum += arr[i];
            }
        }
        foreach (int i in arr) Console.Write(i + " ");
        Console.WriteLine();
        return sum;
    }
}
