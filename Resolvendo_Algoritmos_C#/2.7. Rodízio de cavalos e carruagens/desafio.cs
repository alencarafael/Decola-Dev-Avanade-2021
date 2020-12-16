using System;
using System.Linq;
class Desafio {
    static void Main (){
        int quant = int.Parse(Console.ReadLine());
        string[] placa = new string[quant];
        for (int i = 0; i < quant; i++) {
            placa[i] = Console.ReadLine();
        }

        for (int i = 0; i < quant; i++) {
            if (validaPlaca(placa[i]) == true) {
                int dig = numFinal(placa[i]);
                string rod = calcRodovia(dig);
                Console.WriteLine(rod);
        } else {
            Console.WriteLine("FALHA");
        }
        }
    }

    static bool validaPlaca(string placa) {
        string[] campos = placa.Split("-");
            if (campos.Length == 2) {
                string letra = campos[0];
                string nums = campos[1];
                    if (letra.Length == 3 && nums.Length == 4) {
                        if (letra.All(char.IsLetter) && letra.All(char.IsUpper) && nums.All(char.IsDigit)) {
                        return true;
                } else {
                    return false;
                }
                } else {
                    return false;
                }
                } else {
                    return false;
                }
    }

    static int numFinal(string placa) {
        return int.Parse(placa.Substring(placa.Length -1));
    }

    static string calcRodovia(int num) {
        if (num == 1 || num == 2) {
            return "SEGUNDA";
        } else if (num == 3 || num == 4) {
            return "TERCA";
        } else if (num == 5 || num == 6) {
            return "QUARTA";
        } else if (num == 7 || num == 8) {
            return "QUINTA";
        } else if (num == 9 || num == 0) {
            return "SEXTA";
        } else {
            return "FALHA";
        }
    }
}