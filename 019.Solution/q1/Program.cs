using System;
using System.Collections;

class Retangulo
{

    private double b, h;
    public Retangulo(double b, double h)
    {

        if (b > 0) { this.b = b; }

        if (h > 0) { this.h = h; }

    }
    public double GetBase()
    {
        return b;
    }
    public double GetAltura()
    {
        return h;
    }
    public double CalcArea()
    {
        return h * b;
    }
    public double CalcDiagonal()
    {
        double d = (b * b) + (h * h);
        return Math.Sqrt(d);

    }
    public override string ToString()
    {
        return $"Base = {b} | altura = {h} | area = {CalcArea()}Diagonal = {CalcDiagonal()}";
    }
}
class Quadrado : Retangulo
{

    public Quadrado(double i) : base(i, i) { }
    public override string ToString()
    {
        return $"lado = {GetAltura()} | area = {CalcArea()}Diagonal = {CalcDiagonal()}";
    }
}
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Deu certo! ?");
        Console.ReadKey();
    }
  
}
