using System;

class Aula20{
    static void Main(){

        string [] nome = new string[10];
        int i = 0;

        while(i < 10){
            Console.WriteLine("Caso não queira mais colocar nomes, digite [1]");
            Console.Write("Digite um nome {0}: ", i);
            nome[i] = Console.ReadLine();
            i++;
        }


    }
}