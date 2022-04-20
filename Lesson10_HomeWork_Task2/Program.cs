class Task2
{
    static List<int> list = new List<int>();
    static void Main(string[] args)
    {
        int N = 50;
        int[] nums = new int[N];
        for (int i = 0; i < N; i++) nums[i] = i+1;
        int count = 1;

        while (count != 7)
        {
            if (count < 3)
            {
                RemoveNumbers(nums);
            }
            else NotSimple(nums);

            Console.Write($"Group {count}: ");
            foreach (int i in list) Console.Write(i + " ");
            Console.WriteLine();
            list.Clear();
            count++;

        }
        
        Console.WriteLine();
        PrintArray(nums);
    }
    static string SimpleArray(int value, int[] array)
    {
        if (array[0] == 1)
        {
            return "The number is equal to one";
            array[0] = 0;
        }

        for (int i = 2; i < value; i++)
        {
            if (value % i == 0)
            {
                return "Not simple";
            }
        }
        return "Simple";
    }
    static void RemoveNumbers(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if ((SimpleArray(array[i],array) == "The number is equal to one"))
            {
                list.Add(array[i]);
                array[i] = 0;
                break;
            }
            else if (SimpleArray(array[i],array) == "Simple" && array[i] != 0)
            {
                list.Add(array[i]);
                array[i] = 0; 
            }    
        }
    }
    public static void NotSimple(int[] array)
    {
        int[] arrayNew = new int[array.Length];
        Array.Copy(array, 0, arrayNew, 0, array.Length);
        int k = 0;
        while (k < arrayNew.Length-1)
        {
            for (int i = k + 1; i < arrayNew.Length; i++)
            {
                if (arrayNew[k] == 0)
                {
                    k++;
                }
                else if (arrayNew[i] % arrayNew[k] == 0)
                {
                    arrayNew[i] = 0;
                }
                else array[i] = 0;
            }
            if (arrayNew[k] != 0) list.Add(arrayNew[k]);

            array[k] = 0;
            k++;
        }
        Console.WriteLine();
        foreach (int i in array) Console.Write(i+ " ");
        
    }
    static void PrintArray(int[] array)
    {
        Console.WriteLine();
        foreach (int i in array) Console.Write(i + " ");
    }
}