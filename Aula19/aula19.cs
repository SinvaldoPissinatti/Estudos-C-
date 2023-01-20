using System;

class Aula19 {
    static void Main(){
        int[] n = new int[5];

        for(int contador = 0; contador < n.Length; contador++){
            Console.Write("Digite o valor para o indice {0}: ", contador);
            n[contador] = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor do indice {0} é {1}", contador, n[contador]);
        }

        for(int i = 0; i < n.Length; i++){
            Console.WriteLine("Valor do vetor de indice {0} é {1}", i, n[i]);
        }

    }
}