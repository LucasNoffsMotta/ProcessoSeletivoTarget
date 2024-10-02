// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;


double total = 0;
double percentual;

Dictionary<string, double> faturamentoPorEstado = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

Dictionary<string, double> percentualPorEstado = new Dictionary<string, double>();

foreach(double valor in faturamentoPorEstado.Values)
{
    total += valor;
}

foreach(var estado in faturamentoPorEstado)
{
    percentual = (estado.Value / total) * 100;
    percentualPorEstado[estado.Key] = percentual;
}


foreach (var estado in percentualPorEstado)
{
    Console.WriteLine($"Estado: {estado.Key}  /    Percentual: {estado.Value:F2}");
}


