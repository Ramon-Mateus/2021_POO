using System;

class mainClass {
  public static void Main (string[] args) {
    disciplina x = new disciplina();
    Console.WriteLine("Digite o nome da disciplina:");
    x.nome = Console.ReadLine();
    Console.WriteLine("Digite a nota dos quatros bimestres:");
    x.b1 = double.Parse(Console.ReadLine());
    x.b2 = double.Parse(Console.ReadLine());
    x.b3 = double.Parse(Console.ReadLine());
    x.b4 = double.Parse(Console.ReadLine());
    double media =  x.mediaParc();
    if (media >= 60) {
      Console.WriteLine($"Aluno aprovado por média em {x.nome}: {media}");
    } else {
      Console.WriteLine($"Aluno em recuperação por media menor que 60: {media}");
      Console.WriteLine("Digite a nota da prova final:");
      x.final = double.Parse(Console.ReadLine());
      Console.WriteLine($"Média final em {x.nome}: {x.recup()}"); 
    }
  }
}

class disciplina {
  public string nome;
  public double b1, b2, b3, b4, final;

  public double mediaParc() {
    double media = (b1 * 2 + b2 * 2 + b3 * 3 + b4 * 3) / 10;
    return media;
  }

  public double recup() {
    double recup = (mediaParc() + final) / 2;
    return recup;
  }
}