public class Lesson3_HomeWork_Task1
{
    static void Main(string[] args)
    {   
        Console.Write(" Enter the number: ");
        string str = Console.ReadLine();

        int number = int.Parse(str);

        Console.WriteLine(methodStr(str));

        Console.WriteLine(methodArray(str));

        Console.WriteLine(methodMath(number));

    }

    public static bool methodArray(string number)
    {
        int[] array1 = new int[number.Length];
        int[] array2 = new int[number.Length];
        int number1 = int.Parse(number);

        for (int j = array1.Length - 1; j >= 0; j--)
        {
            array1[j] = number1 % 10;
            number1 /= 10;

        }
        //Console.WriteLine(array1[0] + " " + array1[1] + " " + array1[2]);

        number1 = int.Parse(number);

        for (int j = 0; j < array2.Length; j++)
        {
            array2[j] = number1 % 10;
            number1 /= 10;

        }
        //Console.WriteLine(array2[0] + " " + array2[1] + " " + array2[2]);
        number1 = int.Parse(number);
        int i = 0;
        bool flag = false;

        while (i < number.Length)
        {
            if (array1[i] == array2[i])
            {
                flag = true;
            }
            else flag = false;
            i++;
        }

        return flag;
    }

    public static bool methodStr(string number)
    {
        string number1 = "";

        for (int i = number.Length - 1; i >= 0; i--)
        {
            number1 = number1 + number[i] + "";
        }
        return (number1 == number);
    }

    public static bool methodMath(int number)
    {
        int oldNumber = number; // 1 2 3 4 5
        int newNumber = 0;

        int temp = 0;

        while (number > 0)
        {
            newNumber *= 10;
            newNumber += number % 10;
            number /= 10;
        }

        return oldNumber == newNumber;
    }
}