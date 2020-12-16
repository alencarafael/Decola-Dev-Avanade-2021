# Introdução a Programação C#

### **1** **/** **1** **-** **Dividindo X por Y**

##### Desafio

Você terá o desafio de escrever um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo. Caso não for possível mostre a mensagem “divisao impossivel” para os valores em questão.

##### Entrada

A entrada contém um número inteiro **N**. Este **N** será a quantidade de pares de valores inteiros (X e Y) que serão lidos em seguida.

##### Saída

Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, ou “divisao impossivel” caso não seja possível efetuar o cálculo.

------

### 1/2 - Distância

##### Desafio

Duas motos (X e Y) partem em uma mesma direção. A moto X sai com velocidade constante de 60 Km/h e a moto Y sai com velocidade constante de 90 Km/h.

Em uma hora (60 minutos) a moto Y consegue se distanciar 30 quilômetros da moto X, ou seja, consegue se afastar um quilômetro a cada 2 minutos.

O seu desafio é ler a distância (em Km) e calcular quanto tempo leva (em minutos) para a moto Y tomar essa distância da outra moto.

##### Entrada

O arquivo de entrada contém um número inteiro **K** que representa a quantidade de quilômetro que que a moto Y deve estar da moto X.

##### Saída

Imprima o tempo necessário para a moto Y ficar com a quantidade **K** de quilômetro da moto X, seguido da mensagem " minutos".

------

### 1/3 - Quanta Mandioca?

##### Desafio

Os meses de Junho e Julho são tradicionalmente conhecidos por todo Brasil por suas festas típicas, e para o grupo de amigos da Marlene não é diferente, toda segunda quinzena do mês de Julho ela e seus amigos se reunem para tradicional mandiocada! Na festiva sempre se reúnem na casa da Marlene, o Chico, o Beto, o Bernardo, a Marina e a Iara. E como não poderia ser diferente o prato principal dessa reunião é a mandioca. Cada um deles come de uma a dez porções de mandioca e eles sempre avisam a Marlene com antecedência a respeito de quantas porções irão comer nesse dia. O tamanho da porção de cada um é diferente, mas sempre são os mesmos. As porções são as seguintes (em gramas):

- O Chico come 300
- O Bento come 1500
- O Bernardo come 600
- A Marina 1000
- A Iara come 150

Marlene por sua vez sempre come 225 gramas de mandioca. Cansada de todo ano ter que calcular quanta mandioca preparar ela te desafiou para escrever um programa que informe quanta mandioca deve ser preparada em gramas.

##### Entrada

A entrada consiste de 5 inteiros cada um representando as porções que os convidados de dona Chica vão consumir. O primeiro inteiro representa as porções do Chico, o segundo do Bento, o terceiro do Bernardo, o quarto da Marina e o quinto a da Iara.

##### Saída

A saída consiste de um único inteiro que representa quanta mandioca Marlene deve preparar em gramas.

------

### 2/1 - Hora da corrida

##### Desafio

Augusto adora se exercitar, por isso levanta todos os dias 6h da manhã, em qualquer tempo ou estação do ano. Ele corre em volta de uma lagoa. Ao longo da pista de corrida existem **N** placas igualmente espaçadas. Augusto conta o número de placas pelas quais ele já passou e verifica se ele já correu pelo menos 10%, 20%, 90% do percurso.

Vamos ajudar o Augusto, calculando para ele o número de placas que ele precisa contar para ter completado pelo menos 10%, 20%, 90% da corrida, de acordo com o número de voltas que ele quer correr e o número total de placas ao longo da pista.

Se Augusto quiser dar 3 voltas e o número de placas for 17, para garantir ter corrido pelo menos 30% do percurso, ele precisa contar 16 placas. Para garantir pelo menos 60%, ele precisa contar 31 placas.

##### Entrada

A entrada consiste de uma única linha que contém dois inteiros, **A** e **N** (1 ≤ **A**;**N** ≤ 104), onde **A** é o número pretendido de voltas e **N** é o número de placas na pista.

##### Saída

Seu programa deve produzir uma única linha com nove inteiros representando os números de placas que devem ser contadas para garantir o cumprimento, respectivamente, de 10%, 20% e 90% da meta.

------

### 2/2 - Cardápio Aéreo

##### Desafio

Durante um longo voo é comum que as companhias aéreas ofereçam alguma refeição aos seus passageiros, e é comum as aeromoças conduzirem carrinhos contendo tais refeições pelos corredores do avião. Sentado numa fileira, você avista o carrinho chegando até você, a qual em um piscar de olhos você é questionado imediatamente: “Pizza, salada, ou massa?”.

Mesmo tendo noção das opção, você tem apenas alguns segundos para selecionar, mas sua relutância imediata vem da dúvida de como pode ser a aparência de sua escolha, pois seu vizinho ainda não abriu o embrulho…

Então a aeromoça decidiu mudar o procedimento. Primeiro ela vai perguntar a todos os passageiros o que eles querem, e com base nisso vai checar se o estoque pode satisfazer todo mundo. Obviamente, ela quer automatizar esse processo e você se prontificou a ajudar.

Então assim, por exemplo, considere que o número de refeições de pizza, salada e massa disponíveis são respectivamente (80, 20, 40), enquanto o número de passageiros que escolheu pizza, salada e massa seja respectivamente (45, 23, 48). Neste caso, onze pessoas seguramente ficaram sem suas respectivas escolhas de refeição, já que três passageiros que queriam salada e oito que gostariam de massa não poderão ser atendidos.

Dada a quantidade de refeições disponíveis para cada escolha e o número de refeições pedidas para cada escolha, você poderia ajudar a aeromoça a determinar quantos passageiros certamente não poderão ser atendidos?

##### Entrada

A primeira linha contem três inteiros **Ca**, **Ba** e **Pa** (0 ≤ **Ca**, **Ba**, **Pa** ≤ 100), representando respectivamente o número de refeições disponiveis de pizza, salada e massa. A segunda linha contem três inteiros **Cr**, **Br** e **Pr** (0 ≤ **Cr**, **Br**, **Pr** ≤ 100), indicando respectivamente o número de refeições requisitadas de pizza, salada e massa respectivamente.

##### Saída

Imprima uma única linha com um inteiro representando o número total de passageiros que seguramente não receberão sua escolha de refeição.

------

### **2/3 - **Pizza Antes do Final do Ano

##### Desafio

Está chegando o final de ano e as tradicionais celebrações de amigo secreto, você e seus **N**-1 amigos decidiram combinar algum dia para ir a uma pizzaria.

Neste momento está sendo escolhida a data do evento. Para que todas as pessoas possam participar, foi decidido que o encontro na pizzaria ocorrerá em um data tal que todas as **N** pessoas podem comparecer à pizzaria nesta data. Portanto, nem toda data pode ser escolhida, pois algumas pessoas podem ter outros compromissos já marcados em alguns dias.

Dada a lista de datas consideradas para o evento e a informações de quais pessoas podem comparecer em quais datas, determine se o evento poderá ocorrer e, em caso positivo, sua data. Caso mais de uma data seja possível, o evento deve ocorrer o mais cedo possível.

##### Entrada

A entrada contém vários casos de teste. A primeira linha de cada caso contém os inteiros **N** e **D** (1 ≤ **N**, **D** ≤ 50), o número de pessoas e o número de datas consideradas, respectivamente. As pessoas são numeradas de 1 a **N**. As próximas **D** linhas descrevem uma data considerada. Cada linha começa com a data na forma *dia∕mes∕ano*. A linha é seguida de **N** inteiros **p1**,**p2**,...,**pN**. O inteiro **pi** é 1 se a pessoa *i* pode comparecer na data considerada, ou 0 caso contrário. É garantido que as datas são sempre válidas, e não há zeros à esquerda. Além disso, as datas são dadas em ordem, do dia mais cedo para o dia mais tarde.

##### Saída

Para cada caso de teste, imprima uma linha contendo a data que o evento deve ocorrer, na forma *dia∕mes∕ano*, de maneira *idêntica* à da entrada. Caso não seja possível realizar o evento, imprima “*Pizza antes de FdA*” (sem aspas).

------

### **2/4 - Conversão de Tempo**

#### Desafio

Você terá o desafio de ler um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma loja, e informe-o expresso no formato horas:minutos:segundos.

#### Entrada

O arquivo de entrada contém um valor inteiro **N**.

#### Saída

Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.

------

### **2/5 - Idade em Dias**

##### Desafio

Você terá o desafio de ler um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. 

##### Entrada

O arquivo de entrada contém um valor inteiro.

##### Saída

Imprima a saída conforme exemplo fornecido.

------

### **2/6 - Tempo do Dobby**

##### Desafio

Para dar conta de toda a fabricação dos presentes de Natal, por várias vezes os elfos precisam ficar até tarde trabalhando para que tudo possa ser terminado a tempo.

Para melhor gerenciar seus cronogramas, os elfos estipularam quantos minutos são necessários para fabricar cada presente.

Já está quase no final do expediente, e um dos elfos pediu sua ajuda.

Faltam **N** minutos para a hora de ir embora, e restam dois presentes para o elfo Dobby fabricar. Ajude-o a descobrir se ele conseguirá fabricar os dois ainda hoje, ou se deve deixar o trabalho para amanhã.

##### Entrada

Cada caso de teste inicia com um inteiro **N**, indicando quantos minutos faltam para o final do expediente (2 <= **N** <= 100).

Em seguida haverá dois inteiros **A** e **B**, indicando quantos minutos são necessários para fabricar os dois presentes que Dobby precisa fabricar (1 <= **A**, **B** <= 100).

##### Saída

Imprima uma linha, contendo a frase "Farei hoje!" caso seja possível fabricar os dois presentes antes do final do expediente, ou "Deixa para amanha!" caso contrário.

------

###  **2/7 - Rodízio de cavalos e carruagens**

##### Desafio

O rodízio de veículos de Bravoos é uma restrição à circulação de veículos na cidade. Com o propósito de melhorar as condições ambientais reduzindo a carga de poluentes na atmosfera,incluindo na região de Westeros, se consolidou como um instrumento para reduzir congestionamentos nas principais vias da cidade, nos horários de maior movimento. Nas ruas delimitadoras não é permitido o tráfego de cavalos e carruagens que estejam dentro da restrição. Há uma escala que determina em quais dias da semana quais veículos não podem circular. Essa escala é regida pelo último dígito da placa do animal, sendo:

- Segunda-feira, digito final da placa 1 e 2
- Terça-feira, digito final da placa 3 e 4
- Quarta-feira, digito final da placa 5 e 6
- Quinta-feira, digito final da placa 7 e 8
- Sexta-feira, digito final da placa 9 e 0

Os motoristas que são flagrados violando a restrição de circulação são autuados com multa de 4 galinhas e condenados a passar 1 semana na Muralha.

##### Entrada

A primeira linha de entrada representa a quantidade de testes **N** (0 <= **N** < 1000) que deverão ser considerados. As demais entradas são cadeia de caracteres com tamanho máximo **S** (1 <= **S** <= 100) que representam cada placa que deverá ser analisada, de tal forma que, cada placa fique em uma única linha de entrada. O formato esperado para uma placa veicular válida em Bravoos é "**AAA-9999**", tal que A é um caracter válido em [A-Z], e 9 um dígito numérico válido em [0-9].

##### Saída

O conjunto de valores válidos como saída são: SEGUNDA, TERCA, QUARTA, QUINTA e SEXTA, de acordo com a tabela de restrições predefinida, e FALHA caso a placa não apresente o padrão definido.