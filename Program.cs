Console.WriteLine("Digite o primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

int num3 = 0;

Console.WriteLine("Qual das ações quer utilizar? \nsomar \nsubtrair \ndividir \nmultiplicar ");
string acao = Console.ReadLine();

switch (acao)
{
    case "somar":
    num3 = num1 + num2;
    break;
    
    case "subtrair":
    num3 = num1 - num2;
    break;

    case "dividir":
    num3 = num1 / num2;
    break;

    case "multiplicar":
    num3 = num1 * num2;
    break;

    default:
    Console.WriteLine("Opção inexistente.");
}


