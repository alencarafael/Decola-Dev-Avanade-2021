using System;

class Desafio {
    static void Main() {
        string[] disponivel = Console.ReadLine().Split(' ');
        int Ca = int.Parse(disponivel[0]);
        int Ba = int.Parse(disponivel[1]);
        int Pa = int.Parse(disponivel[2]);
            
        string[] requisitada = Console.ReadLine().Split(' ');
        int Cr = int.Parse(requisitada[0]);
        int Br = int.Parse(requisitada[1]);
        int Pr = int.Parse(requisitada[2]);

        int total = 0;
        int CaCr = Ca - Cr;
        int BaBr = Ba - Br;
        int PaPr = Pa - Pr;


        if(CaCr < 0)
        total = total + (CaCr * -1);

        if(BaBr < 0)
        total = total + (BaBr * -1);

        if(PaPr < 0)
        total = total + (PaPr * -1);

        Console.Write(total);
    }
}