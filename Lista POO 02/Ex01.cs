using System;

class mainClass {
  public static void Main (string[] args) {
    circulo x = new circulo();
    x.SetRaio(double.Parse(Console.ReadLine()));
    Console.WriteLine(x.calcArea());
    Console.WriteLine(x.calcCircun());
  }
}

class circulo {
  private double raio;
  private double PI = 3;

  public void SetRaio(double v) {
    if (v > 0) raio = v;
  }

  public double GetRaio() {
    return raio;
  }

  public double calcArea() {
    double area = PI * raio * raio;
    return area;
  }

  public double calcCircun() {
    double circun = PI * 2 * raio;
    return circun;
  }
}