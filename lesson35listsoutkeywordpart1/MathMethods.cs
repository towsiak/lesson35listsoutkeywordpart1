using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson35listsoutkeywordpart1
{
    //class functions as a container for storing methods relating to mathematics
    static class MathMethods
    {
        //public so the method can be accessed outside
        //static means method can be called by writing MathMethods.Summarize
        //void means no value is returned 
        //name of method is Summarize
        //in general, through parameters values are passed into the body of a method
        //first parameter is an array of decimal data values so we have something to work on
        //out decimal max is used to set the value of the variable that represents the maximum in the array
        //out decimal min is used to set the value of the variable that represents the minimum in the array
        //out decimal average is used to set the value of the variable that represents the average of the array
        //out decimal sum is used to set the value of the variable that represent the sum of the array
        public static void Summarize(decimal[] values, out decimal max,out decimal min, out decimal average, out decimal sum)
        {
            var list = values.ToList();//convert to list first so max,min, and others can be used easily
            max = list.Max();//finds max of list, and sets the value of the max parameter
            min = list.Min();//finds the max of list, and sets the value of min parameter
            average = list.Average();//finds the average, and sets the value of the average out parameter
            sum = list.Sum();//finds the average and sets the sum of the out sum parameter

        }
    }
}
