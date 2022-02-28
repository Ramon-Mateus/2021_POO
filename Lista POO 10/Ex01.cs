using System;

class mainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine("1 - Definir novo retângulo");
    Console.WriteLine("2 - Definir base");
    Console.WriteLine("3 - Definir altura");
    Console.WriteLine("4 - Retornar a area");
    Console.WriteLine("5 - Retornar Diagonal");
    Console.WriteLine("0 - Finalizar programa");
    string n = Console.ReadLine();
    Retangulo x = null;
    while(n != "0") {
      try {
        if (n == "1") {
          x = new Retangulo();
        } else if (n == "2") {
          Console.WriteLine("Digite o valor da Base:");
          double b = double.Parse(Console.ReadLine());
          x.SetBase(b);
        } else if(n == "3") {
          Console.WriteLine("Digite o valor da Altura:");
          double h = double.Parse(Console.ReadLine());
          x.SetAltura(h);
        } else if (n == "4") {
          Console.WriteLine(x.Area);
        } else if (n == "5") {
          Console.WriteLine(x.Diagonal);
        }
      } catch (ArgumentOutOfRangeException) {
        Console.WriteLine("É preciso informar um número positivo!");
      } catch (Exception erro) {
        Console.WriteLine(erro.Message);
      } finally {
        Console.WriteLine("1 - Definir novo retângulo");
        Console.WriteLine("2 - Definir base");
        Console.WriteLine("3 - Definir altura");
        Console.WriteLine("4 - Retornar a area");
        Console.WriteLine("5 - Retornar Diagonal");
        Console.WriteLine("0 - Finalizar programa");
        n = Console.ReadLine();
      }
    }
    
  }
}

class Retangulo {
  private double b;
  private double h;

  public string Area { get => $"Área: {b * h}"; }
  public double Diagonal { get => Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2)); }
  
  public void SetBase(double b) {
    if (b > 0) this.b = b;
    else throw new ArgumentOutOfRangeException("Base Inválida");
  }

  public double GetBase() {
    return b;
  }

  public void SetAltura(double h) {
    if (h > 0) this.h = h;
    else throw new ArgumentOutOfRangeException("Altura Inválida");
  }

  public double GetAltura() {
    return h;
  }
  
}