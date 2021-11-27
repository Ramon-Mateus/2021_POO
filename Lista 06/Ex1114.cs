using System;

class mainClass {
  public static void Main (String[] args) {
    string senha = Console.ReadLine();
    while (senha != "2002") {
      Console.WriteLine("Senha Invalida");
      senha = Console.ReadLine();
    }
    Console.WriteLine("Acesso Permitido");
  }
}