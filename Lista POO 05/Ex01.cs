using System;
using System.Globalization;
using System.Threading;

class mainClass {
  public static void Main (string[] args) {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-br");
    Console.WriteLine("Digite seu nome, cpf, telefone e data de nascimento:");
    string n = Console.ReadLine();
    string c = Console.ReadLine();
    string t = Console.ReadLine();
    DateTime d = DateTime.Parse(Console.ReadLine());
    paciente p = new paciente(n, c, t, d);
    Console.WriteLine(p.ToString());
    Console.WriteLine(p.idade());
  }
}

class paciente {
  private string nome;
  private string cpf;
  private string telefone;
  private DateTime nascimento;

  public paciente(string n, string c, string t, DateTime d) {
    nome = n;
    cpf = c;
    telefone = t;
    nascimento = d;
  }

  public string idade() {
    DateTime hoje = DateTime.Now;
    int a = hoje.Year - nascimento.Year;
    int m = hoje.Month - nascimento.Month;
    if (m < 0) {
      m += 12;
      a--;
    }
    return $"{a} anos - {m} meses";
  }

  public override string ToString() {
    return $"{nome} - {cpf} - {telefone} - {nascimento}";
  }
}