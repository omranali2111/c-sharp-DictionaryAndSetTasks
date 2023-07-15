using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace c_sharp_DictionaryAndSetTasks
{
    internal class HashSet
    {
        /*
        Task 2: Unique Elements
        Write a function that takes an array of integers as input and returns a HashSet containing only the
        unique elements from the array.Test the function with different input arrays and print the resulting
        HashSet.
        */
        public static HashSet<int> GetUniqueElements(int[] array)
        {
            HashSet<int> uniqueElements = new HashSet<int>(array);
            return uniqueElements;
        }




    }
}
