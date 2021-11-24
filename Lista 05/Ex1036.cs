using System;

class mainClass {
  public static void Main (String[] args){
    string s1 =  Console.ReadLine();
    string[] x = s1.Split(' ');
    double a = double.Parse(x[0]);
    double b = double.Parse(x[1]);
    double c = double.Parse(x[2]);
    double delta = (Math.Pow(b, 2)) - 4 * a * c;
    if (delta > -1 && a > 0) {
      double r1 = (-b + (Math.Sqrt(delta))) / (2 * a);
      double r2 = (-b - (Math.Sqrt(delta))) / (2 * a);
      Console.WriteLine($"R1 = {r1:0.00000}");
      Console.WriteLine($"R2 = {r2:0.00000}");
    } else {
      Console.WriteLine("Impossivel calcular");
    }
  }
}