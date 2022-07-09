using System;
using System.IO;
class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Nhap ten hoc sinh: ");
    string name = Console.ReadLine();
    Console.WriteLine("Nhap diem hoc sinh: ");
    double diem = Convert.ToDouble(Console.ReadLine());
    if (!string.IsNullOrEmpty(name))
    {
      Console.WriteLine(name.ToUpper());
    }
    if (diem >= 8)
    {
      Console.WriteLine("Hoc sinh gioi");
    }
    else if (diem >= 6.5 && diem < 8)
    {
      Console.WriteLine("Hoc sinh kha");
    }
    else if (diem >= 5 && diem < 6.5)
    {
      Console.WriteLine("Hoc sinh trung binh");
    }
    else
    {
      Console.WriteLine("Hoc sinh yeu");
    }
  }
}