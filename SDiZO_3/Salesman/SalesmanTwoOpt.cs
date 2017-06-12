using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDiZO_3.Utility;

namespace SDiZO_3.Salesman
{
    class SalesmanTwoOpt : ISDiZOable
    {
        /*
         * Start od 0.
         * Algorytm przeszukiwania lokalnego (na przykład 2-opt.).
         * Jeżeli przykładowo:
         * Koszt krawędzi (A, B) + (C, D) jest większy od (A, C) + (B, D), zamień je.
         * 
         * Algorytm bazuje na https://en.wikipedia.org/wiki/2-opt
         */

        // Lista z optymalną drogą.
        private List<int> minRoute;

        // Całkowity dystans minRoute.
        private int minDistance;

        // Dane wejściowe.
        private SalesmanData data;

        public SalesmanTwoOpt(SalesmanData inputData)
        {
            data = inputData;
            minRoute = new List<int>();
        }

        // Praca.
        public void Work()
        {
            for (int i = 0; i < data.Size - 1; i++)
            {
                minRoute.Add(i + 1);
            }

            // Wykonuje tak długo aż droga zostaje polepszana.
            // int improvementsCount = 0;
            int improvements;
            do
            {
                minDistance = data.PermutationDistance(minRoute);
                improvements = 0;
                for (int i = 0; i < minRoute.Count - 1; i++)
                {
                    for (int j = i + 1; j < minRoute.Count; j++)
                    {
                        // Zamiana.
                        List<int> newRoute = TwoOptSwap(minRoute, i, j);
                        // Sprawdzenie czy zamiana się opłaciła.
                        int newDistance = data.PermutationDistance(newRoute);
                        if (newDistance < minDistance)
                        {
                            minRoute = newRoute;
                            minDistance = newDistance;
                            improvements++;
                            // improvementsCount++;
                        }
                    }
                }

            } while (improvements > 0);


        }

        // Zamiana 2-opt.
        private List<int> TwoOptSwap(List<int> oldRoute, int cityA, int cityB)
        {
            List<int> newRoute = new List<int>();
            // Kopiowanie miast <0, A).
            for (int i = 0; i < cityA; i++)
            {
                newRoute.Add(oldRoute[i]);
            }

            // Pobranie elementów <A, B> do tablicy.
            int[] swap = new int[cityB - cityA + 1];
            int index = 0;
            for (int i = cityA; i <= cityB; i++)
            {
                swap[index] = oldRoute[i];
                index++;
            }

            // Odwrócenie tablicy i dodanie do newRoute.
            Array.Reverse(swap);
            for (int i = 0; i < swap.Length; i++)
            {
                newRoute.Add(swap[i]);
            }

            // Kopiowanie miast (B, END>.
            for (int i = cityB + 1; i < oldRoute.Count; i++)
            {
                newRoute.Add(oldRoute[i]);
            }

            return newRoute;
        }

        // Zwracanie typu algorytmu jako string.
        public string Type()
        {
            throw new NotImplementedException();
        }

        // Zwracanie nazwy pliku.
        public string Filename()
        {
            throw new NotImplementedException();
        }

        // Zwracanie wyniku jako string.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Problem komiwojażera - 2-opt." + Environment.NewLine);
            sb.Append("Suma wag: " + minDistance+ Environment.NewLine);
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
