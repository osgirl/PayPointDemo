//***************************************************************************************
//                          Written By Mike Valchera
//***************************************************************************************

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PaypointDemo.Models
{
    /// <summary>
    /// This class provides the model to and from the index page
    /// </summary>
    public class IndexModel
    {
        /// <summary>
        /// This takes a string of integer values from the user
        /// </summary>
        [Display(Name="Input Values to Sort")]
        public string InputValues { get; set; }

        /// <summary>
        /// A list of Numeric values in decending order supplied from the server
        /// </summary>
        public List<int> SortedValues { get; set; }
    }
}