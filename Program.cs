// See https://aka.ms/new-console-template for more information

Console.WriteLine("\tPrograma para hallar la sumatoria de una secuencia");
Console.WriteLine("\t**************************************************\n");
Console.Write("Ingrese el valor de n: ");
int n = int.Parse(Console.ReadLine()!);
float sumatoria, resultado;
sumatoria = 0;

for (float i = 1; i <= n; i++)
{
    resultado = (16-i)/(3*i);
    Console.WriteLine($"Resultado {i}: {resultado}");
    sumatoria += resultado;
}

Console.WriteLine("Sumatoria: " + sumatoria);

