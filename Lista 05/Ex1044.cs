using System;

class mainClass {
  public static void Main (String[] args) {
    string x = Console.ReadLine();
    string[] v = x.Split(' ');
    int x1 = int.Parse(v[0]);
    int x2 = int.Parse(v[1]);
    if (x1 % x2 == 0 || x2 % x1 == 0) {
      Console.WriteLine("Sao Multiplos");
    } else {
      Console.WriteLine("Nao sao Multiplos");
    }
  }
}