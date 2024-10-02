// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Runtime.InteropServices;

int num1 = 0;
int num2 = 1;
int nextNum;
List<int> fibonacciList = new List<int>();
bool numInFibonacci = false;

Console.Write("Digite um numero: ");
int userNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\n Sequencia Fibonaccin ate o numero {userNum}: ");

while (num1 <= userNum)
{
    fibonacciList.Add(num1);
    Console.WriteLine(num1);
    
    nextNum = num1 + num2;
    num1 = num2;
    num2 = nextNum;
}

foreach (int num in fibonacciList)
{
    if (userNum == num)
    {
        numInFibonacci = true;
        break;
    }

    else
    {
        numInFibonacci = false;
    }
}


if (numInFibonacci)
{
    Console.WriteLine("\nO valor informado pertence a sequencia Fibonacci");
}

else
{
    Console.WriteLine("\nO valor informado nao pertence a sequencia Fibonacci");
}
