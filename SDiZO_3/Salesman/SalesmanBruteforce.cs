using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDiZO_3.Utility;

namespace SDiZO_3.Salesman
{
    class SalesmanBruteforce : ISDiZOable
    {
        /*
         * Start od 0.
         * Wersja optymalna - sprawdza wszystkie kombinacje i wybiera najlepszą.
         * Paskudna złożoność obliczeniowa O(n!).
         * Uwaga! EKSTREMALNIE nieefektywne pamięciowo! TODO: permutacje do całkowitego przerobienia.
         */

        // Lista z optymalną drogą.
        private List<int> minRoute;

        // Całkowity dystans minRoute.
        private int minDistance;

        // Dane wejściowe.
        private SalesmanData data;

        public SalesmanBruteforce(SalesmanData inputData)
        {
            data = inputData;
            
        }

        // Praca.
        public void Work()
        {
            // O jeden mniejsze ponieważ zawsze startujemy od 0; nie zawiera początku i końca.
            // Dlaczego? Ułatwia permutacje dla zadanego przypadku.
            List<int> route = new List<int>();
            minDistance = Int32.MaxValue;
            for (int i = 0; i < data.Size - 1; i++)
            {
                route.Add(i + 1);
            }

            // Lista wszystkich permutacji.
            List<List<int>> permutations = MyGenerics.AllPermutations(route);

            // Sprawdzamy która permutacja jest "najtańsza".
            foreach (List<int> permutation in permutations)
            {
                // Jeżeli koszt tej permutacji jest mniejszy od obecnego min, obecna permutacja = min.
                int permutationCost = data.PermutationDistance(permutation);
                if (permutationCost < minDistance)
                {
                    minRoute = permutation;
                    minDistance = permutationCost;
                }
            }
        }

        // Zwracanie typu algorytmu jako string.
        public string Type()
        {
            return "Salesman Bruteforce";
        }

        // Zwracanie nazwy pliku.
        public string Filename()
        {
            return "SBruteforce";
        }

        // Zwracanie wyniku jako string.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Problem komiwojażera - przegląd zupełny." + Environment.NewLine);
            sb.Append("Suma wag: " + minDistance + Environment.NewLine);
            sb.Append("Droga: " + Environment.NewLine);
            int previous = 0;
            foreach (int i in minRoute)
            {
                sb.Append(previous + " -> " + i + " / " + data.Matrix[previous, i] + Environment.NewLine);
                previous = i;
            }
            sb.Append(previous + " -> " + 0 + " / " + data.Matrix[previous, 0] + Environment.NewLine);

            return sb.ToString();
        }
    }
}
