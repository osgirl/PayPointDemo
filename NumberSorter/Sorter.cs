//***************************************************************************************
//                          Written By Mike Valchera
//***************************************************************************************

using INumberSorter;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberSorter
{
    /// <summary>
    /// This class implements ISorter and will return numbers in a sorted manor
    /// </summary>
    public class Sorter : ISorter
    {
        /// <summary>
        /// Sorts numbers from Highest to lowest
        /// </summary>
        public List<int> SortHighToLow(string inputValues)
        {
            if(inputValues == null)
            {
                throw new ArgumentNullException();
            }

            if(!uint.TryParse(inputValues, out uint n)){
                throw new ArgumentException("Input value must be a number");
            }

            List<int> returnList = inputValues.Select(x => x.ToString()).ToArray().Select(Int32.Parse).ToList();

            return returnList.OrderByDescending(x => x).ToList();

        }
    }
}
