using System;

class Desafio {
 static void Main() {
        string[] line = Console.ReadLine().Split(" ");
        int N = int.Parse(line[0]);
        int D = int.Parse(line[1]);
        string data = "";
        int quantidade = 0;
        bool x = false;

        for (int dt=0; dt<D; dt++){
          quantidade = 0;
          string[] dados = Console.ReadLine().Split(" ");
          data =  dados[0];
          for (int p=1; p<N+1; p++){
            quantidade += int.Parse( dados[p] );
          } //for  p
          x = ( quantidade == N);
          if (x) { break; }
        } //for dt

        if (x) { Console.Write(data); }
        else { Console.Write("Pizza antes de FdA"); }
    }
}
