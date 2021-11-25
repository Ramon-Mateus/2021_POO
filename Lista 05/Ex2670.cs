using System;

class mainClass {
  public static void Main (String[] args) {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());

    int t1 = b * 2 + c * 4;
    int t2 = a * 2 + c * 2;
    int t3 = a * 4 + b * 2;

    int menor = t1;

    if (t2 < menor) menor = t2;
    if (t3 < menor) menor = t3;

    Console.WriteLine(menor);
  }
}