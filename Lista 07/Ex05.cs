using System;

class mainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite seu nome:");
    string x = Console.ReadLine();
    string r = FormatarNome(x);
    Console.WriteLine(r);
  }
  public static string FormatarNome(string nome) {
    nome = nome.ToLower();
    string[] v = nome.Split(' ');
    string res = "";
    for (int i = 0; i < v.Length; i++) {
      char pl = char.ToUpper(v[i][0]);
      string names =  v[i].Substring(1);
      res += pl + names + " ";
    }
    return res;
  }
}