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
    class InsertionSort : ISorter
    {
        /// <summary>
        /// Sorts the given array with a insertion sort
        /// </summary>
        /// <param name="array">The array to be sorted</param>
        public void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int index = array[i]; 
                int j = i;
                while (j > 0 && array[j - 1] > index)
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = index;
            }
        }
    }
}
