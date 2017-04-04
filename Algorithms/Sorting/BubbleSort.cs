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
    class BubbleSort : ISorter
    {
        /// <summary>
        /// Sorts the given array with a bubble sort 
        /// </summary>
        /// <param name="array">The array to be sorted</param>
        public void Sort(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    if(array[j-1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
