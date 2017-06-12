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
         * Idę do A. Gdzie najbliżej z A? B.
         * Idę do B. Gdzie najbliżej z B? C.
         *              . . . 
         */

        // Lista z optymalną (aproksymacja) drogą.
        private List<int> minRoute;

        // Całkowity koszt minRoute.
        private int minDistance;

        // Tablica odwiedzonych miast.
        private bool[] visitedCities;

        // Dane wejściowe.
        private SalesmanData data;

        public SalesmanGreedy(SalesmanData inputData)
        {
            data = inputData;
            minRoute = new List<int>();
            visitedCities = new bool[data.Size];
            for (int i = 0; i < visitedCities.Length; i++)
            {
                visitedCities[i] = false;
            }
        }

        // Praca.
        public void Work()
        {
            // Ostatnio odwiedzone miasto czyli 0.
            int currentCity = 0;
            visitedCities[0] = true;
            // Aż nie przejdzie wszystkich miast:
            while (minRoute.Count < data.Size - 1)
            {
                // Idź do najbliższego miasta od ostatnio odwiedzonego.
                currentCity = FindClosestNotVisited(currentCity);
                // Dodaj do trasy i uzupełnij w tablicy.
                minRoute.Add(currentCity);
                visitedCities[currentCity] = true;
            }
            minDistance = data.PermutationDistance(minRoute);

        }

        // Zwraca najtańsze połączenie z danego miasta.
        public int FindClosestNotVisited(int startingCity)
        {
            int closestCity = 0;
            int min = Int32.MaxValue;
            // Przeszukiwanie liniowe.
            // TODO: usprawnić.
            for (int i = 0; i < data.Size; i++)
            {
                if (i != startingCity && visitedCities[i] == false)
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
