using System;
using System.IO;
class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Nhap n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    long S1 = 0;
    double S2 = 0;
    for (int i = 1; i <= n; i++) {
      S1 += i;
      double tmp = 1.0 / i;
      S2 += tmp;
    }
    Console.WriteLine("a) S = " + S1);
    Console.WriteLine("b) S = " + S2);
  }
}