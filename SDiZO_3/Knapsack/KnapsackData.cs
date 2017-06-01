using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDiZO_3.Knapsack
{
    public class KnapsackData
    {
        // Klasa reprezentująca dane dla problemu plecakowego.
        // Zawiera pojemność plecaka, informacje o ilości przedmiotów i listę przedmiotów.
        public int Capacity { get; }

        public int ItemAmount { get; }

        public List<Item> Items { get; }

        public KnapsackData(List<int> InputList)
        {
            // Pobieram interesujące mnie informacje z początku pliku i usuwam je bo nie będą już potrzebne.
            Capacity = InputList[0];
            InputList.RemoveAt(0);

            ItemAmount = InputList[0];
            InputList.RemoveAt(0);

            // Wypełnianie listy.
            Items = new List<Item>();
            for (int i = 0; i < ItemAmount * 2; i += 2)
            {
                Items.Add(new Item(InputList[i], InputList[i + 1]));
            }


        }

        // Konwersja do string.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Pojemność plecaka: " + Capacity + Environment.NewLine);
            sb.Append("Ilość przedmiotów: " + ItemAmount + Environment.NewLine);
            sb.Append("Dostępne przedmioty: " + Environment.NewLine);
            foreach (Item item in Items)
            {
                sb.Append(item + Environment.NewLine);
            }
            return sb.ToString();
        }

        // Klasa reprezentująca przedmiot.
        public class Item
        {
            // Wartość.
            public int Value { get; }

            // Rozmiar.
            public int Size { get; }

            public Item(int size, int value)
            {
                Value = value;
                Size = size;
            }

            // Zwraca stosunek wartość/rozmiar.
            public double ValueRatio()
            {
                double ratio = Value / Size;
                // Zaokrąglam do 2 miejsc po przecinku.
                return Math.Round(ratio, 2);
            }

            public override string ToString()
            {
                // "R: <rozmiar>; W: <wartość>; R/W: <stosunek>;"
                return "R: " + Size + "; W: " + Value + "; R/W: " + ValueRatio() + ";";
            }
        }
    }

}
