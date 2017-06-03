using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDiZO_3.Salesman
{
    class SalesmanBruteforce
    {
        /*
         * Wersja optymalna - sprawdza wszystkie kombinacje i wybiera najlepszą.
         * Paskudna złożoność obliczeniowa O(n!).
         */

        // Dane wejściowe.
        private SalesmanData data;

        public SalesmanBruteforce(SalesmanData inputData)
        {
            data = inputData;
        }

        // Praca.
        public void Work()
        {
            throw new NotImplementedException();
        }

        // Zwracanie typu algorytmu jako string.
        public string Type()
        {
            return "Salesman Bruteforce";
        }

        // Zwracanie nazwy pliku.
        public string Filename()
        {
            return "SBruteforce";
        }

        // Zwracanie wyniku jako string.
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
