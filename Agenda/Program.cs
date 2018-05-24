using System;
using System.Globalization;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa dadosPessoa = new Pessoa();




            Console.WriteLine("Nome :");
               dadosPessoa.Nome = Console.ReadLine();
            Console.WriteLine("Data de Nascimento");
            dadosPessoa.DataDeNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            dadosPessoa.AdicionarNome(dadosPessoa);


            Console.ReadKey();




        }
    }
}
