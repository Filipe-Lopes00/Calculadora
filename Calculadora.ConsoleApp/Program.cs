namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)


        {
            do 
            {  
                Console.Clear();
            Console.WriteLine("Calculadora top 2023");

            Console.WriteLine("Digite 1 para adicionar");
            Console.WriteLine("Digite 2 para Subtrair");
            Console.WriteLine("Digite 3 para Dividir");
            Console.WriteLine("Digite 4 para Multiplicar");
            Console.WriteLine("Digite 5 para Sair!");

                string operacao = Console.ReadLine();
            if(operacao == "5")
                {
                    break; 
                }    
            if(operacao != "1"&& operacao != "2" && operacao != "3" && operacao != "4")
                {
                    Console.WriteLine("operacao invalida");
                    Console.ReadLine();
                    continue;
                }   

            Console.WriteLine();

            Console.Write("digite o primeiro numero: ");
            decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = 0;
            bool ehAdicao = operacao == "1";
            bool ehSubtracao = operacao == "2";
            bool ehDivisao = operacao == "3";
            bool ehMultiplicacao = operacao == "4";
                                       
                
            if (ehAdicao)
            {
                resultado = primeiroNumero + segundoNumero;
            }
            else if (ehSubtracao)
            {
                resultado = primeiroNumero - segundoNumero;
            }
            else if (ehDivisao)
            {
                    while (segundoNumero == 0)
                    {
                        Console.WriteLine("Digite um numero diferente de ZERO");
                        segundoNumero = Convert.ToDecimal(Console.ReadLine());
                    }

                resultado = primeiroNumero / segundoNumero;
            }

            else if (ehMultiplicacao)
            {
                resultado = primeiroNumero * segundoNumero;
            }

            Console.WriteLine("o resultado da operação é: " + resultado);
            Console.ReadLine();


            }while (true) ;
            


            
        }
    }
}