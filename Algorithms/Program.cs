using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the array");
            int el = 0;
            List<int> arr = new List<int>();
            while (el != -1)
            {
                el = Convert.ToInt32(Console.ReadLine());
                arr.Add(el);

            }
            int[] arrS = arr.ToArray();
            Merge.sort(arrS);

            Console.ReadLine();
        }
    }

    public static class Merge
    {
        static int[] a;

        public static void merge(int[] a, int[] aux, int lo, int mid, int hi)
        {
            for(int k = lo; k <= hi; k++)
            {
                aux[k] = a[k];
            }

            int i = lo, j = mid + 1;
            for(int k = lo; k <= hi; k++)
            {
                if (i > mid) a[k] = aux[j++];
                else if (j > hi) a[k] = aux[i++];
                else if (aux[j] < aux[i]) a[k] = aux[j++];
                else a[k] = aux[i++];

            }
        }

        public static void sort(int[] a)
        {
            var aux = new int[a.Length];
            sort(a, aux, 0, a.Length - 1);
        }

        public static void sort(int[] a, int[] aux, int lo, int hi)
        {
            if (hi <= lo) return;
            int mid = (lo + hi) / 2;
            sort(a, aux, lo, mid);
            sort(a, aux, mid + 1, hi);
            merge(a, aux, lo, mid, hi);


        }
    }
}
