public class Task1
{
    static void Main(string[] args)
    {
        int n = 536870913;
        //Console.WriteLine(PovBinary(n));
        Console.WriteLine(Rec(n));
    }
    public static bool PovBinary(int value)
    {
        while (value != 0)
        {
            value = value % 2;
            if (value == 0)
            {
                return true;
            }else if (value == 1)
            {
                break;
            }
        }
        return false;
    }
    public static int Rec(int value)
    {
        if (value == 0) return 0;
        if (value == 1) return 1;
        return Rec(value % 2);
    }
}