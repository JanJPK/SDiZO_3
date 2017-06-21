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

        public KnapsackData(List<int> inputList)
        {
            // Pobieram interesujące mnie informacje z początku pliku.
            Capacity = inputList[0];
            ItemAmount = inputList[1];

            // Wypełnianie listy.
            Items = new List<Item>();
            for (int i = 2; i <= ItemAmount * 2; i += 2)
            {
                Items.Add(new Item(inputList[i], inputList[i + 1]));
            }
        }

        // Klasa reprezentująca przedmiot.
        public class Item
        {
            // Wartość.
            public int Value { get; }

            // Rozmiar.
            public int Size { get; }

            // Stosunek.
            public double Ratio { get; }

            public Item(int size, int value)
            {
                Value = value;
                Size = size;
                Ratio = ValueRatio();
            }

            // Zwraca stosunek wartość/rozmiar.
            public double ValueRatio()
            {
                // Uwaga! Przy dzieleniu int przez int C# traci ułamek -> trzeba zrobić cast do double przynajmniej jednej liczby.
                double ratio = (double)Value / (double)Size;
                // Zaokrąglane do 4 po przecinku.
                return Math.Round(ratio, 4);
            }

            // Konwersja do string.
            public override string ToString()
            {
                // "R: <rozmiar>; W: <wartość>; R/W: <stosunek>;"
                return "R: " + Size + "; W: " + Value + "; W/R: " + ValueRatio() + ";";
            }
        }

        // Konwersja do string.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Pojemność plecaka: " + Capacity + Environment.NewLine);
            sb.Append("Ilość przedmiotów: " + ItemAmount + Environment.NewLine);
            sb.Append("Dostępne przedmioty: " + Environment.NewLine);
            int index = 0;
            foreach (Item item in Items)
            {
                sb.Append(index + " - " + item + Environment.NewLine);
                index++;
            }
            return sb.ToString();
        }

        
    }

}
