using System;


class ContaEspecial : ContaCorrente
{

    private double limite;
    public ContaEspecial(string t, string n, double l) : base(t, n)
    {
        if (l > 0) limite = l;
    }
    public override bool Sacar(double valor)
    {
        if (valor <= saldo)
        {
            saldo = saldo - valor;
            return true;
        }
        if (valor <= limite)
        {
            saldo = saldo - limite;
            return true;
        }
        return false;
    }
}

class Poupanca : ContaCorrente
{

    public Poupanca(string t, string n) : base(t, n) { }
    public void RenderJuros(double juros)
    {
        saldo = saldo + saldo * juros;
    }
}

class ContaCorrente
{

    private string titular;
    private string numeroConta;
    protected double saldo;


    public ContaCorrente(string t, string n)
    {
        titular = t;
        numeroConta = n;
    }
    public void Depositar(double valor)
    {
        saldo += valor;
    }
    public virtual bool Sacar(double valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
            return true;
        }
        return false;
    }
    public double RetornarSaldo() { return saldo; }
    public override string ToString()
    {
        return $"Titular: {titular} | Número da Conta: {numeroConta} | Saldo: {saldo} R$";
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