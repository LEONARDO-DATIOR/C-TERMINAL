using System;

public class Calculadora {
    public override string ToString() {
        return "\nEscolha a operação:\n0 - Sair\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão";
    }
    
    public float multiplicacao(float a, float b) {
        Console.WriteLine($"\nMultiplicando {a} por {b}");
        return a * b;
    }

    public float soma(float a, float b) {
        Console.WriteLine($"\nSomando {a} com {b}");
        return a + b;
    }

    public float subtracao(float a, float b) {
        Console.WriteLine($"\nSubtraindo {b} de {a}");
        return a - b;
    }

    public float divisao(float a, float b) {
        if (b == 0 || a == 0) {
            Console.WriteLine("E\nrro: Divisão por zero não é permitida.");
            return 0;
        }
        Console.WriteLine($"Dividindo {a} por {b}");
        return a / b;
    }

  

}


