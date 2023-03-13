using System;

class Calc
{
    public int soma(params int[] n)
    {
        int somador = 0;
        for(int i  = 0; i < n.Length; i++)
        {
            somador += n[i];
        }

        return somador;
    }

    public double soma(params double[] n)
    {
        double somador = 0;
        for(int i = 0; i < n.Length; i++)
        {
            somador += n[i];
            
        }
        return somador;
    }

    public int fatorial(int numero)
    {
        int resultado;
        if(numero <= 1)
        {
            resultado = 1;
        }
        else
        {
            resultado = numero * fatorial(numero - 1);
        }

        return resultado;
    }
}

class Aula43
{
    static void Main()
    {
        int n;
        Calc calc = new Calc();
        n = calc.fatorial(10);
        Console.WriteLine($" o fatorial é {n}");
    }
}   
