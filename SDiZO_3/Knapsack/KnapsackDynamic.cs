using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDiZO_3.Knapsack
{
    class KnapsackDynamic
    {
        /*
         * Wersja optymalna - sprawdza wszystkie kombinacje i wybiera najlepszą.
         * Paskudna złożoność obliczeniowa O(2^n).
         */

        // Dane wejściowe.
        private KnapsackData data;

        // Lista wyjściowa.
        private List<KnapsackData.Item> chosenItems;

        // Macierz na wyniki.
        private int[,] matrix;


        public KnapsackDynamic(KnapsackData inputData)
        {
            data = inputData;
            chosenItems = new List<KnapsackData.Item>();

            // Macierz [ilość przedmiotów] X [Pojemność]
            matrix = new int[data.Items.Count + 1, data.Capacity + 1];
        }

        // Zwraca większą.
        private T ReturnGreater<T>(T a, T b) where T : System.IComparable<T>
        {
            //return (a > b) ? a : b;
            return a.CompareTo(b) > 0 ? a : b;
        }

        // Praca.
        public void Work()
        {
            for (int i = 0; i <= data.Items.Count; i++)
            {
                for (int j = 0; j <= data.Capacity; j++)
                {
                    // Wartości z brzegów = 0;
                    if (i == 0 || j == 0)
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        if (data.Items[i - 1].Size <= j)
                        {
                            matrix[i, j] = ReturnGreater(data.Items[i - 1].Value + matrix[i - 1, (j - data.Items[i - 1].Size)],
                                matrix[i - 1, j]);
                        }
                        else
                        {
                            matrix[i, j] = matrix[i - 1, j];
                        }
                    }
                }
            }

        }

        // Zwracanie typu algorytmu jako string.
        public string Type()
        {
            return "Knapsack Dynamic";
        }

        // Zwracanie nazwy pliku.
        public string Filename()
        {
            return "KDynamic";
        }

        // Zwracanie wyniku jako string.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Problem plecakowy - programowanie dynamiczne." + Environment.NewLine);
            sb.Append(String.Format("Wynik: {0}", matrix[data.Items.Count, data.Capacity]) + Environment.NewLine);
            sb.Append("Macierz: " + Environment.NewLine);
            for (int i = 0; i < data.Items.Count + 1; i++)
            {
                sb.Append("" + i + " - ");
                for (int j = 0; j < data.Capacity + 1; j++)
                {
                    //string dupa = string.Format("[{0, -10}]", matrix[i, j]);
                    //sb.Append(dupa);
                    sb.Append("[" + matrix[i, j] + "]  ");
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
