// Faça um programa que receba a idade de 10 pessoas e mostre a quantidade de maiores e menores (sem vetor)

int adults = 0;
int minors = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite a {i + 1}ª idade: ");
    int age = int.Parse(Console.ReadLine());

    while (age < 0)
    {
        Console.Write($"Idade não pode ser negativa, digite novamente a {i + 1}ª idade: ");
        age = int.Parse(Console.ReadLine());
    }

    if (age >= 18)
        adults++;
    else
        minors++;
}

Console.WriteLine($"Maiores: {adults}\nMenores: {minors}");