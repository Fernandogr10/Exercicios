using System.Collections.Generic;

namespace Desafios
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            Calculo.Calculo1(numeros);

            var programa = new Melhoria.Programa();

            List<Melhoria.Cidade> cidades = new List<Melhoria.Cidade>
            {
                new() { Nome = "Curitiba", UF = new Melhoria.UF() { Sigla = "PR " } },
                new() { Nome = "São Paulo", UF = new Melhoria.UF() { Sigla = "SP " } },
                new() { Nome = "Floripa", UF = new Melhoria.UF() { Sigla = "SC " } }
            };
            
            programa.AdicionaCidades(cidades);
            
            programa.Consulta();
        }
    }
}