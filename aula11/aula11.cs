using System;

class Aula11{

    enum DiasSemanas{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};

    static void Main(){
        //DiasSemanas ds = DiasSemanas.Domingo;

        DiasSemanas ds = (DiasSemanas)5;

        Console.WriteLine(ds);
    }
}