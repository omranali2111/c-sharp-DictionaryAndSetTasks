using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

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
        /*
        Task 5: Set Intersection
        Write a function that takes two arrays of integers as input and 
        returns a HashSet containing the elements that are common to both arrays(i.e., the intersection). 
        Test the function with different inputarrays and print the resulting HashSet.
        */
       public static HashSet<int> GetArrayIntersection(int[] array1, int[] array2)
        {
            HashSet<int> set1 = new HashSet<int>(array1);
            HashSet<int> set2 = new HashSet<int>(array2);

            set1.IntersectWith(set2);

            return set1;
        }




    }
}
