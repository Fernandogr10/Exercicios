using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafios
{
    public static class Calculo
    {
        public static void Calculo1(List<int> numeros)
        {
            int maior, menor, soma;
            double media;
            int somaPares;

            maior = MaiorElemento(numeros);
            menor = MenorElemento(numeros);
            soma = SomaElementos(numeros);
            media = MediaElementos(numeros);
            somaPares = SomaElementosPares(numeros);
            
            PrintaResultadoCalculo1(maior, menor, soma, media, somaPares);
        }

        public static int MaiorElemento(List<int> numeros) => numeros is not null && numeros.Count > 0 ? numeros.Max() : 0;
        
        public static int MenorElemento(List<int> numeros) => numeros is not null && numeros.Count > 0 ?  numeros.Min() : 0;

        public static int SomaElementos(List<int> numeros) => numeros?.Sum() ?? 0;

        public static double MediaElementos(List<int> numeros) => numeros.Count > 0 ? numeros.Average() : 0.0;

        public static int SomaElementosPares(List<int> numeros)
        {
            var pares = numeros.Where(n => n % 2 == 0);
            return pares.Sum();
        }

        public static void PrintaResultadoCalculo1(int maior, int menor, int soma, double media, int somaPares)
        {
            Console.WriteLine($"maior: {maior}");
            Console.WriteLine($"menor: {menor}");
            Console.WriteLine($"soma: {soma}");
            Console.WriteLine($"media: {media}");
            Console.WriteLine($"somaPares: {somaPares}");
        }
    }
}