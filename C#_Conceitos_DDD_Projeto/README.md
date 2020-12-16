### Projeto REST API C# - Construindo um REST API com conceitos DDD em .NET CORE 3.1

Baseado no curso: https://www.youtube.com/watch?v=plS-rf2UIPI&t=3230s

*[https://localhost:44387/swagger/index.html]*(https://localhost:44387/swagger/index.html)

##### Objetivo:

- Criação projeto utilizando .NETCore
- Abordado uma modelagem utilizando DDD

##### Ferramentas:

- Microsoft Visual Studio Community 
- SQL Server Management Studio

*https://localhost:44387/swagger/index.html*

##### Linguagens:

- C#
- HTML

### DDD - Domain Driven Design ("Projeto Orientado a Domínio")

- ##### Introdução DDD

  - " É uma abordagem de design de software disciplinada que reúne um conjunto de conceitos, técnicas e princípios para construção de softwares baseados em um modelo de domínio."

  - "Domínio é todo e qualquer conhecimento utilizado em uma determinada área."

  - ###### A principal questão que o DDD trás é a utilização da abstração, como é que eu abstraio o mundo real para o mundo de um software.

- ##### Características DDD

  - **Alinhamento do código com o negócio:** o contato dos desenvolvedores com os especialistas do domínio é algo essencial quando se faz DDD (o pessoa de métodos ágeis já sabe disso faz tempo). Se faz necessário o uso de uma linguagem ubíqua para descrever o domínio e sua regras.
  - **Favorecer reutilização:** os blocos de construção, que veremos adiante, facilitam aproveitar um mesmo conceito de domínio ou um mesmo código em vários lugares .
  - **Mínimo de acoplamento:** com um modelo bem feito, organizado as várias partes de um sistema interagem sem que haja muita dependência entre módulos ou classes de objetos de conceitos distintos.
  - **Independência da Tecnologia:** DDD não foca em tecnologia, mas sim em entender as regras de negócio e como elas devem estar refletidas no código e no modelo de domínio. Não que a tecnologia não seja importante, mas essa não é uma preocupação de DDD

- ##### Modelo de domínio MDD

  - Deve ser uma representação perfeita do seu domínio. Tudo que existe no seu negócio deve pertencer no modelo. Só aparece no modelo aquilo que está no negócio.
  - O desenho do modelo é criado em conjunto entre especialistas de negócio e domínio, analistas, arquitetos e desenvolvedores, utilizando a linguagem ubíqua para que todos tenham o mesmo entendimento.
  - O processo de maturação de um sistema desenvolvido usando MDD deve ser continuo. O modelo servirá para a criação do código e , ao mesmo tempo, o código ajuda a aperfeiçoar o modelo.
  - Uma vez que decidimos criar um modelo usando MDD, precisamos, inicialmente, isolar o modelo de domínio das demais partes que compõem o sistema. Essa separação pode ser feita utilizando uma arquitetura em camadas, que dividirá a aplicação em 4 partes: 
    1. **interface de usuário:** parte responsável pela exibição de informações do sistema ao usuário e também por interpretar comandos.
    2. **Aplicação:** essa camada não possui regras de negócio. Ela é apenas uma camada fina, responsável por conectar a interface de usuário às camadas inferiores;
    3. **Domínio:** representa os conceitos, regras e lógicas de negócio. Todo o foco de DD está nessa camada.
    4. **Infra-estrutura:** fornece recursos técnicos que darão suporte às camadas superiores. são normalmente as partes de um sistema responsáveis por persistência de dados, conexões com bancos de dados, envio de mensagens por redes gravação e leitura de discos, etc.
  
- ##### Regras para modelagem do domínio

  - **Entidades**: classes de objetos que necessitam de uma identidade. Normalmente são elementos do domínio que possuem ciclo de vida dentro de nossa aplicação.
  - **Objetos de valores:** objetos que só carregam valores, mas que não possuem distinção de identidade. Bons exemplos de objetos de calores seriam: strings, números ou cores.
  - **Agregados:** compostos de entidades ou objetos que são encapsulados numa única classe. O agregado serve para manter a integridade do modelo. Elegemos uma classe para servir de raiz do agregado. Quando algum cliente quiser manipular dados de uma das classes que compõem o Agregado, essa manipulação só poderá ser feira através da raiz.
  - **Fábricas:** classes responsáveis pelo processo de criação dos Agregados ou dos Objetos de Valores. Algumas vezes, agregados são relativamente complexos e não queremos manter a lógica de criação desses Agregados na classes que o compõem. Extraímos então as regras de criação para uma classe externa: a fábrica.
  - **Serviços:** classes que contém lógica de negócio, mas não pertence a nenhuma entidade, ou seja, toda chamada a um mesmo serviço, dada uma mesma pré-condição, deve retornar sempre o mesmo resultado.
  - **Repositório:** classes responsáveis por administrar o ciclo dos outros objetos, normalmente Entidades, Objetos de Valor e Agregados. Os repositórios são classes que centralizam operações de criação, alteração e remoção de objetos.
  - **Módulos:** abstrações que têm por objetivos agrupar classes por um determinado conceito do domínio. A maioria das linguagens de programação oferecem suporte a módulos (pacotes em Java, namespaces em .NET ou módulos em Ruby).

















