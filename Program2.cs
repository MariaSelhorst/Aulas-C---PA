//1. Crie um programa que leia dois números inteiros e verifique se o
//primeiro número é maior que o segundo.

using System;

class Calculator 
{
    static void Main()
    {
        Console.WriteLine("\n---Verifica se o primeiro número é maior ---");
        Console.WriteLine("\nDigite o primeiro número: ");
        int num1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("\nDigite o segundo número: ");
        int num2 = Convert.ToInt16(Console.ReadLine());

        if (num1 == num2){
            Console.WriteLine("\nPossui valores iguais. \n");
        }
        else if(num1 > num2) {
            Console.WriteLine("\n" + num1 +  " é maior que " + num2 + ".");     
        }
        else {
            Console.WriteLine("\n" + num1 +  " é menor que " + num2 + ".");
        }
    }
}