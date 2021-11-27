using System;

class mainClass {
  public static void Main (String[] args) {
    int maior = 0;
    int k = 0;
    for (int i = 1; i <= 100; i++) {
      int n = int.Parse(Console.ReadLine());
      if (n > maior) {
        maior = n;
        k = i;
      }
    }
    Console.WriteLine(maior);
    Console.WriteLine(k);
  }
}