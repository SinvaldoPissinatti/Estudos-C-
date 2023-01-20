using System;

class Aula15 {
    static void Main(){
        int tempo = 0;
        char escolha = ' ';

        Console.WriteLine("Belo Horizonte/MG à Vitória/ES");
        Console.WriteLine("Escolha o transporte: [a] Avião | [c] Carro | [o] Ônibus");
        escolha = char.Parse(Console.ReadLine());

        switch(escolha){
            case 'a':
                tempo = 50;
                Console.WriteLine("Você vai ir de Avião!!!!! | chegada em: {0} minutos", tempo);
                break;
            case 'c':
                tempo = 260;
                Console.WriteLine("Você vai ir de Carro!!!!! | chegada em: {0} minutos", tempo);
                break;
            case 'o':
                tempo = 300;
                Console.WriteLine("Você vai ir de Ônibus!!!! | chegada em: {0} minutos", tempo);
                break;
            default:
                tempo = -1;
                break;
        }

        if(tempo < 0){
            Console.WriteLine("Transporte não escolhido");
        }
    }
}