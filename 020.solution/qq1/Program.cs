using System;
using System.Collections;
using System.Collections.Generic;

class Conversor
{

    private int a;
    private Stack<int> p = new Stack<int>();
    public void SetNum(int n)
    {
        a = n;
    }
    public string Binario()
    {
        string aux = "", t = "";
        p.Push(a);
        do
        {
            if (a / 2 != 0)
            {
                aux += (a % 2).ToString();
                a /= 2;
            }
            if (a == 1)
            {
                aux += "1";
                a = 0;
            }
        } while (a != 0);

        for (int i = aux.Length - 1; i >= 0; i--)
        {
            t += aux[i];
        }
        return t;
    }
    public override string ToString()
    {
        return $"{a}";
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