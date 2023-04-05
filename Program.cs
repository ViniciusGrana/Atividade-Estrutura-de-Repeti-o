Console.WriteLine($"Digite o seu nome: ");
string nome = Console.ReadLine();

while (nome == "")
{
    Console.WriteLine($"Digite um nome com pelo menos 1 caracter");
    nome = Console.ReadLine();
}
Console.WriteLine($"Informaçoes recebidas");

Console.WriteLine($"Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

while (idade < 0 || idade > 100)
{
    Console.WriteLine($"Idade invalida");
    idade = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Idade Valida");


Console.WriteLine($"Informe seu salário: ");
float salario = float.Parse(Console.ReadLine());
while (salario < 0)
{
    Console.WriteLine($"Salário invalido");
    salario = float.Parse(Console.ReadLine());
}
Console.WriteLine($"Salário valido");


Console.WriteLine($"Informe seu estado civil: 's'(solteiro) 'c'(casado) 'v'(viuvo) 'd'(divorciado) ");
char estadoCivil = char.Parse(Console.ReadLine().ToLower());

while (estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd')
{
    Console.WriteLine($"Estado Civil invalido");
    estadoCivil = char.Parse(Console.ReadLine());
}
Console.WriteLine($"Estado Civil Valido");










