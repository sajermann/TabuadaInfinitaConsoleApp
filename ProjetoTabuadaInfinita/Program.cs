using System;

namespace ProjetoTabuadaInfinita
{
    class Program
    {
        static void Main(string[] args)
        {
            GerandoTabuada tabuadaDoUsuario = new GerandoTabuada();
            double tabuada = 0.00;
            double ateQueNumero = 0.00;
            double intervalo = 0.00;
            bool resposta = false;
            Console.WriteLine("##### Bem vindo ao programa Tabuada Infinita #####\n");
            
            while (resposta == false) { 
            try
            {
                    Console.Write("Informe o número que deseja mostrar a tabuada: ");
                    double respostaTabuada = double.Parse(Console.ReadLine());
                    resposta = true;
                    tabuada = respostaTabuada;
            }
            catch { Console.WriteLine("\nNão parece um número, vamos tentar novamente!"); resposta = false; };
            }
            resposta = false;
            while (resposta == false)
            {
                try
                {
                    Console.Write("\nInforme até que número você deseja calcular: ");
                    double respostaAteQueNumero = double.Parse(Console.ReadLine());
                    resposta = true;
                    ateQueNumero = respostaAteQueNumero;
                }
                catch { Console.WriteLine("\nNão parece um número válido, vamos tentar novamente!"); resposta = false; };
            }
            resposta = false;
            while (resposta == false)
            {
                try
                {
                    Console.Write("\nInforme o intervalo que deseja utilizar: ");
                    double respostaIntervalo = double.Parse(Console.ReadLine());
                    resposta = true;
                    intervalo = respostaIntervalo;
                }
                catch { Console.WriteLine("\nNão parece um intervalo válido, vamos tentar novamente!"); resposta = false; };
            }


           


            tabuadaDoUsuario.GerarTabuada(tabuada, ateQueNumero, intervalo);
        }
    }
}
