using System;
using System.Collections;
using System.Globalization;
using System.Threading;

class mainClass {
  public static void Main (string[] args) {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-br");
  
    Aluno x = new Aluno { Nome = "Ramon", Matricula = "20201011110008", Nascimento = DateTime.Parse("07/07/2003") };
    Aluno y = new Aluno { Nome = "Raquel", Matricula = "20201011110010", Nascimento = DateTime.Parse("18/07/2004") };
    Aluno z = new Aluno { Nome = "Sabrina", Matricula = "20201011110009", Nascimento = DateTime.Parse("04/11/2005") };

    AlunoMatriculaComp comp1 = new AlunoMatriculaComp();
    AlunoNascimentoComp comp2 = new AlunoNascimentoComp();
    
    Aluno[] v = { y, x, z };
    Array.Sort(v, comp2);

    foreach (Aluno i in v)
      Console.WriteLine(i);
    
  }
}

class Aluno : IComparable {
  public string Nome { get; set; }
  public string Matricula { get; set; }
  public DateTime Nascimento { get; set; }

  public int CompareTo(object obj) {
    Aluno x = (Aluno) obj;
    return this.Nome.CompareTo(x.Nome);
  }

  public override string ToString() {
    return $"Nome: {Nome}, Matrícula: {Matricula}, Nascimento: {Nascimento}";
  }
  
}

class AlunoMatriculaComp : IComparer {
  public int Compare(object x, object y) {
    Aluno a = (Aluno) x;
    Aluno b = (Aluno) y;
    return a.Matricula.CompareTo(b.Matricula);
  }
}


class AlunoNascimentoComp : IComparer {
  public int Compare(object x, object y) {
   Aluno a = (Aluno) x;
   Aluno b = (Aluno) y;
   return b.Nascimento.CompareTo(a.Nascimento);
  } 
}