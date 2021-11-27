using System;

class mainClass {
  public static void Main (String[] args) {
    int a = 0;
    int b = 1;
    int n = int.Parse(Console.ReadLine());
    if (n == 1) Console.Write($"{a}");
      if (n >= 2) {
        Console.Write($"{a}");
        Console.Write($" {b}");
        for (int i = 3; i <= n; i++) {
          int c = a + b;
          Console.Write($" {c}");
          a = b;
          b = c;
        }
      }
  }
}