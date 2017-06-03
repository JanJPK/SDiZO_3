using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDiZO_3.Utility;

namespace SDiZO_3.Salesman
{
    class SalesmanGreedy : ISDiZOable
    {
        /*
         * Wersja aproksymacyjna.
         * 
         */

        // Dane wejściowe.
        private SalesmanData data;

        public SalesmanGreedy(SalesmanData inputData)
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
            return "Salesman Greedy";
        }

        // Zwracanie nazwy pliku.
        public string Filename()
        {
            return "SGreedy";
        }

        // Zwracanie wyniku jako string.
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
