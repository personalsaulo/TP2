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






        public void AdicionarNome(Pessoa dadosDaPessoa)
        {
            List<Pessoa> listaPessoa = new List<Pessoa>();
            listaPessoa.Add(dadosDaPessoa);

        }

    }
}
