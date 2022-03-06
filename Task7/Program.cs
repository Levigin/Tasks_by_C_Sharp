public class Task7
{
    static void Main(string[] args)
    {
        Console.Write("Enter the quater: ");
        int quater = int.Parse(Console.ReadLine());

        switch (quater)
        {
            case 1:
                Console.WriteLine("x > 0 and y > 0");
                break;
            case 2:
                Console.WriteLine("x < 0 and y > 0");
                break;
            case 3:
                Console.WriteLine("x < 0 and y < 0");
                break;
            case 4:
                Console.WriteLine("x > 0 and y < 0");
                break;
            default:
                if (quater > 4 || quater < 0) Console.WriteLine("The quater is apcent");
                else Console.WriteLine(" x and y equal coordinate center");
                break;
        }
    }
}