using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    /// <summary>
    /// Sorts given array
    /// </summary>
    public interface ISorter
    {
        /// <summary>
        /// Sorts the given array
        /// </summary>
        /// <param name="array">The array to sort</param>
        void Sort(int[] array);
    }
}
