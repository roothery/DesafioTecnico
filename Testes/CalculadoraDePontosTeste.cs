using Dominio;
using System;
using Xunit;

namespace Testes
{
    public class CalculadoraDePontosTeste
    {
        [Fact]
        public void Deve_retornar_pontuação_do_candidato_cadastrado()
        {
            var candidato = new Pessoa("Pedro", Situacao.Pretendente, new DateTime(1971, 03, 25), 1478.85);

            var resultado = new CalculadoraDePontos().CalcularPontos(candidato);

            Assert.Equal(6, resultado);
        }
    }
}