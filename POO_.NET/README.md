## Orientação a objetos em .NET

- Um curso voltado para iniciantes em C# e .NET que foca no aprendizado teórico dos principais conceitos em orientação a objetos, como métodos, classes e propriedades.

#### Introdução

- Paradigmas de programação são modos diferentes de montar a estrutura e execução de um código. Um paradigma de programação fornece e determina a visão que o programa possui sobre a estruturação e execução do programa.
- Um paradigma pode oferecer técnicas apropriadas para uma aplicação específica. Entre eles, estão a programação orientada a objetos (POO) e a programação estruturada (PE).
- A programação estruturada (PE) tem com principal característica sua interpretação linha por linha, em pequenos trechos de código, podendo eles não estar em uma ordem específica. Há três tipos de estruturas básicas para navegar pelo código: "sequência, seleção, repetição".
- A programação orientada a objetos (POO) podem conter dados na forma de campos (atributos) e códigos, na forma de procedimentos (métodos). Uma característica é que um procedimento de objeto pode acessa, e geralmente modificar, os campos de dados do objeto com o qual eles estão associados e cada um é campo de receber processar e enviar dados, podendo ser visto como uma "máquina independente". 
- Para uma linguagem ser considerada OO é preciso atender 4 pilares da POO - **"Abstração", "Encapsulamento", "Herança", "Polimorfismo"**.

#### POO

**Classes** - pode ser considerado como se fosse um molde para o objeto, contendo dentro de si as principais informações para sua criação. Define os atributos e métodos comuns que serão compartilhados por um objeto.

1. Objetos similares participam de uma mesma classe.

**Objetos** - tudo aquilo que em geral possui atributos, comportamentos e um estado. A classe em si é um conceito abstrato, como um molde, que se torna concreto  e palpável através da criação de  um objeto. Na programação o objeto é uma instancia de uma classe. Para criar ou **"instanciar"** objetos de uma determinada classe, utiliza-se o operador **new**.

1. Para cada objeto instanciado pode-se modificar os métodos e atributos herdados.

**Métodos** -  determinam o comportamento dos objetos de uma classe e são capazes de controlar o estado da instância. São funções que realizam tarefas. Eles podem ou não retornar valores, e podem ou não receber parâmetros.

1. Chamada de métodos - pode alterar o estado de um objeto. Esses métodos temos como difundidos os Getters, Setters, Construct.
2. Getters - solicita o acesso a informações de um determinando produto sem dar acesso diretamente a ele, colocando ali uma barreira de proteção de dados.
3. Setters - enviam o pedido de alteração de uma determinanda informação de um objeto sem que se altere diretamente o mesmo. (modificador)
4. Construct -  é o método construtos que da forma forma à classe. É nele que indicamos os valores dos campos de uma classe. Esses valores podem ser internos ou externos.
   - o construtor deve ter o mesmo nome da classe;
   - não tem tipo de retorno;
   - apenas um é executado, apenas uma vez, no momento da criação do objeto;
   - não pode ser chamado diretamente;
   - deve ser public;

**Visibilidade** - é importante para a proteção do código e suas funcionalidades, define quem pode alterar cada dado dos trechos de códigos em três principais níveis:

1. public ( + ) - pode ser acessada em qualquer parte do programa ou do projeto do programa.
2. private ( - ) - impede que qualquer código externo à própria classe Corpo tenha acesso aos campos, evitando que alterações indevidas gerem inconsistência.
3. protected ( # ) - acesso limitado à própria classe, às classes derivadas. **internal**: acesso limitado à própria classe, às classes derivadas e ao própria assembly. 

Encapsulamento de atributos e métodos impede o chamado vazamento de escopo, onde um atributo ou método é visível por alguém que não deveria vê-lo, como outro objeto ou classe. Isso evita a confusão do uso de variáveis globais no programa, deixando mais fácil de identificar em qual estado cada variável vai estar a cada momento do programa, já que a restrição de acesso nos permite identificar quem consegue modificá-la.

**Tipos por valor C# :**

1. Todos os tipos de dados numéricos não precisam ser inicializados com o operador **new**.
2. A variável armazena valor diretamente.
3. A atribuição de uma variável a outra copia o conteúdo, criando efetivamente outra cópia da variável.
4. Não podem conter valor null.
5. Int, float, char, dooble, ...

**Tipos por referência C# :**

1. Armazena um referência a seus dados.
2. Duas variáveis podem conter a referência a um mesmo objeto. Operações em uma afetam a outra.
3. Strings, classes, arrays.

**Tipo ponteiro C# :** 

Tipo de dado, cujo o valor se refere diretamente a um outro valor alocado em outra área da memória, através de seu endereço.

**Propriedades** - consistem em um par de métodos "gets" e "sets" que respectivamente servem para recuperar e atribuir o valor a um campo.

Geralmente, para cada método existe uma variável dentro da classe que armazena o valor da propriedade.

**Eventos** - são mensagens que a classe dispara em determinada situação. Para que o evento funcione, é necessário que um método seja escrito para ser executado quando ocorrer o evento. A classe apenas fica sabendo que existe esse método em tempo de execução.

Para que o mecanismo dos eventos funcione, é necessário usar um tipo de estrutura **delegate**, uma variável que guarda o endereço de uma função. Assim, quando o evento é disparado, essa variável chama a função associada a ela.

