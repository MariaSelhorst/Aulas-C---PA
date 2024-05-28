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
        Console.WriteLine("Cliente adicionado com sucesso!");
    }
    public void ListarClientes()
    {
        Console.WriteLine("\nLista de Clientes:");
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
            Console.WriteLine("\nCliente não encontrado.\n");
            Console.ResetColor();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        CadastroCliente cadastro = new CadastroCliente();


        cadastro.AdicionarCliente(new Cliente("João", "joao@email.com", "123456789"));
        cadastro.AdicionarCliente(new Cliente("Maria", "maria@email.com", "987654321"));

        cadastro.ListarClientes();

        cadastro.BuscarClientePorNome("João");
        cadastro.BuscarClientePorNome("Pedro");
    }
}

