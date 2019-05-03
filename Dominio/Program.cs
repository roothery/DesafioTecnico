using System;

namespace Dominio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(System.Guid.NewGuid());

            var dataAtual = DateTime.Now;
            var dataAniversario = new DateTime(1980, 07, 10);
            var resultado = dataAtual.Year - dataAniversario.Year;
            if (dataAtual.Month < dataAniversario.Month || (dataAtual.Month == dataAniversario.Month && dataAtual.Day < dataAniversario.Day))
            {
                resultado--;
            }

            Console.WriteLine(resultado);

            Console.ReadLine();
        }
    }
}

