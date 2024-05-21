//1. Crie um programa que leia dois números inteiros do usuário e exiba a
//soma, subtração, multiplicação e divisão desses números.

using System;

class Calculator 
{
    static void Main()
    {
        Console.WriteLine("\n ------Calculadora------");
        Console.WriteLine("Insira o 1° numero: ");
        int num1 = Convert.ToUInt16(Console.ReadLine());
        Console.WriteLine("Insira o 2° numero: ");
        int num2 = Convert.ToUInt16(Console.ReadLine());

        Console.WriteLine($"\nA soma de {num1} e {num2} é: " + (num1 + num2));
        Console.WriteLine($"\nA subtração de {num1} e {num2} é: " + (num1 - num2));
        Console.WriteLine($"\nA multiplicação de {num1} e {num2} é: " + (num1 * num2));
        Console.WriteLine($"\nA divisão de {num1} e {num2} é: " + (num1 / num2));
    }
}