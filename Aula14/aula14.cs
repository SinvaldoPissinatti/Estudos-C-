using System;

class Aula14{
    static void Main(){
        int nota;
        
        Console.Write("Digite a nota: ");
        nota = int.Parse(Console.ReadLine());

        if(nota >= 60){
            Console.WriteLine("Aprovado!");
        }else if(nota < 60 & nota >= 50){
            Console.WriteLine("Recuperação!");
        }else{
            Console.WriteLine("Reprovado!");
        }
    }
}