using Dominio;
using System;
using Xunit;

namespace Testes
{
    public class CriteriosIdadeTeste
    {
        [Fact]
        public void Candidato_deve_realizar_3_pontos_para_idade_igual_ou_acima_de_45_anos()
        {

            var candidato = new Pessoa("Roothery", Situacao.Pretendente, new DateTime(1970, 07, 10), 800.75); // 47 anos
            var criterio = new CriterioIdadeAlta();

            var resultado = criterio.AdquirirPontuacao(candidato);

            Assert.Equal(3, resultado);
        }

        [Fact]
        public void Candidato_deve_realizar_2_pontos_para_idade_de_30_até_45_anos()
        {

            var candidato = new Pessoa("Roothery", Situacao.Pretendente, new DateTime(1980, 07, 10), 1470.45); // 37 anos
            var criterio = new CriterioIdadeIntermediaria();

            var resultado = criterio.AdquirirPontuacao(candidato);

            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Candidato_deve_realizar_1_ponto_para_idade_abaixo_de_30_anos()
        {

            var candidato = new Pessoa("Roothery", Situacao.Pretendente, new DateTime(1995, 07, 10), 1800); // 23 anos
            var criterio = new CriterioRendaAlta();

            var resultado = criterio.AdquirirPontuacao(candidato);

            Assert.Equal(1, resultado);
        }
    }
}