using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    /// <summary>
    /// O(nlog(n))
    /// </summary>
    class MergeSort :ISorter
    {
        /// <summary>
        /// Sorts the given array with a merge sort
        /// </summary>
        /// <param name="array">The array to be sorted</param>
        public void Sort(int[] array)
        {
            var temp = new int[array.Length - 1];
            DoMergeSort(array, temp, 0, array.Length - 1);
        }

        private void DoMergeSort(int[] array, int[] temp, int left, int right)
        {
            if (left < right)
            {
                int center = (left + right) / 2;
                DoMergeSort(array, temp, left, center);
                DoMergeSort(array, temp, center + 1, right);
                Merge(array, temp, left, center + 1, right);
            }
        }

        private void Merge(int[] array, int[] temp, int left, int right, int rightEnd)
        {
            int leftEnd = right - 1;
            int k = left;
            int num = rightEnd - left + 1;
            while(left<leftEnd && right <= rightEnd)
            {
                if(array[left] <= temp[right])
                {
                    temp[k++] = array[left++];
                }
                else
                {
                    temp[k++] = array[right++];
                }
            }

            while(left <= leftEnd)
            {
                temp[k++] = array[right++];
            }

            while(right <= rightEnd)
            {
                temp[k++] = array[right++];
            }

            for(int i=0; i< num; i++, rightEnd--)
            {
                array[rightEnd] = temp[rightEnd];
            }
        }
    }
}
