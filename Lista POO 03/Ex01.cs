using System;

class mainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o valor da Base");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor da Altura");
    double b = double.Parse(Console.ReadLine());
    retangulo x = new retangulo(a, b);
    Console.WriteLine(x.ToString());
  }
}

class retangulo {
  private double b;
  private double h;

  public retangulo(double Base, double altura) {
    SetBase(Base);
    SetAltura(altura);
  }

  public void SetBase(double b) {
    if (b > 0) this.b = b;
  }

  public void SetAltura(double h) {
    if (h > 0) this.h = h;
  }

  public double GetBase() {
    return b;
  }

  public double GetAltura() {
    return h;
  }

  public double CalcArea() {
    return b * h;
  }

  public double CalcDiagonal() {
    return Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));
  }

  public override string ToString() {
    return $"Base = {b}, Altura = {h}, Área = {CalcArea()}, Diagonal = {CalcDiagonal(): 0.00}";
  }

}