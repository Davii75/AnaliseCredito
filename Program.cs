int qntd_parcelas;
decimal maiorparcelapermitida, valoremprestimo, valorparcela, rendamensal;

Console.Write("Solicite o valor de empréstimo desejado: ");
valoremprestimo = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a quantidade de parcelas: ");
qntd_parcelas = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite aqui a sua renda mensal: ");
rendamensal = Convert.ToDecimal(Console.ReadLine());
Console.Clear();

valorparcela = valoremprestimo / qntd_parcelas;
maiorparcelapermitida = rendamensal / 100 * 30;

if (maiorparcelapermitida >= valorparcela)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("O empréstimo foi autorizado!");
    Console.ResetColor();

    Console.WriteLine("\nDados do empréstimo:");
    Console.WriteLine($"\nValor do empréstimo: {valoremprestimo:C2}");
    Console.WriteLine($"Quantidade de parcelas: {qntd_parcelas}");
    Console.WriteLine($"Sua renda mensal: {rendamensal:C2}");
}

else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("O empréstimo não pode ser realizado!");
    Console.ResetColor();
}