using System;

class Pessoa {
    // Propiedades
    public string Nome {get; set;}
    public int Idade {get; set;}
    public string Funcao {get; set;}

    //Constructor
    public pessoa(string nome, int idade, string funcao) {
        Nome = nome;
        Idade = idade;
        Funcao = funcao;
    }

    public void ExibirInformacoes() {
        Console.Writeline($"Nome: {Nome}");
        Console.Writeline($"Idade: {Idade}");
        Console.Writeline($"Função: {Funcao}");
    }
}

class Program {
    static void Main() {
        // Criando um objeto na classe pessoa
        Pessoa pessoa = new Pessoa("Maria", 30, "Engenharia");

        // Exibindo informações das pessoas
        pessoa.ExibirInformacoes();

        // Manter o console aberto

        Console.Writeline("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}