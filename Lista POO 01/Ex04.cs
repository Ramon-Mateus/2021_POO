using System;

class mainClass {
  public static void Main (string[] args) {
    entrada x = new entrada();
    x.dia = Console.ReadLine();
    x.hora = int.Parse(Console.ReadLine());
    Console.WriteLine(x.valorBase());
  }
}

class entrada {
  public string dia;
  public int hora;
  public double vb = 0;

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