using System;
using System.Collections.Generic;

class mainClass {
  public static void Main (string[] args) {

    Pais p1 = new Pais { nome = "Brasil", ouro = 25, prata = 30, bronze = 10 };
    Pais p2 = new Pais { nome = "Russia", ouro = 25, prata = 30, bronze = 10 };
    Pais p3 = new Pais { nome = "China ", ouro = 18, prata = 25, bronze = 30 };
    Pais p4 = new Pais { nome = "Japão ", ouro = 10, prata = 20, bronze = 50 };
    Pais p5 = new Pais { nome = "Canadá", ouro = 12, prata = 14, bronze = 25 };
    
    QuadroMedalhas x = new QuadroMedalhas();

    x.inserir(p1);
    x.inserir(p2);
    x.inserir(p3);
    x.inserir(p4);
    x.inserir(p5);
    
    foreach (Pais i in x.listar())
      Console.WriteLine(i);
    
  }
}

class QuadroMedalhas {
  List<Pais> paises = new List<Pais>();

  public void inserir(Pais p) {
    paises.Add(p);
  }

  public List<Pais> listar() {
    paises.Sort();
    return paises;
  }
  
}

class Pais  : IComparable<Pais> {
  public string nome { get; set; }
  public int ouro { get; set; }
  public int prata { get; set; }
  public int bronze { get; set; }

  public int CompareTo(Pais obj) {

    if(this.ouro > obj.ouro) return -1;
    if(this.ouro < obj.ouro) return 1;
    if(this.prata > obj.prata) return -1;
    if(this.prata < obj.prata) return 1;
    if(this.bronze > obj.bronze) return -1;
    if(this.bronze < obj.bronze) return 1;
    return this.nome.CompareTo(obj.nome);
    
  }

  public override string ToString() {
    return $"Nome: {nome}, Ouro: {ouro}, Prata: {prata}, Bronze: {bronze}";
  }
  
}