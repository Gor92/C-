using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
         delegate bool Filter(int x);

            static void Main(string[] args)

            {
                int[] array = { 5, 6, 7, 8, 11, 52, 56, 55, 47, 57, 33, 25 };

                var list1 = FilterArray(array, GetEven);
                var lsit2 = FilterArray(array, GetOdd);
                var list3 = Filtered(array, GetEven, GetOdd);
                Console.WriteLine(list1);
                Console.WriteLine(lsit2);
                Console.WriteLine(list3);
                Console.ReadKey();

            }
            static List<int> Filtered(int[] array1, Filter filter1, Filter filter2)
            {


                List<int> filtered1 = new List<int>();
                foreach (var item in array1)
                {
                    if (filter1(item))
                    {
                        filtered1.Add(item);
                    }
                }

                List<int> filtered2 = new List<int>();
                foreach (var item in array1)
                {
                    if (filter2(item))
                    {
                        filtered2.Add(item);
                    }
                }
                List<int> filtered = new List<int>();
                var array3 = filtered1.ToArray();
                var array2 = filtered2.ToArray();
                for (int i = 0; i < array3.Length; i++)
                {
                    filtered.Add(array3[i] * array2[i]);
                }





                return filtered;
            }
            static List<int> FilterArray(int[] array, Filter filter)
            {

                List<int> filteredValues = new List<int>();

                foreach (var item in array)
                {
                    if (filter(item))
                    {
                        filteredValues.Add(item);
                    }
                }

                return filteredValues;
            }

            static bool GetOdd(int value)
            {

                return value % 2 == 1;
            }

            static bool GetEven(int value)
            {
                return value % 2 == 0;
            }


            //static List<int> PerformCalculator(int[] array1, int[] array2)
            //{
            //    var list = new List<int>();
            //    for (int j = 0; j < array1.Length; j++)
            //    {
            //        array1[j] *= array2[j];
            //    }
            //    foreach (var item in list)
            //    {
            //        if (true)
            //        {
            //            list.Add(item);
            //        }
            //    }
            //    return list;
            //}

        }
    }
}
    