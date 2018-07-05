using System;
using System.Diagnostics;
using System.Linq;

namespace SortingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var arr1 = Enumerable.Range(1, 1000)
                .OrderBy(x => rnd.Next(1, 1000))
                .ToArray();


            //Console.Write("Arr1: ");
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.Write("{0}, ", arr1[i]);
            //}

            Console.WriteLine("\n\n=================== Bubble Sort ===================");
            //#region Bubble Sort

            //Stopwatch clock = Stopwatch.StartNew();
            //bubbleSort(arr1, arr1.Length);
            //clock.Stop();

            //#endregion

            Console.WriteLine("\n\n=================== Insertion Sort ===================");
            //#region Insertion Sort

            //Stopwatch clock = Stopwatch.StartNew();
            //insertionSort(arr1, arr1.Length);
            //clock.Stop();

            //#endregion

            Console.WriteLine("\n\n=================== Selection Sort ===================");
            //#region Selection Sort

            //Stopwatch clock = Stopwatch.StartNew();
            //selectionSort(arr1, arr1.Length);
            //clock.Stop();

            //#endregion

            Console.WriteLine("\n\n=================== Merge Sort ===================");
            #region Selection Sort

            Stopwatch clock = Stopwatch.StartNew();
            
            clock.Stop();

            #endregion

            //Console.WriteLine("\nBubble Sort - Solution took {0} ms", clock.ElapsedMilliseconds);
            //Console.WriteLine("Insertion Sort - Solution took {0} ms", clock.ElapsedMilliseconds);
            //Console.WriteLine("Selection Sort - Solution took {0} ms", clock.ElapsedMilliseconds);
            Console.WriteLine("Merge Sort - Solution took {0} ms", clock.ElapsedMilliseconds);


        }

        public static void merge(int[] arr1, int first, int middle, int last)
        {
            int[] temp = new int[last + 1];

            int first1, last1, first2, last2;
            int index = first;

            first1 = first;
            last1 = middle;
            first2 = middle + 1;
            last2 = last;

            while ((first1 <= last1) && (first2 <= last2))
            {
                if (arr1[first1] < arr1[first2])
                {
                    temp[index] = arr1[first1];
                    index++;
                    first1++;
                }
                else
                {
                    temp[index] = arr1[first2];
                    index++;
                    first2++;
                }
            }

            if (first2 > last2)
            {
                while (first1 <= last1)
                {
                    temp[index] = arr1[first1];
                    index++;
                    first1++;
                }
            }

            if (first1 > last1)
            {
                while (first2 <= last2)
                {
                    temp[index] = arr1[first2];
                    index++;
                    first2++;
                }
            }

            for (int i = first; i <= last; i++)
            {
                arr1[i] = temp[i - first];
            }

            return;
        }

        public static void mergeSort(int[] arr1, int first, int last)
        {
            if (first < last)
            {
                int middle = (int)((first + last) / 2);
                mergeSort(arr1, first, middle);
                mergeSort(arr1, middle + 1, last);
                merge(arr1, first, middle, last);
            }
        }

        private static void insertionSort(int[] arr1, int length)
        {
            int temp, j;

            for (int i = 1; i < length; i++)
            {
                temp = arr1[i];
                j = i - 1;

                while (temp<arr1[j]&&j>=0)
                {
                    arr1[j + 1] = arr1[j];
                    j = j - 1;
                }
                arr1[j + 1] = temp;
            }
        }

        private static void bubbleSort(int[] arr1, int length)
        {
            int temp, counter, index;

            for (counter = 0; counter < length - 1; counter++)
            {
                // Loop once for each element in array
                for(index=0; index < length - 1 - counter; index++)
                {
                    if (arr1[index] > arr1[index + 1])
                    {
                        temp = arr1[index];
                        arr1[index] = arr1[index + 1];
                        arr1[index + 1] = temp;
                    }
                }
            }
        }

        private static void selectionSort(int[] arr1, int length)
        {
            //Mảng a[m] có độ dài n
            for (int i = 0; i < length - 1; i++)
            {
                int max = i;

                for (int j = i + 1; j < length; j++)
                    if (arr1[max] > arr1[j])
                        max = j;
                if (max != i)
                {
                    arr1[max] ^= arr1[i];
                    arr1[i] ^= arr1[max];
                    arr1[max] ^= arr1[i];
                }
            }
        }
    }


}
