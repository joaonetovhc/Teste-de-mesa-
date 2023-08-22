using System;
class Desafio03{

    static void Main(){

        int a = 7;
        int b = a - 6;
        int [] V = new int [14];

        while (b < a){ 

            V[b] = b + a;
            Console.WriteLine($"V[{b}] = {V[b]}");
            b+=2;
        }
    }

}