internal class Program
{
    public Program()
    {
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Calculadora Bugada");

        Console.WriteLine("Digite um numero: ");
        double n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe a operação(*, -, + ou /): ");
        string operação = Console.ReadLine();
        
        Console.WriteLine("Informe um segundo numero: ");
        double n2 = double.Parse(Console.ReadLine());

        
        double resultado = 0;

        switch (operação)
        {
            case "+":
                resultado = n1 + n2;
                Console.WriteLine("o resultado é:  " + resultado);
                break;

            case "-":
                resultado = n1 - n2;
                Console.WriteLine("o resultado é:  " + resultado);
                break;

            case "/":
                resultado = n1 / n2;
                Console.WriteLine("o resultado é:  " + resultado);
                break;
                
            case "*":
                resultado = n1 * n2;
                Console.WriteLine("o resultado é:  " + resultado);
                break;
                        
            default:
                  Console.WriteLine("digite certo seu animal.");
            break;

        }


    }
}