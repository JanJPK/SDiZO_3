using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDiZO_3.Salesman
{
    public class SalesmanData
    {
        // Klasa reprezentująca dane dla problemu komiwojażera.
        // Zawiera tylko macierz, wielkość i metodę do wypisywania.
        
        private int[,] matrix;

        public int Size { get; set; }

        public SalesmanData(List<int> InputList)
        {
            // InputList[0] = ilość miast.
            Size = InputList[0];
            matrix = new int[Size, Size];

            // Usuwam pierwszą liczbę bo jest mi już zbędna.
            InputList.RemoveAt(0);

            // Teraz InputList[0] = początek macierzy.
            // W każdym wierszu jest [Size] liczb.
            // Początek wiersza + [Size] = początek kolejnego wiersza.
            int index = 0;
            for (int i = 0; i < Size; i += Size)
            {
                for (int j = i; j < i + Size; j++)
                {
                    matrix[index, j] = InputList[j];
                }
                index++;
            }
        }
    
        // Konwersja do string.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();  
            sb.Append("Liczba miast: " + Size + Environment.NewLine);
            sb.Append("Dostępne miasta: " + Environment.NewLine);
            for (int i = 0; i < Size; i++)
            {
                sb.Append("{" + i + "} - ");
                for (int j = 0; j < Size; j++)
                {
                    sb.Append("[" + matrix[i, j] + "]  ");
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
