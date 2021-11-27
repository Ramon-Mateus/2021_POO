using System;

class mainClass {
  public static void Main (String[] args) {
    int q = int.Parse(Console.ReadLine());
    double c = 0;
    double r = 0;
    double s = 0;

    for (int i = 1; i <= q; i++) {
      string ent = Console.ReadLine();
      string[] v = ent.Split(' ');
      int a = int.Parse(v[0]);
      int b = char.Parse(v[1]);
      
      if (b == 'C') {
        c += a;
      } else {
        if (b == 'R') {
          r += a;
        } else {
          s += a;
        }
      }
    }

    double total = c + r + s;

    Console.WriteLine($"Total: {total} cobaias");
    Console.WriteLine($"Total de coelhos: {c}");
    Console.WriteLine($"Total de ratos: {r}");
    Console.WriteLine($"Total de sapos: {s}");
    Console.WriteLine($"Percentual de coelhos: {(c * 100)/total:00.00} %");
    Console.WriteLine($"Percentual de ratos: {(r * 100)/total:00.00} %");
    Console.WriteLine($"Percentual de sapos: {(s * 100)/total:00.00} %");
  }
}