using System;
using System.Diagnostics;

namespace TshirtSpace {
    class Tshirt {

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Debug.Assert(Size(37) == "S");
            Debug.Assert(Size(40) == "M");
            Debug.Assert(Size(43) == "L");
            Debug.Assert(Size(38) == "M");
            Console.WriteLine("All is well (maybe!)");
        }

        /// <summary>
        /// Sizes the specified CMS.
        /// </summary>
        /// <param name="cms">The CMS.</param>
        /// <returns></returns>
        static string Size(int cms) {
            if(cms < 38) {
                return "S";
            } else if(cms >= 38 && cms < 42) {
                return "M";
            } else {
                return "L";
            }
        }
      
      
    }
}
