using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProblemSolve.LeetCode
{
    public class RemoveDuplicateArray
    {


       public void DuplicateRemove()
        {
            List<int> list = new List<int> {2, 5, 76, 53, 67, 87, 56, 2, 100, 98,5 };

            List<int> newdata = new List<int>();



            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            var value1 = string.Join(",", list);
            Console.WriteLine(value1);


            for (int i = 0; i < list.Count-1; i++)
            {
                if (list[i] != list[i+1])
                {
                    newdata.Add(list[i]);
                   
                }
            }


            var value= string.Join(",", newdata);
            Console.WriteLine(value);

        }




    }
}
