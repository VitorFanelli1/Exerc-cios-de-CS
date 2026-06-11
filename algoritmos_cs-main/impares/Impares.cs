// Algoritmo que exibe os números pares entre 1 até
// o valor digitado pelo usuário
// Declaração das variáveis
int x = 1;
int valor = 0;

Console.Write("Por favor, digite um valor inteiro entre 1 e 1000: ");
valor = Convert.ToInt16(Console.ReadLine());

if (valor <= 1000)
{
    while (x <= valor)
    {
        Console.WriteLine($"Valor: {x}");
        x+= 2;
    }
}
else
{
    Console.WriteLine("Número inválido!!!!");
}