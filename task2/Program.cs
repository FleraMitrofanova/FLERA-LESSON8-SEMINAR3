double distance(double x1, double x2, double y1, double y2, double z1, double z2)
{
    return (Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)));
}

Console.WriteLine("Введите координату X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату X2: ");
double x2= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double result = distance(x1,x2,y1,y2,z1,z2);
Console.WriteLine(Math.Round(result,2));
