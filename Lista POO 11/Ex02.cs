using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

class mainClass {
  public static void Main (string[] args) {

    Loja l = null;

    Aplicativo app1 = new Aplicativo { Nome = "Whatsapp", Categoria = "Comunicação", Preco = 0 };
    Aplicativo app2 = new Aplicativo { Nome = "Instagram", Categoria = "Comunicação", Preco = 1 };
    Aplicativo app3 = new Aplicativo { Nome = "Minecraft", Categoria = "Jogos", Preco = 24.99 };
    Aplicativo app4 = new Aplicativo { Nome = "Free Fire", Categoria = "Jogos", Preco = 9.99 };
    Aplicativo app5 = new Aplicativo { Nome = "PicPay", Categoria = "Pagamentos", Preco = 3.50 };

    Console.WriteLine("1 - Abrir a loja");
    Console.WriteLine("2 - Listar apps");
    Console.WriteLine("3 - Listar o Apps pelo preço");
    Console.WriteLine("4 - Excluir um app");
    Console.WriteLine("5 - Pesquisar app pela categoria");
    Console.WriteLine("6 - Quantidade de apps na loja");
    Console.WriteLine("7 - Salvar Xml");
    Console.WriteLine("8 - Abrir Xml");
    Console.WriteLine("0 - Encerrar o programa");
    string n = Console.ReadLine();
    
    while(n != "0") {
      try {
        if(n == "1") {
          l = new Loja { Nome = "Google Play" };
          l.inserir(app1);
          l.inserir(app2);
          l.inserir(app3);
          l.inserir(app4);
          l.inserir(app5);
        } else if(n == "2") {
          foreach(Aplicativo c in l.listar()) Console.WriteLine(c);
        } else if(n == "3") {
          foreach(Aplicativo i in l.listarPreco()) Console.WriteLine(i);
        } else if(n == "4") {
          Console.WriteLine("Digite qual aplicativo você quer excluir:");
          int z = int.Parse(Console.ReadLine());
          switch(z) {
            case 1:
              l.excluir(app1);
              break;
            case 2:
              l.excluir(app2);
              break;
            case 3:
              l.excluir(app3);
              break;
            case 4:
              l.excluir(app4);
              break;
            case 5:
              l.excluir(app5);
              break;
            default:
              Console.WriteLine("Objeto inválido!");
              break;
          }
        } else if(n == "5") {
          Console.WriteLine("Digite a categoria desejada:");
          string a = Console.ReadLine();
          foreach(Aplicativo q in l.pesquisar(a)) Console.WriteLine(q);
        } else if(n == "6") {
          Console.WriteLine($"{l.Qtd} Aplicativos");
        } else if(n == "7") {
          l.salvarXml("Loja.xml");
        } else if(n == "8") {
          l.abrirXml("Loja.xml");
        }
      } catch(Exception erro) {
        Console.WriteLine(erro.Message);
      } finally {
        Console.WriteLine("1 - Abrir a loja");
        Console.WriteLine("2 - Listar apps");
        Console.WriteLine("3 - Listar o Apps pelo preço");
        Console.WriteLine("4 - Excluir um app");
        Console.WriteLine("5 - Pesquisar app pela categoria");
        Console.WriteLine("6 - Quantidade de apps na loja");
        Console.WriteLine("7 - Salvar Xml");
        Console.WriteLine("8 - Abrir Xml");
        Console.WriteLine("0 - Encerrar o programa");
        n = Console.ReadLine();
      }
    }
  }
}

class Loja {
  private List<Aplicativo> apps = new List<Aplicativo>();
  public string Nome { get; set; }
  public int Qtd { get; set; }

  public void inserir(Aplicativo app) {
    apps.Add(app);
    Qtd++;
  }

  public void excluir(Aplicativo app) {
    int n = 0;
    while(true) {
      if(app == apps[n]) {
        apps.RemoveAt(n);
        break;
      }
      n++;
      Qtd--;
    }
  }

  public List<Aplicativo> listar() {
    return apps;
  }

  public List<Aplicativo> pesquisar(string cat) {
    List<Aplicativo> aux = new List<Aplicativo>();
    int n  = 0;
    while(n < Qtd) {
      if(apps[n].Categoria == cat) {
        aux.Add(apps[n]);
      }
      n++;
    }
    return aux;
  }

  public List<Aplicativo> listarPreco() {
    Aplicativo[] aux2 = new Aplicativo[Qtd];
    List<Aplicativo> aux3 = new List<Aplicativo>();
    AppPreco ob1 = new AppPreco();

    for(int i = 0; i < Qtd; i++) {
      aux2[i] = apps[i];
    }

    Array.Sort(aux2, ob1);

    for(int k = 0; k < Qtd; k++) {
      aux3.Add(aux2[k]);
    }

    return aux3;
  }

  public void abrirXml(string arquivo) {
    XmlSerializer xml = new XmlSerializer(typeof(List<Aplicativo>));
    StreamReader f = new StreamReader(arquivo);
    List<Aplicativo> apps2 = (List<Aplicativo>)xml.Deserialize(f);
    f.Close();

    foreach(Aplicativo t in apps2) Console.WriteLine(t);
  }

  public void salvarXml(string arquivo) {
    XmlSerializer xml = new XmlSerializer(typeof(List<Aplicativo>));
    StreamWriter f = new StreamWriter(arquivo);
    xml.Serialize(f, apps);
    f.Close();
  }
}

public class Aplicativo : IComparable<Aplicativo> {
  private int curtidas;
  public string Nome { get; set; }
  public string Categoria { get; set; }
  public double Preco { get; set; }
  public int Curtidas { get; }

  public void curtir() {
    curtidas++;
  }

  public int CompareTo(Aplicativo obj) {
    return this.Nome.CompareTo(obj.Nome);
  }

  public override string ToString() {
    return $"Nome: {Nome} - Categoria: {Categoria} - Preço: {Preco} - Curtidas: {Curtidas}";
  }
}

class AppPreco : IComparer<Aplicativo> {
  public int Compare(Aplicativo x, Aplicativo y) {
    return x.Preco.CompareTo(y.Preco);
  }
}
