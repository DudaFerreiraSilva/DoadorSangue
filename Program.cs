int idade;

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Qual a sua idade: ");
Console.ResetColor();

idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 18 && idade <= 67)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Você pode ser doador de sangue.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Você não pode ser doador de sangue.");
    Console.ResetColor();
}
