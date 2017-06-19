using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDiZO_3.Utility
{
    // Proste generyki które będą mi potrzebne.
    public static class MyGenerics
    {

        // Zamiana.
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;

        }

        // Zwraca większą.
        // Już niepotrzebne i nie jest do końca prawdziwe => mogą być równe.
        public static T ReturnGreater<T>(T a, T b) where T : System.IComparable<T>
        {
            //return (a > b) ? a : b;
            return a.CompareTo(b) > 0 ? a : b;
        }

        // Silnia (rekursywnie)
        private static int Factorial(int n)
        {

            if (n < 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        // Permutacja.
        public static List<List<T>> AllPermutations<T>(List<T> inputList)
        {
            List<List<T>> permutations = new List<List<T>>();

            // Gdy wejściowa tablica jest zbyt mała.
            if (inputList.Count <= 1)
            {
                permutations.Add(inputList);
                return permutations;
            }

            foreach (T item in inputList)
            {
                // Lista bez obecnie przetwarzanego elementu.
                List<T> currentPermutation = new List<T>(inputList);
                currentPermutation.Remove(item);

                // Wszystkie pod-permutacje.
                foreach (List<T> permutation in AllPermutations<T>(currentPermutation))
                {
                    permutation.Add(item);
                    permutations.Add(permutation);
                }
            }

            return permutations;
        }
    }
}
