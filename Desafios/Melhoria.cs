using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafios
{
    /*
     * Sim, existe um erro no código. Pode ser disparada uma exceção de limite de memória,
     * pois nunca é liberada a lista de cidades a cada instância do objeto.
     * A correção consiste em exernalizar a adição de novas cidades do construtor para um método próprio,
     * que fará a adição para a lista somente quando o desenvolvedor tiver a intenção de adicionar através da chamada deste,
     * ao invés de criar sempre os elementos da lista através do construtor.
     */
    
    public class Melhoria
    {
        public class UF
        {
            public string Sigla { get; set; }
            public string NomeUF { get; set; }
        }

        public class Cidade
        {
            public UF UF { get; set; }
            public string Nome { get; set; }
        }

        public class Programa
        {
            private List<Cidade> listaCidades;

            public Programa()
            {
                listaCidades = new List<Cidade>();
            }

            public Cidade BuscaCidade(string uf)
            {
                var cidade = listaCidades.FirstOrDefault(a => a.UF.Sigla == uf);

                if (cidade == null)
                    throw new Exception("Cidade não encontrada!");

                return cidade;
            }

            public void Consulta()
            {
                var cidade = BuscaCidade("PR");
                Console.WriteLine("Cidade: " + cidade.Nome);

                var uf = cidade.UF;
                Console.WriteLine("Estado: " + uf.Sigla);
            }

            public void AdicionaCidade(Cidade cidade)
            {
                listaCidades.Add(cidade);
            }
            
            public void AdicionaCidades(List<Cidade> cidades)
            {
                listaCidades.AddRange(cidades);
            }
        }
    }
}