Console.Write(@"--- Etanol ou Gasolina? ---

Digite o preço do etanol (R$).....: ");
double Etanol = Convert.ToDouble (Console.ReadLine());

Console.Write("Digite o preço da gasolina (R$)...: ");
double Gases = Convert.ToDouble (Console.ReadLine());

double porcentagem = (Etanol / Gases) * 100;

Console.WriteLine($"O preço do etanol corresponde a {porcentagem}% do preço da gasolina");

if (porcentagem >= 70)
{
    Console.WriteLine("Recomendação: Abasteça com gasolina");
}

else
{
    Console.WriteLine("Recomendação: Abasteça com etanol");
}