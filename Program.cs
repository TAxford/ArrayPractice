using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] oStates = new string[3];

            oStates[0] = "Ohio";
            oStates[1] = "Oklahoma";
            oStates[2] = "Oregon";

            //Console.WriteLine("{0}, {1}, {2}", oStates[0], oStates[1], oStates[2]);

            int[] temperatureNow = new int[3];
            temperatureNow[0] = 54;
            temperatureNow[1] = 46;
            temperatureNow[2] = 47;

            //Console.WriteLine("{0}, {1}, {2}", temperatureNow[0], temperatureNow[1], temperatureNow[2]);

            Console.WriteLine("At 2013 on 22 Jan 2018, the following tempertures were set for the states beginnig with the letter O " + oStates[0] + " " + temperatureNow[0] + " " + oStates[1] + " " + temperatureNow[1] + " " + oStates[2] + " " + temperatureNow[2]);

        }
    }
}
