Console.WriteLine("MÚLTIPLO\n");

Console.Write("Digite um número: ");
int numeroUm = Convert.ToInt32(Console.ReadLine());

Console.Write("Avaliar se é múltiplo de: ");
int numeroDois = Convert.ToInt32(Console.ReadLine());

if (numeroUm % numeroDois == 0)
{
    Console.WriteLine($"\nO {numeroUm} é multiplo de {numeroDois}.");
}
else
{
    Console.WriteLine($"\nO {numeroUm} não é multiplo de {numeroDois}.");
}
