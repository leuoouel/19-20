using System;

class Contato
{
    private string nome;
    private string fone;
    public Contato(string n, string f)
    {
        nome = n;
        fone = f;
    }
    public override string ToString()
    {
        return $"{nome} - {fone}";
    }
}
class Usuario : Contato
{

    private Contato[] contatos = new Contato[100];
    private Grupo[] grupos = new Grupo[100];

    private int la;
    private int le;
    public Usuario(string n, string f) : base(n, f) { }
    public void InserirContato(Contato c)
    {
        if (la < 100 && Array.IndexOf(contatos, c) == -1) contatos[la++] = c;
    }
    public void InserirGrupo(Grupo g)
    {
        if (le < 50 && Array.IndexOf(grupos, g) == -1) grupos[le++] = g;
    }
    public Contato[] ListarContatos()
    {
        Contato[] novo = new Contato[la];
        Array.Copy(contatos, novo, la);
        return novo;
    }
    public Grupo[] ListarGrupos()
    {
        Grupo[] novo = new Grupo[le];
        Array.Copy(grupos, novo, le);
        return novo;
    }
    public override string ToString()
    {
        return base.ToString() + $" - {la} contatos - {le} grupos";
    }
}
class Grupo
{
    private string descricao;
    private Contato[] contatos = new Contato[100];
    private int la;
    public Grupo(string d) { descricao = d; }
    public void Adicionar(Contato c)
    {

        if (la < 100 && Array.IndexOf(contatos, c) == -1) contatos[la++] = c;
    }
    public void Excluir(Contato c)
    {
        int p = Array.IndexOf(contatos, c);
        for (int i = p + 1; i < la; i++)
        {
            contatos[i - 1] = contatos[i];
        }
        la--;
    }
    public Contato[] ListarContatos()
    {
        Contato[] novo = new Contato[la];
        Array.Copy(contatos, novo, la);
        return novo;
    }
    public override string ToString()
    {
        return $"{descricao} - {la} contatos";
    }
}
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("!!!");
        Console.ReadKey();

    }
}