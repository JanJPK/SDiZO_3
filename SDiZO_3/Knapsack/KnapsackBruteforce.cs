using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDiZO_3.Utility;

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

        // Całkowity koszt chosenItems.
        private int chosenItemsSum;

        public KnapsackBruteforce(KnapsackData inputData)
        {
            data = inputData;
            chosenItems = new List<KnapsackData.Item>();
            chosenItemsSum = 0;
        }

        // Praca.
        public void Work()
        {
            // Podejście z komiwojażera nie zadziała ze względu na ograniczenie pojemności. 
            // TODO: przerobić.
            /*
            // Lista wszystkich permutacji.
            List<List<KnapsackData.Item>> permutations = MyGenerics.AllPermutations(data.Items);

            int permutationSum;
            // Sprawdzamy która permutacja jest najlepsza.
            foreach (List<KnapsackData.Item> permutation in permutations)
            {
                // Jeżeli koszt tej permutacji jest mniejszy od obecnego min, obecna permutacja = min.
                permutationSum = SumItemValue(permutation);
                if (permutationSum > chosenItemsSum)
                {
                    chosenItems = permutation;
                    chosenItemsSum = permutationSum;
                }
            }
            */
        }

        // Sumowanie wartości przedmiotów.
        private int SumItemValue(List<KnapsackData.Item> inputList)
        {
            int sum = 0;
            foreach (KnapsackData.Item item in inputList)
            {
                sum += item.Value;
            }
            return sum;
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
