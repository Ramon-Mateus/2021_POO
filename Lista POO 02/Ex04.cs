using System;

class mainClass {
  public static void Main (string[] args) {
    entrada x = new entrada();
    Console.WriteLine("Digite o dia da semana:");
    x.SetDia(Console.ReadLine());
    Console.WriteLine("Digite o hora:");
    x.SetHora(int.Parse(Console.ReadLine()));
    Console.WriteLine(x.valorBase());
  }
}

class entrada {
  private string dia;
  private int hora;
  private double vb = 0;

  public void SetDia(string v) {
    dia = v;
  }

  public void SetHora(int v) {
    if (v > 0 && v <= 24) hora = v;
  }

  public string GetDia() {
    return dia;
  }

  public int GetHora() {
    return hora;
  }

  public double valorBase() {
    if (dia == "segunda" || dia == "terça" || dia == "quinta") {
      vb = 16;
    } else {
      if (dia == "sexta" || dia == "sabado" || dia == "domingo") {
        vb = 20;
      } else {
        return 8;
      }
    }
    return meia();
  }

  public double meia() {
    if (hora >= 17 && hora <= 24) {
      return vb + (vb / 2);
    } else {
      return vb;
    }
  }
}