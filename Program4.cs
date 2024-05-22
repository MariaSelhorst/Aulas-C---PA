//1. Crie um programa que leia a idade de uma pessoa e verifique se ela
//pode votar (idade &gt;= 16) e se é maior de idade (idade &gt;= 18).

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite sua idade: ");
        int idade = Convert.ToInt16(Console.ReadLine());
        if(idade >= 16 && idade >= 18){
            Console.WriteLine("Pode votar!");
        }
        else{
            Console.WriteLine("Não pode votar!");
        }
    }
}
