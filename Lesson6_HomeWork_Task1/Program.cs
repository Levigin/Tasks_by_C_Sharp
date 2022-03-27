public class Task1
{
    static void Main(string[] args)
    {
        Enter(Rnd());
    }
    static int Rnd()
    {
        Random rnd = new Random();
        int val = rnd.Next(1, 10);
        return val;
    }

    static void Enter(int val)
    {
        int count = 0;
        for (int i = 0; i < val; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x > 0) count++;
        } 
        Console.WriteLine($" Count = {count}");
    }
    
}