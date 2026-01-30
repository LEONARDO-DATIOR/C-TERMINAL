const string Separador = "______________________________";

void OpcoesDePrograma() {   
    string textoOpcao = @"
        Opções de Programa:
        1 - Calculadora:
        2 - Exibir Ajuda:
        3 - Sair:    
    ";
    Console.WriteLine(textoOpcao);

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Iniciando Calculadora...");
            Console.WriteLine(Separador);
            Calculadora();
            break;
        case "2":
            Console.WriteLine("Ajuda: Este é um programa de exemplo em C#.");
            break;
        case "3":
            Console.WriteLine("Saindo do programa...");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}

OpcoesDePrograma();


void Calculadora() {
    Console.WriteLine("Calculadora Simples");

    float multiplicacao(float a, float b) {
        Console.WriteLine($"Multiplicando {a} por {b}");
        return a * b;
    }

    float soma(float a, float b) {
        Console.WriteLine($"Somando {a} com {b}");
        return a + b;
    }

    float subtracao(float a, float b) {
        Console.WriteLine($"Subtraindo {b} de {a}");
        return a - b;
    }

    float divisao(float a, float b) {
        if (b == 0 || a == 0) {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
            return 0;
        }
        Console.WriteLine($"Dividindo {a} por {b}");
        return a / b;
    }
}



