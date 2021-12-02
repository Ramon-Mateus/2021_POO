using System;

class mainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite as duas notas:");
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    bool r = Aprovado(x, y);
    Console.WriteLine(r);
  }
  public static bool Aprovado(int nota1, int nota2) {
    double media = (nota1 + nota2) / 2;
    if (media >= 60) return true;
    else return false;
  }
}