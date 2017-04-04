using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    /// <summary>
    /// O(n^2)
    /// </summary>
    class SelectionSort : ISorter
    {
        /// <summary>
        /// Sorts the given array with a selection sort
        /// </summary>
        /// <param name="array">The array to be sorted</param>
        public void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[j] < array[min])
                    {
                        min = j;
                    }
                    int temp = array[i];
                    array[i] = array[min];
                    array[min] = temp;
                }
            }
        }
    }
}
