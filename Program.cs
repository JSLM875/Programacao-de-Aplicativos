using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("CALCULADORA BÁSICA");
        Console.Write("Escreva o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Escreva o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Operações Disponíveis:");
        Console.WriteLine("* - multiplicação");
        Console.WriteLine("/ - divisão");
        Console.WriteLine("+ - adição");
        Console.WriteLine("- - subtração");

        Console.Write("Escolha a operação: ");
        char operacao = char.Parse(Console.ReadLine());

        if(operacao == '*')
        {
            Console.WriteLine(num1 + " " + operacao + " " + num2 + " = " +num1 * num2);
        }
        else if(operacao == '/')
        {
            if (num2 ==0)
        {    
            Console.WriteLine("Não se pode dividir por zero");
        }    
        else 
        {   
            Console.WriteLine(num1 + " " + operacao + " " + num2 + " = " + num1 / num2);
        }
        }
        else if(operacao == '+')
        {
            Console.WriteLine(num1 + " " + operacao + " " + num2 + " = " + num1 + num2);
        }
        else if(operacao == '-')
        {
            Console.WriteLine(num1 + " " + operacao + " " + num2 + " = " + (num1 - num2));
        }
        else
        {
            Console.WriteLine("Essa operação não existe ");
        }
            Console.ReadLine();
    }
}