//***************************************************************************************
//                          Written By Mike Valchera
//***************************************************************************************

using System.Collections.Generic;

namespace INumberSorter
{
    /// <summary>
    /// Interface to Number sorter
    /// </summary>
    public interface ISorter
    {
        List<int> SortHighToLow(string inputValues);
    }
}
