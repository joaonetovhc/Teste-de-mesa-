using System;
class Desafio02{

    static void Main(){

        int a = 10;
        int b = 20;
        int c = (a + b)/2;
        int [] V = new int [6];

        c = c - 40;
        V[3] = a+b+c;
        Console.Write(V[3]);
        
    }

}