using System;

class mainClass {
  public static void Main (String[] args) {
    int n = int.Parse(Console.ReadLine());
    for (int i = 1; i <= n; i++) {
      string x = Console.ReadLine();
      string[] v = x.Split(' ');
      double a = int.Parse(v[0]);
      double b = int.Parse(v[1]);
      if (b == 0) Console.WriteLine("divisao impossivel");
      else Console.WriteLine($"{a/b:0.0}");
    }
  }
}