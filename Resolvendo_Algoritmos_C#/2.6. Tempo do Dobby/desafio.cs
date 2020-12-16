using System;

class Desafio {
    static void Main() {
    int n = int.Parse(Console.ReadLine());
    string[] texto = Console.ReadLine().Split(" ");
    int x = int.Parse(texto[0]), y = int.Parse(texto[1]);

    int soma = x + y;
    if (soma > n){
      Console.Write("Deixa para amanha!");
    }else{
      Console.Write("Farei hoje!");
    }
  }
}