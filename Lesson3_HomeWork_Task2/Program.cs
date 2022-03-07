public class Lesson3_HomeWork_Task2
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        double x1 = rnd.Next(-1000, 1000);
        double y1= rnd.Next(-1000, 1000);
        double z1 = rnd.Next(-1000, 1000);

        double x2 = rnd.Next(-1000, 1000);
        double y2 = rnd.Next(-1000, 1000);
        double z2 = rnd.Next(-1000, 1000);

        Console.WriteLine(lengthSection(x1, y1, z1, x2, y2, z2));
    }

    static double lengthSection(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double legX = x2 - x1;
        double legY = y2 - y1;
        double legZ = z2 - z1;

        return Math.Sqrt((legX * legX + legY * legY + legZ * legZ));
    }
}