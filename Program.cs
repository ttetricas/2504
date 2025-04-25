// Aula 25.04 -Decisões-

string senhaDigitada;
string senhaEsperada = "1224";

Console.Write("Digite sua senha: ");
senhaDigitada = Console.ReadLine()!;

if (senhaDigitada == senhaEsperada)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("SUCESSO");
}

else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ERRO, TENTE NOVAMENTE");
}
Console.ResetColor();
