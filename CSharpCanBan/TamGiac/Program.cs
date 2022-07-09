using System;
using System.IO;
class Program
{
  public static void Main(string[] args)
  {
    double a, b, c;
    Console.WriteLine("Nhập vào độ dài 3 cạnh của tam giác:");
    a = Convert.ToDouble(Console.ReadLine());
    b = Convert.ToDouble(Console.ReadLine());
    c = Convert.ToDouble(Console.ReadLine());
    double cv = a + b + c;
    double p = cv / 2;
    double dt = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    Console.WriteLine("cv = " + cv);
    Console.WriteLine("dt = " + dt);
  }
}