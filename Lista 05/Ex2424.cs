using System;

class mainClass {
  public static void Main (String[] args) {
    string x = Console.ReadLine();
    string[] v = x.Split(' ');
    int n1 = int.Parse(v[0]);
    int n2 = int.Parse(v[1]);
    if (n1 >= 0 && n1 <= 432 && n2 >= 0 && n2 <= 468) Console.WriteLine("dentro");
    else Console.WriteLine("fora");
  }
}