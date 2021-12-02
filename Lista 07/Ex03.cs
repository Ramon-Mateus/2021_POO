using System;

class mainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite seu nome completo:");
    string x = Console.ReadLine();
    string r = Iniciais(x);
    Console.WriteLine(r);
  }
  public static string Iniciais(string nome) {
    string v = "";
    string[] res = nome.Split(' ');
    int q = res.Length;
    for (int i = 0; i < q; i++) {
      v += res[i][0];
    }
    return v;
  }
}