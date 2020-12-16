/* ********Aula 01*********
alert ("Introdução ao JS");
var nome = "Rafael Alencar";
var idade = 26;
var somaidade = (idade + 10);
var frase = "Japão é o melhor time do mundo!";
    // alert ("Bem vindo " + nome + " você tem: " + idade + " anos!");
    // alert ("A idade somada é: " + somaidade);

console.log(nome);
console.log(somaidade);
console.log(frase.replace("Japão", "Brasil"));
console.log(frase.toUpperCase("Japão", "Brasil"));
*/


        /* ********Aula 02*********
        var lista = ["Rafael", "Maria", "João"];
            console.log(lista);
            console.log(lista[1]);
            alert(lista[1]);
            lista.push("Alencar"); //inserir elemento dentro do array
            lista.pop(); //eliminar ultimo elemento dentro do array
            console.log(lista.length); //ver quantidade de elementos dentro do array
            console.log(lista.reverse) //imprimir elementos ao contrário
            console.log(lista.toString())
            console.log(lista.toString()[0])
            console.log(lista.join(" | "));

        var fruta = {nome:"Maçã", cor:"vermelho", formato:"redondo"};
            console.log(fruta);
            alert(fruta.cor);

        var listaFrutas = [ {nome:"Maçã", cor:"vermelho", formato:"redondo"},
                            {nome:"Uva", cor:"roxo", formato:"oval"}];
            console.log(listaFrutas);
        */


                    /* ********Aula 03*********
                    var idade = prompt("Informe sua idade");
                    if (idade >= 18){
                        alert("Maior de idade");
                        } else {
                            alert("Menor de idade");
                    };

                    var count = 0;
                    while (count <= 5){
                        console.log(count);
                        count++;
                    };

                    var i;
                    for(i=0; i <= 5; i++){
                        console.log(i);
                    };

                    var data = new Date();
                        console.log(data);
                        alert(data.getMinutes()); //month | date ...
                    */


                            /* ********Aula 04 *********
                            function soma(n1, n2){
                                return n1 + n2;
                            }

                            function setReplace(frase, nome, novo_nome){
                                return frase.replace(nome, novo_nome)
                            }

                            function validaIdade (idade){
                                var validar;
                                if(idade >= 18){
                                    validar = true
                                } else {
                                    validar = false
                                    }
                                    return validar;
                            }
                            // alert(soma(5,10));
                            // alert(setReplace("Vai Japão", "Japão", "Brasil"));
                            var idade = prompt("Informe idade?");
                            console.log(validaIdade(idade));
                            */

function clicou(){
    //alert("Você cliclou !!!");
    document.getElementById("agradecimento").innerHTML = "https://www.avanade.com/pt-br";
    // console.log(document.getElementById("agradecimento"));
}

function redirecionar(){
    window.open("https://www.avanade.com/pt-br");
    // window.location.href = "https://www.avanade.com/pt-br"; //mesma janela
}

function trocar(elemento){
    // document.getElementById("mouseMove").innerHTML = "Você passou o mouse";
    // alert("Você passou o mouse");
    elemento.innerHTML = "Você passou o mouse";
}

function voltar(elemento){
    // document.getElementById("mouseMove").innerHTML = "Você voltou";
    elemento.innerHTML = "Você voltou";
}

function load(){
    alert("Página carregada");
}

function funcao(elemento){
    console.log(elemento.value);
}

