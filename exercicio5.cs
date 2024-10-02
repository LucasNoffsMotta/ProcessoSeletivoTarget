// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;


Console.WriteLine("Digite uma palavra para ser invertida: ");
string userInput = Console.ReadLine().ToLower();
char[] letras = new char[userInput.Length];

for (int i = 0; i < letras.Length; i++)
{
    letras[i] = userInput[userInput.Length - 1 - i];
}


string palavraInvertida = new string(letras);

Console.WriteLine($"A palavra {userInput} invertida: {palavraInvertida}");
