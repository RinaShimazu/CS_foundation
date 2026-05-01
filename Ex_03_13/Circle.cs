public class Circle
{
    public static double PI = 3.14;
    int radius;

    public Circle(int pradius)
    {
        this.radius = pradius;
    }

    public double AreaCalculation()
    {
        return radius * radius * PI;
    }
    public static double AreaCalculation(int pradius)
    {
        return pradius * pradius * PI;
    }
}

