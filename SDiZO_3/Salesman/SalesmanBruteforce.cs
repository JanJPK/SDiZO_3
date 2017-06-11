using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDiZO_3.Utility;

namespace SDiZO_3.Salesman
{
    class SalesmanBruteforce
    {
        /*
         * Start od 0.
         * Wersja optymalna - sprawdza wszystkie kombinacje i wybiera najlepszą.
         * Paskudna złożoność obliczeniowa O(n!).
         */

        // Lista z optymalną drogą.
        private List<int> minRoute;

        // Całkowity koszt minRoute.
        private int minRouteSum;

        // Dane wejściowe.
        private SalesmanData data;

        public SalesmanBruteforce(SalesmanData inputData)
        {
            data = inputData;
            minRoute = new List<int>();
        }

        // Praca.
        public void Work()
        {
            // O jeden mniejsze ponieważ zawsze startujemy od 0 - takie założenia projektu.
            List<int> cities = new List<int>();
            for (int i = 0; i < data.Size - 1; i++)
            {
                cities.Add(i + 1);
                minRouteSum = Int32.MaxValue;
            }

            List<List<int>> permutations = MyGenerics.AllPermutations(cities);

            // Sprawdzamy która permutacja jest "najtańsza".
            foreach (List<int> permutation in permutations)
            {
                // Jeżeli koszt tej permutacji jest mniejszy od obecnego min, obecna permutacja = min.
                int permutationCost = data.PermutationCost(permutation);
                if (permutationCost < minRouteSum)
                {
                    minRoute = permutation;
                    minRouteSum = permutationCost;
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
            sb.Append("Suma wag: " + minRouteSum + Environment.NewLine);
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
