public class Task2
{
    static void Main(string[] args)
    {

        (double xA, double yA) = point();
        (double xB, double yB) = point();

        (double xC, double yC) = point();
        (double xD, double yD) = point();

        Console.WriteLine($"A: [{xA},{yA}] B: [{xB},{yB}]\nC: [{xC},{yC}] D:[{xD},{yD}]");

        int coefA1 = (int)(yB - yA);
        int coefB1 = (int)(xA - xB);
        int coefC1 = (int)(yA * xB - xA * yB);

        int coefA2 = (int)(yD - yC);
        int coefB2 = (int)(xC - xD);
        int coefC2 = (int)(yC * xD - xC * yC);

        if (coefA1 * coefB2 - coefB1 * coefA2 == 0)
        {
            Console.WriteLine("Vector AB and CD are parallel!!!");
        }
        else
        {
            int pointX = -(coefC1 * coefB2 - coefB1 * coefC2) / (coefA1 * coefB2 - coefB1 * coefA2);
            int pointY = -(coefA1 * coefC2 - coefC1 * coefA2) / (coefA1 * coefB2 - coefB1 * coefA2);
            Console.WriteLine($"Pointer with coordinat [{pointX} , {pointY}]");
            if (pointX > 0 && pointY > 0) Console.WriteLine("Point in first quater");
            if (pointX > 0 && pointY < 0) Console.WriteLine("Point in third quater");
            if (pointX < 0 && pointY > 0) Console.WriteLine("Point in second quater");
            if (pointX < 0 && pointY < 0) Console.WriteLine("Point in fourth quater");
        }

        if ((coefA1 * coefB2 - coefB1 * coefA2 == 0) && ((coefA1 * coefC2) - (coefA2 * coefC1) == 0) && ((coefC1 * coefB2) - (coefB1 * coefC2) == 0))
        {
            Console.WriteLine("Vector AB and CD are match!!!");
        }
    }

    public static (double, double) point()
    {
        Random rnd = new Random();

        double x = rnd.Next(-1000, 1000);
        double y = rnd.Next(-1000, 1000);

        return (x, y);
    }
}