using System;

class mainClass {
  public static void Main (string[] args) {
    viagem x = new viagem();
    Console.WriteLine("Digite a distância percorrida:");
    x.distancia = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o tempo gasto em horas:");
    x.tempo = double.Parse(Console.ReadLine());
    Console.WriteLine($"Velocidade média: {x.velMedia():0.00} km/h");
  }
}

class viagem {
  public double distancia;
  public double tempo;
  
  public double velMedia() {
    double vm = distancia / tempo;
    return vm;
  }
}