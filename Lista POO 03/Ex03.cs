using System;

class mainClass {
  public static void Main (string[] args) {
  Console.WriteLine("Digite o valor de A, B e C:");
  double a = double.Parse(Console.ReadLine());
  double b = double.Parse(Console.ReadLine());
  double c = double.Parse(Console.ReadLine());
  equacao x = new equacao(a, b, c);
  Console.WriteLine(x.GetA());
  Console.WriteLine(x.GetB());
  Console.WriteLine(x.GetC());
  }
}

class equacao {
  private double a;
  private double b;
  private double c;

  public equacao(double a, double b, double c) {
    SetABC(a, b, c);
  }

  public void SetABC(double a, double b, double c) {
    this.a = a;
    this.b = b;
    this.c = c;
  }

  public double GetA() {
    return a;
  }

  public double GetB() {
    return b;
  }

  public double GetC() {
    return c;
  }

}