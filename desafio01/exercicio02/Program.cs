using System;
class TesteMesa{

    static void Main(){

        int a = 2;
        int [] V = new int [6];

        while(a < 6){
            V[a] = 10 * a;
            a++;

          //  Console.WriteLine(V[a]);

        }

            for(int i = 0; i < V.Length; i++){
                Console.Write($"{V[i]},");
            }
    }

}