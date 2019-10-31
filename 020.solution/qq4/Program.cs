using System;
using System.Collections.Generic;
using System.Xml;

class Agenda
{
    private List<Contato> listc = new List<Contato>();
    public void Inserir(Contato c)
    {
        listc.Add(c);
    }
    public List<Contato> Listar()
    {
        return listc;
    }
    public List<Contato> Pesquisar(string ini)
    {
        List<Contato> cd = new List<Contato>();
        foreach (Contato x in listc)
        {
            if (x.Nome.IndexOf(ini) != -1) cd.Add(x);
        }
        return cd;
    }
   
    public void Salvar()
    {

    }
    public void Abrir()
    {

    }
}
class Contato
{
    public string Nome { set; get; }
    public string Email { set; get; }
    public string Fone { set; get; }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("!!!");
        Console.ReadKey();
    }
}