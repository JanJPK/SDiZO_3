using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDiZO_3.Utility;

namespace SDiZO_3.Salesman
{
    class SalesmanGreedy : ISDiZOable
    {
        /*
         * Start od 0.
         * Wersja aproksymacyjna.
         * Kryterium wyboru - najmniejsza odległość od ostatnio wybranego miasta.
         */

        // Lista z optymalną (aproksymacja) drogą.
        private List<int> minRoute;

        // Całkowity koszt minRoute.
        private int minRouteSum;

        // Dane wejściowe.
        private SalesmanData data;

        public SalesmanGreedy(SalesmanData inputData)
        {
            data = inputData;
            minRoute = new List<int>();
        }

        // Praca.
        public void Work()
        {
            int currentCity = 0;
            while (minRoute.Count < data.Size - 1)
            {
                // TODO: wykluczyć już odwiedzone miasta.
                currentCity = FindClosest(currentCity);
                minRoute.Add(currentCity);
            }
            minRouteSum = data.PermutationCost(minRoute);

        }

        // Zwraca najtańsze połączenie z danego miasta.
        public int FindClosest(int startingCity)
        {
            int closestCity = 0;
            int min = Int32.MaxValue;
            for (int i = 0; i < data.Size; i++)
            {
                if (i != startingCity)
                {
                    if (data.Matrix[startingCity, i] < min)
                    {
                        min = data.Matrix[startingCity, i];
                        closestCity = i;
                    }
                }

            }
            return closestCity;
        }

        // Zwracanie typu algorytmu jako string.
        public string Type()
        {
            return "Salesman Greedy";
        }

        // Zwracanie nazwy pliku.
        public string Filename()
        {
            return "SGreedy";
        }

        // Zwracanie wyniku jako string.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Problem komiwojażera - algorytm zachłanny." + Environment.NewLine);
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
