using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDiZO_3.Utility;

namespace SDiZO_3.Salesman
{
    class SalesmanDynamic : ISDiZOable
    {
        /*
         * Start od 0.
         * 
         * 
         */

        // Lista z optymalną drogą.
        private List<int> minRoute;

        // Całkowity koszt minRoute.
        private int minRouteSum;

        // Dane wejściowe.
        private SalesmanData data;

        public SalesmanDynamic(SalesmanData inputData)
        {
            data = inputData;
            minRoute = new List<int>();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }

        public string Type()
        {
            throw new NotImplementedException();
        }

        public string Filename()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Problem komiwojażera - X." + Environment.NewLine);
            //sb.Append("Suma wag: " + minRouteSum + Environment.NewLine);
            sb.Append("Droga: " + Environment.NewLine);
            int previous = 0;
            foreach (int i in minRoute)
            {
                sb.Append(previous + " -> " + i + " / " + data.Matrix[previous, i] + Environment.NewLine);
                previous = i;
            }
            sb.Append(previous + " -> " + 0 + " / " + data.Matrix[previous, 0] + Environment.NewLine);

            return sb.ToString();
        }
    }
}
