using System;
using System.Diagnostics;

namespace MisalignedSpace {
    class Misaligned {

        #region Main Method
        static void Main()
        {
            var majorColors = GetMajorColors();
            var minorColors = GetMinorColors();
            int result = PrintColorMap(majorColors,minorColors);
            Debug.Assert(result == 25);
            Debug.Assert(majorColors.Length == 5);
            Debug.Assert(minorColors.Length == 5);
            Console.WriteLine("All is well (maybe!)");
        }
        #endregion

        #region private methods

        /// <summary>
        /// Prints Color Map
        /// </summary>
        /// <returns></returns>
        private static int PrintColorMap(string [] majorColors ,string[] minorColors) {
       
            return PrintMinorAndMajorColorMap(majorColors, minorColors);
        }

        /// <summary>
        /// Print Minor And Major Color Map
        /// </summary>
        /// <param name="majorColors"></param>
        /// <param name="minorColors"></param>
        /// <returns></returns>
        private static int PrintMinorAndMajorColorMap(string[] majorColors, string[] minorColors)
        {
            int i, j = 0;
            for (i = 0; i < majorColors.Length; i++)
            {
                for (j = 0; j < minorColors.Length; j++)
                {
                    Console.WriteLine("{0} | {1} | {2}", i * 5 + j, majorColors[i], minorColors[j]);
                }
            }
            return i * j;
        }

        /// <summary>
        /// Sets Minor Colors
        /// </summary>
        /// <returns></returns>
        private static string[] GetMinorColors()
        {
            string[] minorColors = {"Blue", "Orange", "Green", "Brown", "Slate"};
            return minorColors;
        }

        /// <summary>
        /// Gets Major Colors
        /// </summary>
        /// <returns></returns>
        private static string[] GetMajorColors()
        {
            string[] majorColors = {"White", "Red", "Black", "Yellow", "Violet"};
            return majorColors;
        }

        #endregion

    }
}
