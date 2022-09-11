void PowNumber(int lim)
{
int powNum = 0;
for(int i = 1; i <= lim; i++)
{
    powNum = Convert.ToInt32(Math.Pow(i, 3));
    Console.WriteLine("Число в кубе равно: " + powNum );
}
}

Console.Write("Введите число: ");
int lim = Convert.ToInt32(Console.ReadLine());
PowNumber(lim);
