using System;

class Aula09{
    static void Main(){
        int v1, v2, soma;
        string nome;
        
        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Nome: {0}", nome);

        Console.Write("Digite o valor1: ");
        v1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor2: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        
        soma = v1 + v2;
        Console.WriteLine("A soma de {0} mais {1}, é igual à: {2}", v1, v2, soma);
    }
}