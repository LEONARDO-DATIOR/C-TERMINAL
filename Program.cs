internal class Program
{
    private static void Main(string[] args)
    {
        const string Separador = "______________________________";

        void OpcoesDePrograma()
        {
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
                    new CalculadoraApp().Calcular();
                    Console.WriteLine(Separador);
                    OpcoesDePrograma();
                    break;
                case "2":
                    Console.WriteLine("Ajuda: Este é um programa de exemplo em C#.");
                    OpcoesDePrograma();
                    break;
                case "3":
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    OpcoesDePrograma(); 
                    break;
            }
        }

        OpcoesDePrograma();
    }
}

