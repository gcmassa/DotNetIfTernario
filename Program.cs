// See https://aka.ms/new-console-template for more information


int numero = 21;
bool ehPar = false;

//IF ternario

ehPar = numero % 2 == 0;

string mensagem = "O número {numero} é " + (ehPar ? "par" : "ímpar");

Console.WriteLine(mensagem);

/*
if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par");
}
else
{
    Console.WriteLine($"O número {numero} é ímpar");
}
*/