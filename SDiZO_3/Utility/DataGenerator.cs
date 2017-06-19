using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDiZO_3.Knapsack;
using SDiZO_3.Salesman;

namespace SDiZO_3.Utility
{
    public static class DataGenerator
    {
        private static Random rng;

        public static List<int> Knapsack(int itemAmount, int knapsackSize)
        {
            // pierwsza linia: [pojemność plecaka][ilość przedmiotów]
            // kolejnie linie: [rozmiar przedmiotu][wartość przedmiotu]
            rng = new Random();
            List<int> dataList = new List<int>();
            dataList.Add(knapsackSize);
            dataList.Add(itemAmount);

            // Zakładam że suma wszystkich rozmiarów jest trzykrotnie większa od pojemności.
            int averageSize = (int)(3 * knapsackSize / itemAmount);
            int lower = (int)(averageSize / 2);
            int upper = (int)(averageSize * 1.5);
            for (int i = 0; i < itemAmount; i++)
            {
                // Rozmiar od average/2 do average * 2.
                dataList.Add(rng.Next(lower, upper));
                // Wartość od average/4 do average * 4 - wiekszy rozrzut.
                dataList.Add(rng.Next(lower/2, upper*2));
            }

            return dataList;
        }

        public static List<int> Salesman(int cityAmount)
        {
            // pierwsza linia: [liczba miast]
            // kolejnie linie: [miasto][odległości do wszystkich innych(tam gdzie jest obecne miasto = 0)]
            rng = new Random();
            List<int> dataList = new List<int>();
            dataList.Add(cityAmount);

            int power = (int)(cityAmount * cityAmount);
            int lower = (int)(cityAmount / 2);
            int upper = (int) (cityAmount * 1.5);
            for (int i = 0; i < cityAmount; i++)
            {
                for (int j = 0; j < cityAmount; j++)
                {
                    if (i == j)
                    {
                        dataList.Add(0);
                    }
                    else
                    {
                        dataList.Add(rng.Next(lower, upper));
                    }
                }
            }

            return dataList;
        }
    }
}
