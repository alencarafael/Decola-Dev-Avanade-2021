using System;

class Desafio {
 static void Main() {
    var t = int.Parse(Console.ReadLine());
    var h = (t / 3600); 
    var m = (t%3600) / 60; 
    var s =  (t%3600) % 60;

    Console.WriteLine($"{h}:{m}:{s}");
  }
}