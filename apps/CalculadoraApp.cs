

public class CalculadoraApp
{        
    public string Calcular()
    {
        Calculadora calc = new Calculadora();
        Console.WriteLine(calc.ToString());
        Console.WriteLine("\nDigite o número da operação:");
        string operacao = Console.ReadLine();
        if (operacao == "0")
        {
            Console.WriteLine("Saindo da Calculadora...");
            return "";
        }



        Console.WriteLine("\n\n\n~~~~~~~~~~~~~\nDigite o primeiro número:");
        float num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("\nDigite o segundo número:");
        float num2 = float.Parse(Console.ReadLine());

        switch (operacao)
        {   
            case "1":
                float resultadoSoma = calc.soma(num1, num2);
                Console.WriteLine($"Resultado da soma de {num1} e {num2}: {resultadoSoma}");
                Calcular();
                return "";
            case "2":
                float resultadoSubtracao = calc.subtracao(num1, num2);
                Console.WriteLine($"Resultado da subtração de {num1} e {num2}: {resultadoSubtracao}");
                Calcular();
                return "";
            case "3":
                float resultadoMultiplicacao = calc.multiplicacao(num1, num2);
                Console.WriteLine($"Resultado da multiplicação de {num1} e {num2}: {resultadoMultiplicacao}");
                Calcular();
                return "";
            case "4":
                float resultadoDivisao = calc.divisao(num1, num2);
                Console.WriteLine($"Resultado da divisão de {num1} por {num2}: {resultadoDivisao}");
                Calcular();
                return "";
            default:
                Console.WriteLine("Operação inválida.");
                Calcular();
                return "";
        }
    }
    
}