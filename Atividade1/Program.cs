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

        /*aula12 e aula 13

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
            if(media >= 9)
            {
                Console.WriteLine("Aprovado com louvor");
            }
            else
            {
                Console.WriteLine("Aprovado");
            }
        }
        else
        {
            if(media >= 4)
            {
                Console.WriteLine("Recuperação");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
            
        }
        */

        /*aula 15 e 16 SWITCH e GOTO
        var veiculo = "";
        char escolha;
        int tempo;
        
        inicio:

        Console.Clear();

        Console.WriteLine("Sobral a fortaleza");
        Console.WriteLine("Escolha o transporte:[a]Aviao | [c]Carro | o[Onibus]");
        escolha = char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'a':
            case 'A':
                tempo = 50;
                veiculo = "Aviao";
                break;
            case 'c':
            case 'C':
                tempo = 480;
                veiculo = "Carro";
                break;
            case 'o':
            case 'O':
                tempo = 660;
                veiculo = "Onibus";
                break;
            default:
                tempo = -1;
                break;
        }
        if(tempo < 0)
        {
            Console.WriteLine("Transporte indisponivel!");
        }
        else
        {
            Console.WriteLine($"Sua viagem sera de  {veiculo} e o tempo será de {tempo} minutos");
        }

        Console.Write("\nCalcular outro transporte?[s/n]: ");
        escolha = char.Parse(Console.ReadLine());

        if (escolha == 's' || escolha == 'S')
        {
            goto inicio;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Fim do Programa!");
        }
        */

        /*aula 17 ARRAY

        int n1, n2, n3, n4, n5;
        int[] n = new int[5]; //posicao 0-4
        //int[] num = new int[3] { 55, 77, 99}; 
        int[] num = { 100, 200, 300}; //array tera o numero de elementos que foi
                                      //inserido na declaracao
        string[] veiculos = new string[3];

        veiculos[0] = "Carro";
        veiculos[1] = "Aviao";
        veiculos[2] = "Navio";

        n[0] = 11;
        n[1] = 22;
        n[2] = 33;
        n[3] = 44;
        n[4] = 55;

        Console.WriteLine(num[2]);
        */

        /*aula 18 MATRIZES
        int t = 10;
        int[,] n = new int[5, 5];
        for(int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                n[i, j] = t;
                t+=5;
            } 
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{n[i,j]} ");
            }
            Console.Write("\n");
        }
        */
        /*LOOPS

        for(int i = 0; i <= 10; i++)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine($"{i} é par");
            }
            else
            {
                Console.WriteLine($"{i} é impar");
            }
        }
        
        int i = 0;
        int numero = 10;
        while( numero > i )
        { 
            Console.WriteLine( i ); 
            i++;
        } 
        
        string senha = "123";
        string senhaUser;
        int tentativas = 0;
        do //do sempre executa pelo menos uma vez
        {
            Console.Clear();
            Console.WriteLine("Digite sua senha");
            senhaUser = Console.ReadLine();
            tentativas++;
        } while (senhaUser != "123");

        Console.WriteLine($"Senha correta, tentativas {tentativas}");
        

        int[] num = new int[] { 11, 22, 33, 44 };
        //foreach é usado com arrays

        foreach(int valor in num) //variavel pode ter qualquer nome
        {
            Console.WriteLine(valor);
        }
        */
        /*Metodos de Array*/

        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2, 5]{{ 11, 22, 00, 44, 55 },{ 66, 77, 88, 99, 00 } };

        Random random = new Random();
        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i] = random.Next(50);
        }

        Console.WriteLine("Elementos do vetor1");
        foreach (int n in vetor1)
        {
            Console.Write($"{n} ");
        }

        //public static int BinarySearch(array,valor);
        Console.WriteLine("BinarySearch");
        int procurado = 33;
        int pos = Array.BinarySearch(vetor1, procurado);
        Console.WriteLine($"Valor {procurado} está na posição {pos}");
        Console.WriteLine("-------------------------------------------");
        
        //public static void Copy(Ar_origem,Ar_destino,qtde_elementos);
        Console.WriteLine("Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach (int n in vetor2)
        {
            Console.Write($"{n} ");
        }

        //public void CopyTo(Ar_destino,a_partir_desta_pos);
        Console.WriteLine("CopyTo \n");
        vetor1.CopyTo(vetor3, 0);
        foreach (int n in vetor3)
        {
            Console.Write($"{n} ");
        }
        Console.WriteLine("\n-------------------------------------------");

        //public longe GetLongLenght(dimensão);
        Console.WriteLine("GetLongLenght");
        long qtdeElementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine($"Quantidade de elementos: {qtdeElementosVetor}");
        Console.WriteLine("-------------------------------------------");

        //public int GetLowerBound(dimensão);
        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine($"Menor Índice do vetor1: {MenorIndiceVetor}");
        Console.WriteLine("-------------------------------------------");

        //public int GetUpperBound
        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
        Console.WriteLine($"Maior índice do vetor1: {MaiorIndiceVetor}");
        Console.WriteLine("-------------------------------------------");   

        //public object GetValue(long índice);
        Console.WriteLine("GetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1, 3));
        Console.WriteLine("Valor da posição 3 do vetor1: {0}", valor0);
        Console.WriteLine("-------------------------------------------");

        //public static int IndexOf(array,valor);
        Console.WriteLine("IndexOf");
        int indice1 = Array.IndexOf(vetor1, 3);
        Console.WriteLine("Indice do primeiro valor 3:{0}", indice1);
        Console.WriteLine("-------------------------------------------");

        //public static int LastIndexOf(array,valor):
        Console.WriteLine("LastIndexOf");
        int indice2 = Array.LastIndexOf(vetor1, 3);
        Console.WriteLine("Indice do último valor 33:{0}", indice2);
        Console.WriteLine("-------------------------------------------");

        //public static void Reverse(array);
        Array.Reverse(vetor1);
        foreach (int n in vetor1)
        {
            Console.Write($"{n} ");
        }
        Console.Write("\n");

        //public void SetValue(object valor, long pos);
        vetor2.SetValue(30, 0);
        for (int i = 0; i < vetor2.Length; i++)
        {
            vetor2.SetValue(0, i);
        }
        Console.WriteLine("Vetor 2");
        foreach (int n in vetor2)
        {
            Console.Write($"{n} ");
        }

        //public static void Sort(array);
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("\nVetor1\n");
        foreach (int n in vetor1)
        {
            Console.Write($"{n} ");
        }
        Console.WriteLine("\nVetor2\n");
        foreach (int n in vetor2)
        {
            Console.Write($"{n} ");
        }
        Console.WriteLine("\nVetor3\n");
        foreach (int n in vetor3)
        {
            Console.Write($"{n} ");
        }
    }
}


