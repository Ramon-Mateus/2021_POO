using System;

class mainClass {
  public static void Main (string[] args) {
    viagem x = new viagem();
    Console.WriteLine("Digite a distância percorrida:");
    x.SetDistancia(double.Parse(Console.ReadLine()));
    Console.WriteLine("Digite o tempo gasto em horas:");
    x.SetTempo(double.Parse(Console.ReadLine()));
    Console.WriteLine($"Velocidade média: {x.velMedia():0.00} km/h");
  }
}

class viagem {
  private double distancia;
  private double tempo;

  public void SetDistancia(double v) {
    if (v > 0) distancia = v;
  }
  
  public void SetTempo(double v) {
    if (v > 0) tempo = v;
  }

  public double GetDIstancia() {
    return distancia;
  }

  public double GetTempo() {
    return tempo;
  }

  public double velMedia() {
    double vm = distancia / tempo;
    return vm;
  }
}