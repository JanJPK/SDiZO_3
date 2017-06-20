using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDiZO_3.Utility;

namespace SDiZO_3.Salesman
{
    class SalesmanAnnealing : ISDiZOable
    {
        /*
         * Wersja symulowanego wyżarzania.
         * Znajduje rozwiązanie przybliżone zadanego problemu
         * Losowo wybiera rozwiązania gorsze bo mogą być w sąsiedztwie lepszych - unika minimum/ekstremum lokalnych.
         * Maleje temperatura (jak w metalurgii). Im mniejsza temperature tym algorytm jest mniej skłonny na podejmowanie ryzykownych przeskoków.
         *      Przykładowo:
         *          - wybierz dowolną permutacje
         *          - permutacja dwóch miast
         *              wynik jest lepszy -> akceptuj
         *              wynik jest gorszy -> pewne prawdopodobieństwo akceptacji (zależne od pogorszenia i temperatury)
         *          - kontynuuj tak długo jak temperatura > 0
         * Algorytm zapamiętuje najlepszą drogę jaką znalazł gdy odpowiednia wartość bool = true;
         */

        // Lista z optymalną drogą.
        private List<int> minRoute;

        // Całkowity dystans minRoute.
        private int minDistance;

        // Dane wejściowe.
        private SalesmanData data;

        // Temperatura.
        // Na początku wysoka -> duże prawdopodobieństwo akceptacji gorszego wyniku.
        // Na końcu niska -> praktycznie zerowe prawdopodobieństwo.
        private double temperature;
        private double startingTemperature;

        // O ile stygnie.
        private double cooling;

        // Ile razy stygło.
        // Dla T = 1000 i mnożnik = 0.99 jest to około 1400 razy.
        private int coolCounter;

        // Czy ma zapamiętywać najlepszą droge jaką znalazł?
        private static bool rememberRoute = true;

        private Random rng;

        public SalesmanAnnealing(SalesmanData inputData, double temperature = 1000, double cooling = 0.99)
        {
            data = inputData;
            this.temperature = temperature;
            this.cooling = cooling;
            startingTemperature = temperature;
            coolCounter = 0;
            rng = new Random();          
        }

        // Praca.
        public void Work()
        {
            // Zmienne na obecnie przetwarzaną trasę i nową.
            List<int> currentRoute = new List<int>();
            // Startowa kombinacja = posortowana rosnąco.
            for (int i = 0; i < data.Size - 1; i++)
            {
                currentRoute.Add(i + 1);
            }
            List<int> newRoute;

            int currentDistance = data.PermutationDistance(currentRoute);
            int newDistance;
            // Różnica dystansów.
            int delta;

            minRoute = null;
            minDistance = Int32.MaxValue;

            while (temperature > 0.001)
            {
                // Nowa trasa = stara trasa z podmienionymi dwoma miastami.
                newRoute = NewRoute(currentRoute);
                newDistance = data.PermutationDistance(newRoute);
                delta = newDistance - currentDistance;

                // Nowa trasa jest krótsza lub warunek zamiany spełniony.
                if (delta < 0 || AnnealingCondition(delta))
                {
                    currentRoute = newRoute;
                    currentDistance = newDistance;

                    // Zapamiętanie najmniejszej trasy - może się zdarzyć że program wyjdzie z najlepszej opcji a potem nie znajdzie nic takiego.
                    if (rememberRoute && newDistance < minDistance)
                    {
                        minRoute = currentRoute;
                        minDistance = currentDistance;
                    }
                }

                // Obniżenie temperatury.
                temperature *= cooling;
                coolCounter++;
            }

            if (!rememberRoute)
            {
                minRoute = currentRoute;
                minDistance = currentDistance;
            }

        }

        // Warunek zamiany.
        private bool AnnealingCondition(int delta)
        {
            if (delta == 0)
            {
                return false;
            }
            return (Math.Exp(-delta / temperature) > rng.NextDouble());
        }

        // Nowa kombinacja miast.
        private List<int> NewRoute(List<int> oldRoute)
        {
            List<int> newRoute = new List<int>(oldRoute);

            // Zamiana dwóch miast.
            SwapTwoCities(newRoute);

            return newRoute;
        }

        // Losowo zamienia dwa miasta.
        private void SwapTwoCities(List<int> list)
        {
            int firstIndex = rng.Next(0,  list.Count);
            int secondIndex = rng.Next(0, list.Count);

            int swap = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = swap;
        }

        // Zwracanie typu algorytmu jako string.
        public string Type()
        {
            return "Salesman Annealing";
        }

        // Zwracanie nazwy pliku.
        public string Filename()
        {
            return "SAnnealing";
        }

        // Zwracanie wyniku jako string.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Problem komiwojażera - symulowane wyżarzanie." + Environment.NewLine);
            sb.Append("Temperatura początkowa: " + startingTemperature + " Mnożnik ochładzania: " + cooling + Environment.NewLine);
            sb.Append("Ilość iteracji: " + coolCounter + Environment.NewLine);
            sb.Append("Algorytm w trybie pamiętania najlepszego wyniku: " + rememberRoute + Environment.NewLine);
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
