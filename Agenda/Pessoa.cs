using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
   public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public List<Pessoa> listaPessoa = new List<Pessoa>();




        public void AdicionarNome(Pessoa dadosDaPessoa)
        {
            listaPessoa.Add(dadosDaPessoa);
        }

        public void pesquisarPessoa(string nome)
        {
            for (int i = 0; i <= listaPessoa.Count - 1; i++)
            {
                if (listaPessoa[i].Nome == nome)
                    Console.WriteLine("resultado: Nome " + listaPessoa[i].Nome + " Data de aniversario: " + listaPessoa[i].DataDeNascimento);
            }
        }
    }
}
