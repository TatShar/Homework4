// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Input number A: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Input number B: ");
double b = Convert.ToDouble(Console.ReadLine());

double RaiceToPower (double x, double y)
{

    double result = Math.Pow(x,y);
    return result;

}
double res = RaiceToPower(a,b);
Console.WriteLine("Результатом возведения числа А в степень В является: "+ res);