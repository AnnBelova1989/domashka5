double Input(string message)
{
    System.Console.WriteLine(message);
    return double.Parse(Console.ReadLine());
}
bool PointCross(double n1, double n2, double n3, double n4)
{
    if (n2==n4)
     {
        System.Console.WriteLine("Прямые параллельные");
        return true;
     }
    else
    {
        double x= (n3-n1)/(n2-n4);
    double y= n2*x+n1;
 System.Console.WriteLine($"Точкой пересечения двух прямых является точка [{x},{y}] ");
 return false;

    }
}
double b1= Input("Введите свободный коэффициент b1 первой прямой: ");
double k1= Input("Введите угловой коэффициент k1 первой прямой: ");
double b2= Input("Введите свободный коэффициент b2 второй прямой: ");
double k2= Input("Введите угловой коэффициент второй прямой: ");
bool res = PointCross(b1,k1,b2,k2);
System.Console.WriteLine(res);