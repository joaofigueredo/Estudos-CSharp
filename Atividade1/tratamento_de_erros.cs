using System;

class Area
{
    public static float Quad(float bas, float alt)
    {
        if(bas == 0 || alt == 0)
        {
            throw new Exception("Base e/ou altura não podem ser zero");
        }
        return bas * alt;
        
    }
}

class Aula51
{
    static void Main()
    {
        float area = 0;

        int n1, n2, res;
        res = n1 = n2 = 0;

        n1 = 10;
        n2 = 2;

        try
        {
            area = Area.Quad(10F, 5F);
            Console.WriteLine($"Area do quadrado = {area}");
        }
        catch(Exception e)//pega o erro que foi gerado
        {
            Console.WriteLine($"ERRO {e.Message}");
            Console.WriteLine($"Ex.: {e.GetType()}");
        }
        finally
        {
            Console.WriteLine("Fim do Processo!");
        }
    }
}   
