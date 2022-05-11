// Created by: Ava Venturino
// Created on: April 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {

        int number;
        var sum = 0;

        Console.Write("Input a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        for (var counter = 1; counter <= number; counter++)
            sum += counter;

        Console.WriteLine("The answer is: " + sum);
    }
}