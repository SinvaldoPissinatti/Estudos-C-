using System;

class Aula13{
    static void Main(){
        int nota;
        
        Console.Write("Digite a nota: ");
        nota = int.Parse(Console.ReadLine());

        if(nota >= 60){
            Console.WriteLine("Aprovado!");
        }else{
            Console.WriteLine("Reprovado!");
        }
    }
}