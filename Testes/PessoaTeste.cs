using Dominio;
using System;
using Xunit;

namespace Testes
{
    public class PessoaTeste
    {
        [Fact]
        public void Deve_validar_nome_da_pessoa_cadastrada()
        {
            var candidato = new Pessoa("Roothery", Situacao.Pretendente, new DateTime(1995, 07, 10), 1800.00);

            Assert.Equal("Roothery", candidato.Nome);
        }

        [Fact]
        public void Deve_validar_situação_da_pessoa_cadastrada()
        {
            var candidato = new Pessoa("Roothery", Situacao.Pretendente, new DateTime(1995, 07, 10), 1800.00);

            Assert.Equal("Pretendente", candidato.TipoPessoa.ToString());
        }

        [Fact]
        public void Deve_validar_data_de_nascimento_da_pessoa_cadastrada()
        {
            var candidato = new Pessoa("Roothery", Situacao.Pretendente, new DateTime(1995, 07, 10), 1800.00);

            Assert.Equal("10/07/1995", candidato.DataNascimento.ToString("dd/MM/yyyy"));
        }

        [Fact]
        public void Deve_validar_renda_da_pessoa_cadastrada()
        {
            var candidato = new Pessoa("Roothery", Situacao.Pretendente, new DateTime(1995, 07, 10), 1800.00);

            Assert.Equal("1800", candidato.Renda.ToString());
        }
    }
}
