using System;
struct Carro
{
    public string marca;
    public string modelo;

    public string cor;

    public Carro(string marca, string modelo, string cor)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }

    public void info()
    {
        Console.WriteLine($"Marca.: {this.marca}");
        Console.WriteLine($"Modelo: {this.modelo}");
        Console.WriteLine($"Cor...: {this.cor}");
        Console.WriteLine("----------------------");

    }
}
class Aula43
{
    static void Main()
    {
        
        Carro[] carros = new Carro[4];
        carros[0] = new Carro("Honda", "HRV", "Prata");
        carros[1] = new Carro("VW", "Hillux", "preto");
        carros[2] = new Carro("HiUNDAY", "JETTA", "branco");
        carros[3] = new Carro("ferrari", "ferrari", "amarelo");
        for(int i = 0; i < carros.Length; i++)
        {
            carros[i].info();
        }
    }
}   
