
/*Faça um algoritmo para ler um número e verificar se ele é par ou ímpar.*/


/// <summary>
/// Variável responsavel por receber a entrada do numero
/// </summary>
int numero;


//Entrada de Dados
Console.Write("Digite Um Numero: ");
numero = int.Parse(Console.ReadLine());


//Processamento de Dados
if (numero % 2 == 0)
{
    Console.WriteLine("O numero é Par");
}
else
{
    Console.WriteLine("O numero é impar");
}