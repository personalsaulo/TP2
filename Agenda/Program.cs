using System;
using System.Globalization;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa dadosPessoa = new Pessoa();

            int opcao;

            do
            {
                Console.WriteLine("Gerenciador de Aniversario");
                Console.WriteLine("Selecione uma das opções abaixo");
                Console.WriteLine("1 - Pesquisar Pessoas");
                Console.WriteLine("2 - Adicionar Nova Pessoa");
                Console.WriteLine("3 - Sair");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Nome :");
                    string nome = Console.ReadLine();
                    dadosPessoa.pesquisarPessoa(nome);
                }


                if (opcao == 2)
                {
                    Console.WriteLine("Nome :");
                    dadosPessoa.Nome = Console.ReadLine();
                    Console.WriteLine("Data de Nascimento");
                    dadosPessoa.DataDeNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    dadosPessoa.AdicionarNome(dadosPessoa);
                }
                    


            } while (opcao != 3);




            Console.ReadKey();
        }

        

    }
}
