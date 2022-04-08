double m, h, imc;

Console.WriteLine("Digite seu peso em kg...:");
m = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite sua altura em m...:");
h = Convert.ToDouble(Console.ReadLine());

imc = (m / (h*h));

if (imc < 17)
{
    Console.WriteLine("Muito abaixo do peso");
}
else if (imc < 18.5)
{
    Console.WriteLine("Abaixo do peso");
}
else if(imc < 25)
{
    Console.WriteLine("Peso normal");
}
else if (imc < 30)
{
    Console.WriteLine("Acima do peso");
}
else if (imc < 35)
{
    Console.WriteLine("Obesidade I");
}
else if (imc < 40)
{
    Console.WriteLine("Obesidade II (severa)");
}
else if (imc > 40)
{
    Console.WriteLine("Obesidade III (mórbida)");
}

Console.WriteLine($"Seu IMC é:{imc}");
