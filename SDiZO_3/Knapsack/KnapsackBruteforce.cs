using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDiZO_3.Knapsack
{
    class KnapsackBruteforce
    {
        /*
         * Wersja optymalna - sprawdza wszystkie kombinacje i wybiera najlepszą.
         * Paskudna złożoność obliczeniowa O(2^n).
         */

        // Dane wejściowe.
        private KnapsackData data;

        // Lista wyjściowa.
        private List<KnapsackData.Item> chosenItems;

        public KnapsackBruteforce(KnapsackData inputData)
        {
            data = inputData;
            chosenItems = new List<KnapsackData.Item>();
        }

        // Praca.
        public void Work()
        {
            throw new NotImplementedException();
        }

        // Zwracanie typu algorytmu jako string.
        public string Type()
        {
            return "Knapsack Bruteforce";
        }

        // Zwracanie nazwy pliku.
        public string Filename()
        {
            return "KBruteforce";
        }

        // Zwracanie wyniku jako string.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Problem plecakowy - algorytm brute-force." + Environment.NewLine);
            sb.Append("Suma wartości: " + chosenItems.Sum(o => o.Value) + Environment.NewLine);
            sb.Append("Wybrane przedmioty: " + Environment.NewLine);

            int index = 0;
            foreach (KnapsackData.Item item in chosenItems)
            {
                sb.Append(index + " - " + item + Environment.NewLine);
                index++;
            }

            return sb.ToString();
        }
    }
}
