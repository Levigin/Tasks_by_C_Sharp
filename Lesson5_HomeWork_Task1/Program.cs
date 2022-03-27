public class Task1
{
    static void Main(string[] args)
    {
        Arr();
    }
    static int Rnd()
    {
        Random rnd = new Random();
        int val = rnd.Next(100, 1000);
        return val;
    }
    static int[] Arr()
    {
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Rnd();
            if (arr[i] % 2 == 0)
            {
                Console.Write(arr[i] + " ");
            }
        }
        return arr;
    }
}