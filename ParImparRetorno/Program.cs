int numero;
Console.WriteLine("Informe um valor para verificar se é par ");
numero = int.Parse(Console.ReadLine());

if (ehPar(numero))
{
    Console.WriteLine($"O número {numero} é par");
}
else
{
    Console.WriteLine($"O número {numero} é impar");
}


bool EhPar(int valor)
{
    if (valor % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
