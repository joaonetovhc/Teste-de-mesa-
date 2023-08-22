using System;
class TesteMesa{

    static void Main(){

        int a = 2;
        int [] V = new int [6];

        while(a < 6){
            V[a] = 10 * a;
            Console.Write($"V[a] = {V[a]}");
            a++;

            Console.WriteLine($"  Contador: {a}");
        }
           
    }

}