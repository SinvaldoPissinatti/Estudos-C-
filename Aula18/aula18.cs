using System;

class Aula18 {
    static void Main(){
        int i, cont;
        i = 0;
        cont = 0;
        int[,] n = new int[3,2];
        int[,] num = new int[2,2]{{10, 20},{30, 40}};

        n[0, 0] = 11;
        n[0, 1] = 22;
        n[1, 0] = 33;
        n[1, 1] = 44;
        n[2, 0] = 55;
        n[2, 1] = 66;

        
        for(cont = 0; cont < 3; cont++){
            for(i = 0; i < 2; i++){
                Console.WriteLine(n[cont, i]);
            }
        };

    }
}