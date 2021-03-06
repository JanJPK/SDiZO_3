﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDiZO_3.Utility;

namespace SDiZO_3.Knapsack
{
    class KnapsackDynamic : ISDiZOable
    {
        /*
         * Wersja dynamiczna - rozwiązuje podproblemy; wynik jest dokładny.
         * Złożoność O(n*b) - n ilość przedmiotów; b - pojemność plecaka.
         * Macierz gdzie kolumny oznaczają dostępne przedmioty a wiersze pojemność:
         *      wiersz 5    - przedmioty od 0 do 4 są dostępne.
         *      kolumna 6   - plecak ma pojemność 5.
         *      
         * Rozwiązanie znajduje się w rogu czyli maksymalnej pojemności i przy wszystkich przedmiotach dostepnych.
         */

        // Dane wejściowe.
        private KnapsackData data;

        // Lista wyjściowa.
        private List<KnapsackData.Item> chosenItems;

        // Macierz na wyniki.
        private MatrixCell[,] matrix;

        public KnapsackDynamic(KnapsackData inputData)
        {
            data = inputData;
            chosenItems = new List<KnapsackData.Item>();

            // Macierz [ilość przedmiotów + 1] X [Pojemność + 1]
            matrix = new MatrixCell[data.Items.Count + 1, data.Capacity + 1];
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
                        matrix[i, j] = new MatrixCell(0, data);
                    }
                    else
                    {
                        // Czy nowy przedmiot zmieści się?
                        if (data.Items[i - 1].Size <= j)
                        {
                            // stara wersja
                            // matrix[i, j] = MyGenerics.ReturnGreater(data.Items[i - 1].Value + matrix[i - 1, (j - data.Items[i - 1].Size)],
                            // matrix[i - 1, j]);

                            int a = data.Items[i - 1].Value + matrix[i - 1, (j - data.Items[i - 1].Size)].Value;
                            int b = matrix[i - 1, j].Value;
                            if (a > b)
                            {
                                // Komórka = nowy przedmiot + to co się zmieści po odjęciu jego wagi od j.
                                matrix[i, j] = new MatrixCell(matrix[i - 1, (j - data.Items[i - 1].Size)]);
                                matrix[i, j].AddItem(i - 1);
                            }
                            else
                            {
                                // Kopia poprzedniego wiersza.
                                matrix[i, j] = new MatrixCell(matrix[i - 1, j]);
                            }
                        }
                        else
                        {
                            matrix[i, j] = matrix[i - 1, j];
                        }
                    }
                }
            }

            // Dodawanie przedmiotów do listy wybranych przedmiotów.
            foreach (int i in matrix[data.Items.Count, data.Capacity].Items)
            {
                chosenItems.Add(data.Items[i]);
            }
        }

        // Postawiłem z ciekawości na podejście obiektowe - każda komórka w macierzy jest obiektem który zawiera indeksy swoich przedmiotów i sumę wartości.
        // Takie podejście pozwala szybko sprawdzić co w której komórce jest wybrane.
        // Jak z wydajnością? będzie czas to sprawdzę i porównam.
        private class MatrixCell
        {
            // Indeksy przedmiotów.
            public List<int> Items { get; private set; }

            // Suma wartości.
            public int Value { get; set; }

            // Odnośnik do danych.
            private KnapsackData data;

            // Konstruktor zwyczajny.
            public MatrixCell(int value, KnapsackData data)
            {
                this.data = data;
                Value = value;
                Items = new List<int>();
            }

            // Konstruktor kopiujący.
            public MatrixCell(MatrixCell cloneBlueprint)
            {
                data = cloneBlueprint.data;
                Value = cloneBlueprint.Value;
                Items = new List<int>(cloneBlueprint.Items);
            }

            // Dodawanie przedmiotu.
            public void AddItem(int index)
            {
                Items.Add(index);
                Value = Value + data.Items[index].Value;
            }

            // Zwaracanie jako string = po prostu wypis warości.
            public override string ToString()
            {
                return Value.ToString();
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
            sb.Append("Pojemność plecaka: " + data.Capacity + Environment.NewLine);
            sb.Append("Wypełnienie plecaka: " + chosenItems.Sum(o => o.Size) + "/" + data.Capacity + Environment.NewLine);
            sb.Append("Suma wartości: " + chosenItems.Sum(o => o.Value) + Environment.NewLine);
            sb.Append("Wybrane przedmioty: " + Environment.NewLine);

            int index = 0;
            foreach (KnapsackData.Item item in chosenItems)
            {
                sb.Append(index + " - " + item + Environment.NewLine);
                index++;
            }

            sb.Append("Macierz: " + Environment.NewLine);
            for (int i = 0; i < data.Items.Count + 1; i++)
            {
                sb.Append("" + i + " - ");
                for (int j = 0; j < data.Capacity + 1; j++)
                {
                    sb.Append("[" + matrix[i, j] + "]  ");
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }

    }
}
