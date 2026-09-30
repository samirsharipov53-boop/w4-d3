public static class Geo
{
    public static double CircleArea(double p)
    {
        const double Pi=3.14;
        return Pi*p*p;
    }
    public static double CirclePerimeter(double p)
    {
         const double Pi=3.14;
        return 2*Pi*p;

    }

    public static double RecArea(double w, double h)
    {
        return w*h;
    }
    public static double RecPerimetr(double w, double h)
    {
        return (w+h)*2;
    }

    public static double TriArea(double b, double h)
    {
        double a =0.5;
        return a*b*h;
    }
    public static double TriPerimeter(double c,double b, double h)
    {
        return c+b+h;
    }
}