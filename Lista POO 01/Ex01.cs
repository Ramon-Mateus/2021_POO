using System;

class mainClass {
  public static void Main (string[] args) {
    circulo x = new circulo();
    x.raio = double.Parse(Console.ReadLine());
    Console.WriteLine(x.calcArea());
    Console.WriteLine(x.calcCircun());
  }
}

class circulo {
  public double raio;
  public double PI = 3;

  public double calcArea() {
    double area = PI * raio * raio;
    return area;
  }

  public double calcCircun() {
    double circun = PI * 2 * raio;
    return circun;
  }
}