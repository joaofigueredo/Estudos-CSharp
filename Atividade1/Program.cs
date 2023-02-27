using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

class Atividade1
{
    enum DiasSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sabado };//aula10
    static void Main()
    {
        /*
        //aula 3 
        int numero = 15;
        char letra = 'A'; //char usa aspa simples
        string nome = "joao"; //string usa aspas duplas e é um conjunto de string
        float dinheiro = 3.15f; //usamos o f no fim para dizer que é float

        var aux = 10; /*não especifica o tipo da variavel na declaração,
                      o tipo é atribuido na compilação
        Console.WriteLine($"{nome} tirou nota {aux}");

        numero += 15;
        Console.WriteLine(numero);
        */
        // & = E
        // | = ou
        /* aula 6
        double valorCompra = 5.5;
        double valorVenda;
        double lucro = 0.01;
        string produto = "Pastel";

        valorVenda = (valorCompra * lucro) + valorCompra;

        Console.WriteLine($"Produto........: {produto}");
        Console.WriteLine($"Val.compra.....: {valorCompra}");
        Console.WriteLine($"Lucro..........: {lucro}");
        Console.WriteLine($"Val.venda......: {valorVenda}");
        */

        /*aula 07
        const string nome = "João Carlos";
        const double pi = 3.1415;

        Console.WriteLine($"{nome} {pi}");
        */
        //nome = "Marcos"; (erro)

        /*aula 8

        int v1, v2, soma;
        string nome;
        Console.WriteLine("Digite o seu nome:");
        nome = Console.ReadLine();

        Console.WriteLine("Digite o primeiro numero:");
        v1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o primeiro numero:");
        v2 = Convert.ToInt32(Console.ReadLine());
        
        soma = v1 + v2;

        Console.WriteLine($"A soma de {v1} + {v2} é {soma}");

        */

        //aula 10

        /*
        DiasSemana dia = (DiasSemana)3; //equivale a posição no ENUM
        Console.WriteLine(dia);
        */

        /*aula 11
        float n1 = 10.5f;
        int n2 = (int)n1; //typecast

        Console.WriteLine(n2);
        */

        /*aula12 e aula 13*/

        Console.WriteLine("Digite o numero:");
        int numero = int.Parse(Console.ReadLine());

        if(numero % 2 == 0)
        {
            Console.WriteLine($"{numero} é par");
        }else
        {
            Console.WriteLine($"{numero} é impar");
        }

        int n1, n2, n3;
        Console.WriteLine("Digite as tres notas");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());

         double media = (n1 + n2 + n3) / 3;

        if(media >= 7)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }

    }
}


