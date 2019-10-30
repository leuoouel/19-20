using System;
using System.Collections;

class FreteX : Frete
{
    private decimal seguro;
    public FreteX(double d, double p, decimal s) : base(d, p)
    {
        seguro = s;
    }
    public override decimal CalcFrete()
    {
        return base.CalcFrete() * 2 + (decimal)(0.01) * seguro;
    }
    public override string ToString()
    {
        return $"FreteX: {CalcFrete()}";
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


class Frete
{

    private double distancia;
    private double peso;

    public Frete(double d, double p)
    {

        if (d > 0) { distancia = d; }
        if (p > 0) { peso = p; }
    }
    public double GetPeso()
    {
        return peso;
    }
    public double GetDist()
    {
        return distancia;
    }
    public virtual decimal CalcFrete()
    {
        return Convert.ToDecimal(distancia * peso) * Convert.ToDecimal(0.01);
    }
    public override string ToString()
    {
        return $"Frete: distância = {distancia} ---- peso = {peso} ---- Preço do frete{CalcFrete()}";
    }
}
