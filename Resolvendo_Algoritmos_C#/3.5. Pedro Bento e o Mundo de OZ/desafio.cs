using System;
using System.Collections.Generic;
using System.Linq;

class desafio {

  static void Main(string[] args) {
    string input = Console.ReadLine();
        var list = new List<string>();
        do
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                list.Add(input);
            }
            input = Console.ReadLine();
        } while (!string.IsNullOrWhiteSpace(input));

        var listSemDuplicidade = list.Distinct().ToArray();

        Console.WriteLine(listSemDuplicidade.Length);
  }

}