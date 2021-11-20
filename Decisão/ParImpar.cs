using System;

class mainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite um valor inteiro:");
    int n = int.Parse(Console.ReadLine());

    if (n % 2 == 0) {
      Console.WriteLine("Par");
    } else {
      Console.WriteLine("Ímpar");
    }
  }
}