using System;
using System.Collections;
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
         * Idea - wariacje tablicy bool gdzie:
         *      index - ID przedmiotu
         *      true -> przedmiot w plecaku
         *      false -> przedmiot nie jest w plecaku
         * Sprawdzamy które kombinacje się mieszczą i która najlepsza.
         * Jak to zrobić? Wszystkie liczby w postaci binarnej od 0 do 2^n - 1.
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
            intToBinary(6);
        }

        // Zwraca tablicę 32 true/false - postać bitowa.
        private BitArray intToBinary(int number)
        {
            return new BitArray(new int[] { number });
        }

        // Praca.
        public void Work()
        {
            // Tworzenie tablicy tablic - tablica to postać bitowa obecnego indeksu.
            int twoPower = (int)Math.Pow(2, data.ItemAmount);
            BitArray[] bitArrays = new BitArray[twoPower];
            for (int i = 0; i < twoPower; i++)
            {
                bitArrays[i] = intToBinary(i);
            }

            // Sprawdzenie każdej kombinacji i wybranie najlepszej.
            List<KnapsackData.Item> combination;
            int combinationValue;
            int combinationSize;
            foreach (BitArray ba in bitArrays)
            {
                combination = new List<KnapsackData.Item>();
                combinationValue = 0;
                combinationSize = 0;
                // Sprawdzenie każdego bitu od pierwszego do ilości przedmiotów.
                for (int i = 0; i < data.ItemAmount; i++)
                {
                    if (ba[i] == true)
                    {
                        combination.Add(data.Items[i]);
                        combinationValue += data.Items[i].Value;
                        combinationSize += data.Items[i].Size;
                    }

                    // Jeżeli ta kombinacja zmieści się w plecaku...
                    if (combinationSize <= data.Capacity)
                    {
                        // ...sprawdź czy jest lepsza od obecnie wybranej i zamień jeżeli tak.
                        if (combinationValue > chosenItemsSum)
                        {
                            chosenItems = new List<KnapsackData.Item>(combination);
                            chosenItemsSum = combinationValue;
                        }
                    }
                
                }

            }
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
            sb.Append("Pojemność plecaka: " + data.Capacity + Environment.NewLine);
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
