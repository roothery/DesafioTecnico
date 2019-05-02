namespace Dominio
{
    public class CriterioRendaIntermediaria : ICriterioParaPontuar
    {
        public int AdquirirPontuacao(Pessoa pessoa)
        {
            return pessoa.Renda >= 901 && pessoa.Renda <= 1500 ? 3 : 0;
        }
    }
}