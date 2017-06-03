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
            // W każdym wierszu jest [Size] liczb.
            // Początek wiersza + [Size] = początek kolejnego wiersza.
            int firstInRow = 1; // Index pierwszego elementu w wierszu.
            for (int i = 0; i < Size; i ++)
            {
                for (int j = firstInRow; j < Size + firstInRow; j++)
                {
                    matrix[i, j - firstInRow] = InputList[j];
                }
                firstInRow += Size;
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
                sb.Append("" + i + " - ");
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
