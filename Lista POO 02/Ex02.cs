using System;

class mainClass {
  public static void Main (string[] args) {
    disciplina x = new disciplina();
    Console.WriteLine("Digite o nome da disciplina:");
    x.SetNome(Console.ReadLine());
    Console.WriteLine("Digite a nota dos quatros bimestres:");
    x.SetB1(double.Parse(Console.ReadLine()));
    x.SetB2(double.Parse(Console.ReadLine()));
    x.SetB3(double.Parse(Console.ReadLine()));
    x.SetB4(double.Parse(Console.ReadLine()));
    double media =  x.mediaParc();
    if (media >= 60) {
      Console.WriteLine($"Aluno aprovado por média em {x.GetNome()}: {media}");
    } else {
      Console.WriteLine($"Aluno em recuperação por media menor que 60: {media}");
      Console.WriteLine("Digite a nota da prova final:");
      x.SetFinal(double.Parse(Console.ReadLine()));
      Console.WriteLine($"Média final em {x.GetNome()}: {x.recup()}");
    }
  }
}

class disciplina {
  private string nome;
  private double b1, b2, b3, b4, final;

  public void SetNome(string n) {
    nome = n;
  }
  
  public void SetB1(double n) {
    if (n >= 0 && n <= 100) b1 = n;
  }
  
  public void SetB2(double n) {
    if (n >= 0 && n <= 100) b2 = n;
  }

  public void SetB3(double n) {
    if (n >= 0 && n <= 100) b3 = n;
  }

  public void SetB4(double n) {
    if (n >= 0 && n <= 100) b4 = n;
  }

  public void SetFinal(double n) {
    if (n >= 0 && n <= 100) final = n;
  }

  public string GetNome() {
    return nome;
  }

  public double GetB1() {
    return b1;
  }

  public double GetB2() {
    return b2;
  }

  public double GetB3() {
    return b3;
  }

  public double GetB4() {
    return b4;
  }

  public double GetFinal() {
    return final;
  }

  public double mediaParc() {
    double media = (b1 * 2 + b2 * 2 + b3 * 3 + b4 * 3) / 10;
    return media;
  }

  public double recup() {
    double recup = (mediaParc() + final) / 2;
    return recup;
  }
}