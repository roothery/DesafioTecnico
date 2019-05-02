using System;

namespace Dominio
{
    public class CriterioIdadeAlta : ICriterioParaPontuar
    {
        public int AdquirirPontuacao(Pessoa pessoa)
        {
            var idade = DateTime.Now.Year - pessoa.DataNascimento.Year;

            if (DateTime.Now.Month < pessoa.DataNascimento.Month || (DateTime.Now.Month == pessoa.DataNascimento.Month && DateTime.Now.Day < pessoa.DataNascimento.Day))
            {
                idade--;
            }

            return idade >= 45 ? 3 : 0;
        }
    }
}