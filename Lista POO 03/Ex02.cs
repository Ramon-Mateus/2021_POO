using System;

class mainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o valor da distancia em KM:");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor do peso em KG:");
    double b = double.Parse(Console.ReadLine());
    frete x = new frete(a, b);
    Console.WriteLine(x.ToString());
  }
}

class frete {
  private double distancia;
  private double peso;

  public frete(double d, double p) {
    SetDistancia(d);
    SetPeso(p);
  }

  public void SetDistancia(double d) {
    if (d > 0) distancia = d;
  }

  public void SetPeso(double p) {
    if (p > 0) peso = p;
  }

  public double GetDistancia() {
    return distancia;
  }

  public double GetPeso() {
    return peso;
  }

  public double CalcFrete() {
    return 0.1 * peso * distancia;
  }

  public override string ToString() {
    return $"distancia = {distancia}, peso = {peso}, frete = R$ {CalcFrete():0.00}";
  }
}