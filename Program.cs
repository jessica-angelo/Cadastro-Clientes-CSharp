using System;
using System.Collections.Generic;

class Cliente
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
}

class Program
{
    static List<Cliente> clientes = new List<Cliente>();

    static void Main()
    {
        int opcao;
        do
        {
            Console.WriteLine("\n=== Sistema de Cadastro de Clientes ===");
            Console.WriteLine("1 - Adicionar Cliente");
            Console.WriteLine("2 - Listar Clientes");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: AdicionarCliente(); break;
                case 2: ListarClientes(); break;
                case 3: Console.WriteLine("Saindo..."); break;
                default: Console.WriteLine("Opção inválida!"); break;
            }
        } while (opcao != 3);
    }

    static void AdicionarCliente()
    {
        Cliente c = new Cliente();
        Console.Write("Nome: ");
        c.Nome = Console.ReadLine();
        Console.Write("Email: ");
        c.Email = Console.ReadLine();
        Console.Write("Telefone: ");
        c.Telefone = Console.ReadLine();
        clientes.Add(c);
        Console.WriteLine("Cliente adicionado com sucesso!");
    }

    static void ListarClientes()
    {
        Console.WriteLine("\nLista de Clientes:");
        foreach (var c in clientes)
        {
            Console.WriteLine($"Nome: {c.Nome}, Email: {c.Email}, Telefone: {c.Telefone}");
        }
    }
}