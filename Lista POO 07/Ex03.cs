using System;
using System.Globalization;
using System.Threading;

class mainClass {
  public static void Main (string[] args) {
    //DateTime d = DateTime.Parse(Console.ReadLine());
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-br");

    Agenda x = new Agenda();
    
    Compromisso ob1 = new Compromisso { Assunto = "Prova de Português", Local = "C24", Data = DateTime.Parse("20/03/2022") };
    
    Compromisso ob2 = new Compromisso { Assunto = "Prova de Matemática", Local = "C24", Data = DateTime.Parse("21/03/2022") };
    
    Compromisso ob3 = new Compromisso { Assunto = "Prova de História", Local = "C24", Data = DateTime.Parse("22/04/2022") };

    Compromisso ob4 = new Compromisso { Assunto = "Prova de Filosofia", Local = "C24", Data = DateTime.Parse("23/04/2022") };

    
    x.inserir(ob1);
    x.inserir(ob2);
    x.inserir(ob3);
    x.inserir(ob4);
    Console.WriteLine(x.Qtd);

    foreach (Compromisso c in x.listar())
      Console.WriteLine(c);

    Console.WriteLine("-------------------------------------------------------------------");

    foreach (Compromisso w in x.pesquisar(03, 2022))
      Console.WriteLine(w);

    Console.WriteLine("-------------------------------------------------------------------");
    
    x.excluir(ob2);

    foreach (Compromisso q in x.listar())
      Console.WriteLine(q);
    
  }
}

class Agenda {
  private Compromisso[] comps = new Compromisso[40];
  private int k = 0;
  
  public int Qtd { get { return k; } }

  public void inserir(Compromisso c) {
    if (k < 40) {
      comps[k] = c;
      k++;
    }
  }

  public void excluir(Compromisso c) {
    DateTime aux = c.Data;
    int n = 0;
    
    while(true) {
      if (aux == comps[n].Data) {
        break;
      }
      n++;
    }
    for (int i = n; i <= k; i++) {
      comps[i] = comps[i + 1];
    }

    k -= 1;
  }

  public Compromisso[] listar() {
    Compromisso[] aux = new Compromisso[k];
    Array.Copy(comps, aux, k);
    return aux;
  }

  public Compromisso[] pesquisar(int mes, int ano) {
    Compromisso[] aux2 = new Compromisso[31];
    int n = 0;
    
    for (int i = 0; i < k; i++) {
      if(comps[i].Data.Year == ano && comps[i].Data.Month == mes) {
        aux2[n] = comps[i];
        n++;
      }
    }

    Compromisso[] aux3 = new Compromisso[n];
    Array.Copy(aux2, aux3, n);

    return aux3;
  }
  
}

class Compromisso {
  public string Assunto { get; set; }
  public string Local { get; set; }
  public DateTime Data { get; set; }

  public override string ToString() {
    return $"Assunto: {Assunto}, Local: {Local}, Data: {Data}";
  }
}