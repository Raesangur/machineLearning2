using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using stdint;

namespace machineLearning2
{
    #region enums
    public enum LogLevel_t { info, warning, error };
    #endregion


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            stdintTest();
            Application.Run(new machineLearning2());
        }


        static void stdintTest()
        {
            int8_t int8 = new int8_t();
            uint8_t uint8 = new uint8_t();
            int16_t int16 = new int16_t();
            uint16_t uint16 = new uint16_t();
            int32_t int32 = new int32_t();
            uint32_t uint32 = new uint32_t();
            int64_t int64 = new int64_t();
            uint64_t uint64 = new uint64_t();

            Console.WriteLine(int8.ToString());
            Console.WriteLine(uint8.ToString());
            Console.WriteLine(int16.ToString());
            Console.WriteLine(uint16.ToString());
            Console.WriteLine(int32.ToString());
            Console.WriteLine(uint32.ToString());
            Console.WriteLine(int64.ToString());
            Console.WriteLine(uint64.ToString());



            int8 = 255;
            uint8 = int8;
            Console.WriteLine(int8.ToString());
            Console.WriteLine(uint8.ToString());

            int8++;
            Console.WriteLine(int8.ToString());

            int8 = 10;
            int8 += int8;
            Console.WriteLine(int8.ToString());

            uint8++;
            Console.WriteLine(uint8.ToString());

            uint8 = 100;
            uint8 += uint8;
            Console.WriteLine(uint8.ToString());



            int16 = 65535;
            uint16 = 65535;
            Console.WriteLine(int16.ToString());
            Console.WriteLine(uint16.ToString());

            int16++;
            Console.WriteLine(int16.ToString());

            int16 = 300;
            int16 += int16;
            int16 += int8 + uint8;
            Console.WriteLine(int16.ToString());

            uint16++;
            Console.WriteLine(uint16.ToString());

            uint16 = int16 * 2;
            Console.WriteLine(uint16.ToString());

            Console.ReadKey();
        }
    }
}
