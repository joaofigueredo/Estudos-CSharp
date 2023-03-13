using System;
using System.Collections.Generic;
class Aula51
{
    static void Main()
    {
        Dictionary <int, string> veiculos = new Dictionary<int, string>();

        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Avião");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto");
        veiculos.Add(15, "Patinete");

        //veiculos.Clear();
        


        int chave = 30;
        if(veiculos.ContainsKey(chave))
        {
            Console.WriteLine($"A chave {chave} esta na coleção");
        }
        else
        {
               
            Console.WriteLine($"A chave {chave} não esta na coleção");
        }

        veiculos[15] = "Bicicleta";
        string valor = "Bicicleta";

        if (veiculos.ContainsValue(valor))
        {
            Console.WriteLine($"O valor {valor} esta na coleção");
        }
        else
        {
            Console.WriteLine($"O valor {valor} não esta na coleção");
        }

        foreach (KeyValuePair<int, string> v in veiculos)
        {
            Console.WriteLine(v.Value);
        }
    }
}
