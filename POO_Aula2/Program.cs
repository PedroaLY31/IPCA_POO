/*
namespace Lessons
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String option = "n";
            int num1, num2;
            float result;
            
            Console.WriteLine($"Calculadora");
                
            Console.WriteLine($"Introduza um numero:");
            num1 = Convert.ToInt32(Console.ReadLine());
                
            Console.WriteLine($"Introduza outro numero:");
            num2 = Convert.ToInt32(Console.ReadLine());

            while (option != "sair")
            {
                
                Console.WriteLine($"Escreva soma, subtracao, multiplicacao, divisao ou sair");
                Console.WriteLine($"Introduza a opcao: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "soma":
                        result = Operation.Sum(num1, num2);
                        Console.WriteLine($"A soma de {num1} e {num2} e :");
                        break;
                    case "subtracao":
                        result = Operation.Sub(num1, num2);
                        Console.WriteLine($"A subtracao de {num1} e {num2} e :");
                        break;
                    case "divisao":
                        result = Operation.Div(num1, num2);
                        Console.WriteLine($"A divisao de {num1} e {num2} e :");
                        break;
                    case "multiplicacao":
                        result = Operation.Mul(num1, num2);
                        Console.WriteLine($"A multiplicacao de {num1} e {num2} e :");
                        break;
                    case "sair":
                        Console.WriteLine($"Obrigado por usar a nossa calculadora!");
                        break;
                    default:
                        Console.WriteLine($"Opcao nao reconhecida");
                        break;
                }
            }
        }
    }
}
*/