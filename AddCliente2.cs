using System;
using System.Collections.Generic;
using System.Linq;

public class Cliente
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }

    public Cliente(string nome, string email, string telefone)
    {
        Nome = nome;
        Email = email;
        Telefone = telefone;
    }
}

public class CadastroCliente
{
    private List<Cliente> clientes;

    public CadastroCliente()
    {
        clientes = new List<Cliente>();
    }

    public void AdicionarCliente(Cliente cliente)
    {
        clientes.Add(cliente);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Cliente adicionado com sucesso!");
        Console.ResetColor();
    }

    public void ExcluirCliente(string nome)
    {
        var clienteParaExcluir = clientes.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        if (clienteParaExcluir != null)
        {
            clientes.Remove(clienteParaExcluir);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cliente excluído com sucesso!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cliente não encontrado para excluir.");
            Console.ResetColor();
        }
    }

    public void ListarClientes()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nLista de Clientes:");
        Console.ResetColor();
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"\nNome: {cliente.Nome} \nEmail: {cliente.Email} \nTelefone: {cliente.Telefone}");
        }
    }

    public void BuscarClientePorNome(string nome)
    {
        var clienteEncontrado = clientes.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        if (clienteEncontrado != null)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nCliente encontrado: \nNome: {clienteEncontrado.Nome} \nEmail: {clienteEncontrado.Email} \nTelefone: {clienteEncontrado.Telefone}");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nCliente não encontrado.");
            Console.ResetColor();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        CadastroCliente cadastro = new CadastroCliente();
        string opcao;

        do
        {
            Console.WriteLine("\n----------Menu----------");
            Console.WriteLine("1 - Adicionar Cliente");
            Console.WriteLine("2 - Excluir Cliente");
            Console.WriteLine("3 - Listar Clientes");
            Console.WriteLine("4 - Buscar Cliente");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("------------------------");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Telefone: ");
                    string telefone = Console.ReadLine();
                    if (telefone.All(char.IsDigit))
                    {
                        cadastro.AdicionarCliente(new Cliente(nome, email, telefone));
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Telefone inválido. Digite apenas números.");
                        Console.ResetColor();
                    }
                    break;
                case "2":
                    Console.Write("Nome do Cliente a ser excluído: ");
                    string nomeExcluir = Console.ReadLine();
                    cadastro.ExcluirCliente(nomeExcluir);
                    break;
                case "3":
                    cadastro.ListarClientes();
                    break;
                case "4":
                    Console.Write("Nome do Cliente a ser buscado: ");
                    string nomeBuscar = Console.ReadLine();
                    cadastro.BuscarClientePorNome(nomeBuscar);
                    break;
                case "5":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Saindo...");
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida. Escolha uma opção válida.");
                    Console.ResetColor();
                    break;
            }
        } while (opcao != "5");
    }
}
