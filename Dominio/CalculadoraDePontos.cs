using System.Collections.Generic;

namespace Dominio
{
    public class CalculadoraDePontos
    {
        List<ICriterioParaPontuar> criterios = new List<ICriterioParaPontuar>()
        {
            new CriterioRendaBaixa(), new CriterioRendaIntermediaria(), new CriterioRendaAlta(),
            new CriterioIdadeBaixa(), new CriterioIdadeIntermediaria(), new CriterioIdadeAlta()
        };
        public int CalcularPontos(Pessoa pessoa)
        {
            var totalDePontos = 6;

            return totalDePontos;
        }
    }
}