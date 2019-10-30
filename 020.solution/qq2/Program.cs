
using System;
using System.Collections;
using System.Collections.Generic;

class Pilha<ll>
{
    private List<ll> lista = new List<ll>();
    public int Count()
    {
        return lista.Count;
    }
    public ll Pop()
    {
        ll a;
        a = lista[Count()];
        lista.RemoveAt(Count());
        return a;
    }
    public void Push(ll obj)
    {
        lista.Insert(Count(), obj);
    }
    public ll Top()
    {
        ll a;
        a = lista[Count()];
        return a;
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

