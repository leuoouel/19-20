using System;
using System.Collections.Generic;

class Construtota
{
    private List<Funcionario> funcs = new List<Funcionario>();
    public void Inserir(Funcionario f)
    {
        funcs.Add(f);
    }
    public List<Funcionario> Funcionarios() { return funcs; }
    public List<Motorista> Motoristas()
    {
        List<Motorista> nova = new List<Motorista>();
        foreach (Funcionario i in funcs)
        {
            if (i != null && i is Motorista) nova.Add(i as Motorista);
        }
        return nova;
    }
    public List<Engenheiro> Engenheiros()
    {
        List<Engenheiro> nova = new List<Engenheiro>();
        foreach (Funcionario i in funcs)
        {
            if (i != null && i is Engenheiro) nova.Add(i as Engenheiro);
        }
        return nova;
    }
}
class Funcionario
{
    private string nome, email, fone;

    public void SetNome(string n) { nome = n; }
    public string GetNome() { return nome; }
    public void SetEmail(string e) { email = e; }
    public string GetEmail() { return email; }
    public void SetFone(string f) { fone = f; }
    public string GetFone() { return fone; }
    public override string ToString()
    {
        return $"{nome} - {email} - {fone}";
    }
}
class Motorista : Funcionario
{
    private string z;
    public void Setz(string c) { z = c; }
    public string Getz() { return z; }
    public override string ToString()
    {
        return $"nome: {GetNome()} - email:{GetEmail()} - telefone:{GetFone()} - {z}";
    }
}
class Engenheiro : Funcionario
{
    private string crea;
    public void SetCrea(string c) { crea = c; }
    public string GetCrea() { return crea; }
    public override string ToString()
    {
        return $"nome: {GetNome()} email: {GetEmail()} telefone: {GetFone()}  {crea}";
    }
}
class MainClass
{
    public static void Main(string[] args)
    {
        Construtota c = new Construtota();
        Engenheiro e = new Engenheiro();
        Console.WriteLine("!!!");
        Console.ReadKey();
    }
}
