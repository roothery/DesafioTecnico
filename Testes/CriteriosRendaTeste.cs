using Dominio;
using System;
using Xunit;

namespace Testes
{
    public class CriteriosRendaTeste
    {
        [Fact]
        public void Candidato_deve_realizar_5_pontos_para_renda_de_até_900_reais()
        {

            var candidato = new Pessoa("Roothery", Situacao.Pretendente, new DateTime(1995, 07, 10), 800.75);
            var criterio = new CriterioRendaBaixa();

            var resultado = criterio.AdquirirPontuacao(candidato);

            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Candidato_deve_realizar_3_pontos_para_renda_de_901_até_1500()
        {

            var candidato = new Pessoa("Roothery", Situacao.Pretendente, new DateTime(1995, 07, 10), 1470.45);
            var criterio = new CriterioRendaIntermediaria();

            var resultado = criterio.AdquirirPontuacao(candidato);

            Assert.Equal(3, resultado);
        }

        [Fact]
        public void Candidato_deve_realizar_1_ponto_para_renda_de_1501_até_2000()
        {

            var candidato = new Pessoa("Roothery", Situacao.Pretendente, new DateTime(1995, 07, 10), 1800);
            var criterio = new CriterioRendaAlta();

            var resultado = criterio.AdquirirPontuacao(candidato);

            Assert.Equal(1, resultado);
        }
    }
}