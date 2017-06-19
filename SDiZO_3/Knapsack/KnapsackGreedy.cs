using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDiZO_3.Utility;

namespace SDiZO_3.Knapsack
{
    class KnapsackGreedy : ISDiZOable
    {
        /*
         * Wersja aproksymacyjna - nie zawsze wynik będzie optymalny.
         * Złożoność O(n*logn).
         *      1. Posortuj listę przedmiotów według zadanego kryterium.
         *      2. Dodawaj kolejne przedmioty tak długo aż nie dojdziesz do końca listy lub nie przekroczysz pojemności plecaka.
         */

        // Dane wejściowe.
        private KnapsackData data;

        // Posortowana lista przedmiotów.
        private List<KnapsackData.Item> sortedItems;

        // Lista wyjściowa.
        private List<KnapsackData.Item> chosenItems;

        // Tryb pracy:
        // true     -> zachłanny na wartość.
        // false    -> zachłanny na wartość/waga.
        private bool mode;

        public KnapsackGreedy(KnapsackData inputData, bool mode)
        {
            data = inputData;
            this.mode = mode;
            chosenItems = new List<KnapsackData.Item>();
        }

        // Sortowanie listy przedmiotów.
        private void Sort()
        {
            // true     -> zachłanny na wartość.
            // false    -> zachłanny na wartość/waga.
            // Utwórz nową listę która jest posortowaną kopią listy z data.
            if (mode)
            {
                // Sortowanie po wartości.
                sortedItems = (data.Items).OrderByDescending(o => o.Value).ToList();
            }
            else
            {
                // Sortowanie po stosunku wartość/waga.
                sortedItems = (data.Items).OrderByDescending(o => o.Ratio).ToList();
            }
        }

        // Praca.
        public void Work()
        {
            Sort();
            // Obecny rozmiar + index przedmiotu.
            int currentSize = 0;
            int index = 0;
            // Wybieranie przedmiotów.
            // Tak długo aż rozmiar nie zostanie przekroczony lub nie dojdziemy do końca.
            while (currentSize < data.Capacity && index < sortedItems.Count)
            {
                // Czy przedmiot zmieści się w plecaku? Tak => dodaj go.
                if (currentSize + sortedItems[index].Size <= data.Capacity)
                {
                    chosenItems.Add(sortedItems[index]);
                    currentSize += sortedItems[index].Size;
                }
                index++;
            }
        }

        // Zwracanie typu algorytmu jako string.
        public string Type()
        {
            if (mode)
            {
                return "Knapsack Greedy W";
            }
            return "Knapsack Greedy R";
        }

        // Zwracanie nazwy pliku.
        public string Filename()
        {
            if (mode)
            {
                return "Knapsack Greedy R";
            
            }
            return "KGreedyR";
        }

        // Zwracanie wyniku jako string.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Problem plecakowy - algorytm zachłanny na: ");
            if (mode)
            {
                sb.Append("Wartość." + Environment.NewLine);
            }
            else
            {
                sb.Append("Wartość/waga." + Environment.NewLine);
            }
            sb.Append("Pojemność plecaka: " + data.Capacity + Environment.NewLine);
            sb.Append("Wypełnienie plecaka: " + chosenItems.Sum(o => o.Size) + "/" + data.Capacity + Environment.NewLine);
            sb.Append("Suma wartości: " + chosenItems.Sum(o => o.Value) + Environment.NewLine);
            sb.Append("Wybrane przedmioty: " + Environment.NewLine);

            int index = 0;
            foreach(KnapsackData.Item item in chosenItems)
            {
                sb.Append(index + " - " + item + Environment.NewLine);
                index++;
            }

            return sb.ToString();
        }
    }
}
