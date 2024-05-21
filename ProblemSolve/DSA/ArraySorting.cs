using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolve.DSA
{
    public class ArraySorting
    {


        public void ArraySort()
        {
            var array = new List<int> { 1, 2, 5, 76, 53, 67, 87, 56, 9, 100, 98 };



            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count-1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }

            string value = string.Join(",", array);

            Console.WriteLine(value);
        }
    }
}
