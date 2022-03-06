public class Task8
{
    static void Main(string[] args)
    {
        (double x1, double y1) = Pointer();
        (double x2, double y2) = Pointer();

        Console.WriteLine($"Coordinate first point ({y1} , {x1})\nCoordinate second point ({y2} , {x2}) ");

        int result = (int) Section(x1, y1, x2, y2);
        Console.WriteLine($"\nSection between point A and B:  {result}");
    }
    public static (double,double) Pointer()
    {
        Random rnd = new Random();
        double point1 = rnd.Next(-1000, 1000);
        double point2 = rnd.Next(-1000, 1000);

        return (point1, point2);
    }

    public static double Section(double xA, double yA, double xB, double yB)
    {
        return Math.Sqrt((xA - xB) * (xA - xB) + (yA - yB) * (yA - yB));
    }
}