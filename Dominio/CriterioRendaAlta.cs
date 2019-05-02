namespace Dominio
{
    public class CriterioRendaAlta : ICriterioParaPontuar
    {
        public int AdquirirPontuacao(Pessoa pessoa)
        {
            return pessoa.Renda >= 1501 && pessoa.Renda <= 2000 ? 1 : 0;
        }
    }
}