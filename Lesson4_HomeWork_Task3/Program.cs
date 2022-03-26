public class Task3
{
    static int[] array = new int[8];
    static void Main(string[] args)
    {
        Rnd();
        DigitSum();
        Print(array);
    }

    static int[] DigitSum()
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Rnd();
        }

        return array;
    }
    static int Rnd()
    {
        Random rnd = new Random();
        int val = rnd.Next(100);
        return val;
    }
    static void Print(int[] array)
    {
        foreach (var item in array) Console.Write(item + " ");
        Console.WriteLine();
    }

}