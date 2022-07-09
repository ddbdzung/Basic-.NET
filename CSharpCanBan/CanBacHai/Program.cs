using System;
using System.IO;
class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Nhap so n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Nhap epsilon a: ");
    double epsilon = Convert.ToDouble(Console.ReadLine());
    double result = 0;
    Console.WriteLine("Ket qua = " + result);
  }
}