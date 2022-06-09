using System;
using System.Diagnostics;

namespace AlerterSpace {
    class Alerter {

        /// <summary>
        /// The alert failure count
        /// </summary>
        static int alertFailureCount = 0;

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            alertInCelcius(400.5f);
            alertInCelcius(303.6f);
            alertInCelcius(87.5f);
            var status1 = networkAlertStub(45);
            var status2 = networkAlertStub(85);
            Debug.Assert(alertFailureCount == 3);
            Debug.Assert(status1 == 200);
            Debug.Assert(status2 == 500);
            Console.WriteLine("{0} alerts failed.", alertFailureCount);
            Console.WriteLine("All is well (maybe!)\n");
        }

        /// <summary>
        /// Networks the alert stub.
        /// </summary>
        /// <param name="celcius">The celcius.</param>
        /// <returns></returns>
        static int networkAlertStub(float celcius) {
            Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
            if (celcius > 41 && celcius < 65)
            {
                return 200;
            }
            return 500;
        }

        /// <summary>
        /// Alerts the in celcius.
        /// </summary>
        /// <param name="farenheit">The farenheit.</param>
        static void alertInCelcius(float farenheit) {
            float celcius = ConvertFarenheitToCelcius(farenheit);
            int returnCode = networkAlertStub(celcius);
            if (returnCode != 200) {
                alertFailureCount += 1;
            }
        }

     
        /// <summary>
        /// Converts the farenheit to celcius.
        /// </summary>
        /// <param name="farenheit">The farenheit.</param>
        /// <returns></returns>
        private static float ConvertFarenheitToCelcius(float farenheit)
        {
            return (farenheit - 32) * 5 / 9;
        }
    }
}
