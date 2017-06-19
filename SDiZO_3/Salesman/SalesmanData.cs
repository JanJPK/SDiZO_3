﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDiZO_3.Utility;

namespace SDiZO_3.Salesman
{
    public class SalesmanData
    {
        // Klasa reprezentująca dane dla problemu komiwojażera.
        // Zawiera tylko macierz, wielkość i metodę do wypisywania.
        
        public int[,] Matrix { get; set; }

        public int Size { get; set; }

        public SalesmanData(List<int> InputList)
        {
            // InputList[0] = ilość miast.
            Size = InputList[0];
            Matrix = new int[Size, Size];
            // W każdym wierszu jest [Size] liczb.
            // Początek wiersza + [Size] = początek kolejnego wiersza.
            int firstInRow = 1; // Index pierwszego elementu w wierszu.
            for (int i = 0; i < Size; i ++)
            {
                for (int j = firstInRow; j < Size + firstInRow; j++)
                {
                    Matrix[i, j - firstInRow] = InputList[j];
                }
                firstInRow += Size;
            }
        }

        // Zwraca dystans danej permutacji miast.
        public int PermutationDistance(List<int> permutation)
        {
            int previousCity = 0;
            int sum = 0;
            for (int i = 0; i < permutation.Count; i++)
            {
                sum += Matrix[previousCity, permutation[i]];
                previousCity = permutation[i];
            }
            // Połączenie ostatniego z pierwszym.
            sum += Matrix[previousCity, 0];

            return sum;
        }

        // Konwersja do string.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();  
            sb.Append("Liczba miast: " + Size + Environment.NewLine);
            sb.Append("Dostępne miasta: " + Environment.NewLine);
            for (int i = 0; i < Size; i++)
            {
                sb.Append("" + i + " - ");
                for (int j = 0; j < Size; j++)
                {
                    sb.Append("[" + Matrix[i, j] + "]  ");
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
