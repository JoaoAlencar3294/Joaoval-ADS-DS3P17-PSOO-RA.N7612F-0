using ConsoleApp2.Entities;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual o seu Nome?");
            DadosPessoa pessoa = new DadosPessoa("N760912F0", "Joao Victor ALencar de Lima", 
                "joao123@gmail.com", "Sorocaba", "1234-5678");

            Console.ReadLine();
            var resultado = pessoa.Ra;
            

            Console.WriteLine("o seu Ra é:" + resultado);

            Console.WriteLine("Você deseja continuar, para ver as informações? (s/n)");
            string resposta = Console.ReadLine();

            if (resposta =="s") 
            {
                Console.WriteLine(
                    "Nome do usuario:" + pessoa.Nome + 
                    "RA do usuario:" + pessoa.Ra+
                    "Email: " + pessoa.Email+ 
                    "Edereco: " + pessoa.Endereco+
                    "Telefone:" + pessoa.Telefone);
            }

            else if (resposta == "não")  
            {
            Console.WriteLine("Tudo bem, encerrando...");
            }
            else
            {
                Console.WriteLine("Resposta inválida. Por favor, responda com 'sim' ou 'não'.");
            }



        }
    }
}