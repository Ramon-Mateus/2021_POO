using System;

class mainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite três valores:");
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    double z = double.Parse(Console.ReadLine());
    double m = Maior(x, y, z);
    Console.WriteLine(m);
}
  public static double Maior(double a, double b, double c) {
    double maior = a;
    if (b > maior) maior = b;
    if (c > maior) maior = c;
    return maior;
  }
}