using System;
using System.Collections;
using System.IO;
namespace test;

class Tools
{
  private string originalName;
  private int originalCanh;
  public Tools() {
    originalName = "";
    originalCanh = 0;
  }
  public int getCanh() 
  {
    return originalCanh;
  }
  public Tools(string name, int canh)
  {
    originalName = name;
    originalCanh = canh;
  }
  public string GetNameOfObject() 
  {
    return originalName;
  }
  public static void GetNameOfTools()
  {
    Console.WriteLine("This is a collection of tools.");
  }
  public void CV(int canh, out int cv, out int dt) 
  {
    cv = 4 * canh;
    dt = canh * canh;
  }
}

class Program
{
  public static void Main(string[] args)
  {
    Tools.GetNameOfTools();
    Tools a = new Tools("I'm a tool", 4);
    Tools.GetNameOfTools();
    // Console.WriteLine(a.GetNameOfObject());
    int cv, dt;
    Console.WriteLine(a.getCanh());
    a.CV(a.getCanh(),out cv,out dt);
    Console.WriteLine(cv);

  }

}