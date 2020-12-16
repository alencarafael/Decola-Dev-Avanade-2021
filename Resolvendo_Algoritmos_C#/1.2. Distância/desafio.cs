using System;

class Desafio {
    static void Main() {
        int quilometros = Int32.Parse(Console.ReadLine());
        int velocidadeRelativa = 30;
        float min = ( (float)quilometros / (float)velocidadeRelativa) * 60;
        Console.WriteLine(Math.Round(min, 1) + " minutos");
    }
}