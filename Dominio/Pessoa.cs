using System;

namespace Dominio
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public Situacao TipoPessoa { get; set; }
        public DateTime DataNascimento { get; set; }
        public Double Renda { get; set; }

        public Pessoa(String nome, Situacao tipoPessoa, DateTime dataNascimento, Double renda)
        {
            Id = System.Guid.NewGuid();
            Nome = nome;
            TipoPessoa = tipoPessoa;
            DataNascimento = dataNascimento;
            Renda = renda;
        }
    }
    public enum Situacao
    {
        Pretendente,
        Cônjuge,
        Dependente
    }
}