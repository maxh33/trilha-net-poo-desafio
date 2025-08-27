# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

---

# Solução do Desafio

## 📝 Descrição do Projeto

A solução implementa os conceitos de Programação Orientada a Objetos para criar um sistema simples de celulares.

*   **Classe Abstrata `Smartphone`**: Define a estrutura base para um celular, com propriedades como `Numero`, `Modelo`, `IMEI`, `Memoria` e métodos comuns como `Ligar` e `ReceberLigacao`. O método `InstalarAplicativo` é declarado como `abstract`, forçando as classes filhas a implementá-lo.
*   **Classes `Nokia` e `Iphone`**: Herdam de `Smartphone` e fornecem implementações específicas para o método `InstalarAplicativo`, demonstrando polimorfismo.
*   **`Program.cs`**: Contém o código para testar as classes `Nokia` e `Iphone`, criando instâncias e chamando seus métodos.

## ✨ Funcionalidades Implementadas

*   **Abstração:** A classe `Smartphone` abstrai as características e comportamentos comuns a todos os celulares.
*   **Herança:** As classes `Nokia` e `Iphone` herdam da classe `Smartphone`.
*   **Polimorfismo:** O método `InstalarAplicativo` é sobrescrito nas classes filhas para fornecer uma implementação específica para cada marca.
*   **Encapsulamento:** As propriedades da classe `Smartphone` (Numero, Modelo, IMEI, Memoria) encapsulam o estado do objeto.

## 🛠️ Tecnologias Utilizadas

*   [.NET 8](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0)
*   [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)

## 🚀 Como Executar

1.  **Clone o repositório:**
    ```bash
    git clone https://github.com/digitalinnovationone/trilha-net-poo-desafio.git
    ```
2.  **Navegue até o diretório do projeto:**
    ```bash
    cd trilha-net-poo-desafio
    ```
3.  **Execute o projeto:**
    ```bash
    dotnet run
    ```
