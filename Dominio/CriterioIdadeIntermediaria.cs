using System;

namespace Dominio
{
    public class CriterioIdadeIntermediaria : ICriterioParaPontuar
    {
        public int AdquirirPontuacao(Pessoa pessoa)
        {
            var idade = DateTime.Now.Year - pessoa.DataNascimento.Year;

            if (DateTime.Now.Month < pessoa.DataNascimento.Month || (DateTime.Now.Month == pessoa.DataNascimento.Month && DateTime.Now.Day < pessoa.DataNascimento.Day))
            {
                idade--;
            }

            return idade >= 30 && idade <= 44 ? 2 : 0;
        }
    }
}