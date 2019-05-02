namespace Dominio
{
    public class CriterioRendaBaixa : ICriterioParaPontuar
    {
        public int AdquirirPontuacao(Pessoa pessoa)
        {
            return pessoa.Renda <= 900 ? 5 : 0;
        }
    }
}