using System;

class mainClass {
  public static void Main (string[] args) {
    Frete x = new Frete();
    x.Distancia = 20;
    x.Peso = 10;
    Console.WriteLine(x.Distancia);
    Console.WriteLine(x.Peso);
    Console.WriteLine(x.ValorFrete);
    Console.WriteLine(x.ToString());
  }
}

class Frete {
  private double distancia;
  private double peso;

  public double Distancia {
    get { return distancia; }
    set { if (value > 0) distancia = value; }
  }

  public double Peso {
    get { return peso; }
    set { if (value > 0) peso = value; }
  }

  public double ValorFrete {
    get { return distancia/peso; }
  }

  public override string ToString() {
    return $"Distância: {distancia} km, Peso: {peso} kg";
  }
}