using System;

class mainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite dois valores:");
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    double m = Maior(x, y);
    Console.WriteLine(m);
}
  public static double Maior(double a, double b) {
    if (a > b) {
      return a;
    } else {
      return b;
    }
  }
}