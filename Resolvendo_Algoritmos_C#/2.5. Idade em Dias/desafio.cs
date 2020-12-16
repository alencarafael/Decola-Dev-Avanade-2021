using System;

class Desafio {
 static void Main() {
    var idadeEmDias = int.Parse(Console.ReadLine());
    var anos = (idadeEmDias / 365); 
    var meses = (idadeEmDias%365) / 30; 
    var dias =  (idadeEmDias%365)%30; 

    Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");
  }
}
