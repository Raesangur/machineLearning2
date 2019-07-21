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
            Console.WriteLine("Begin stdint test");

            int8_t int8 = new int8_t(50);
            uint8_t uint8 = new uint8_t(50);
            int16_t int16 = new int16_t(50);
            uint16_t uint16 = new uint16_t(50);
            int32_t int32 = new int32_t(50);
            uint32_t uint32 = new uint32_t(50);
            int64_t int64 = new int64_t(50);
            uint64_t uint64 = new uint64_t(50);

            byte value = new byte();
            value = 50;

            Console.WriteLine(int8.ToString());
            Console.WriteLine(uint8.ToString());
            Console.WriteLine(int16.ToString());
            Console.WriteLine(uint16.ToString());
            Console.WriteLine(int32.ToString());
            Console.WriteLine(uint32.ToString());
            Console.WriteLine(int64.ToString());
            Console.WriteLine(uint64.ToString());


            // 50 / 2 = 25
            Console.WriteLine("50 / 2 = 25");
            value /= 2;
            int8 /= 2;
            uint8 /= 2;
            int16 /= 2;
            uint16 /= 2;
            int32 /= 2;
            uint32 /= 2;
            int64 /= 2;
            uint64 /= 2;

            Console.WriteLine(int8.ToString());
            Console.WriteLine(uint8.ToString());
            Console.WriteLine(int16.ToString());
            Console.WriteLine(uint16.ToString());
            Console.WriteLine(int32.ToString());
            Console.WriteLine(uint32.ToString());
            Console.WriteLine(int64.ToString());
            Console.WriteLine(uint64.ToString());


            // 25 / 2 = 12.5 -> 12
            Console.WriteLine("25 / 2 = 12.5 -> 12");
            value /= 2;
            int8 /= 2;
            uint8 /= 2;
            int16 /= 2;
            uint16 /= 2;
            int32 /= 2;
            uint32 /= 2;
            int64 /= 2;
            uint64 /= 2;

            Console.WriteLine(int8.ToString());
            Console.WriteLine(uint8.ToString());
            Console.WriteLine(int16.ToString());
            Console.WriteLine(uint16.ToString());
            Console.WriteLine(int32.ToString());
            Console.WriteLine(uint32.ToString());
            Console.WriteLine(int64.ToString());
            Console.WriteLine(uint64.ToString());


            // 12 * 8 = 96
            Console.WriteLine("12 * 8 = 96");
            value *= 2;
            int8 *= 2;
            uint8 *= 2;
            int16 *= 2;
            uint16 *= 2;
            int32 *= 2;
            uint32 *= 2;
            int64 *= 2;
            uint64 *= 2;

            Console.WriteLine(int8.ToString());
            Console.WriteLine(uint8.ToString());
            Console.WriteLine(int16.ToString());
            Console.WriteLine(uint16.ToString());
            Console.WriteLine(int32.ToString());
            Console.WriteLine(uint32.ToString());
            Console.WriteLine(int64.ToString());
            Console.WriteLine(uint64.ToString());


            // 96 + 4 = 100
            Console.WriteLine("96 + 4 = 100");
            value += 4;
            int8 += 4;
            uint8 += 4;
            int16 += 4;
            uint16 += 4;
            int32 += 4;
            uint32 += 4;
            int64 += 4;
            uint64 += 4;

            Console.WriteLine(int8.ToString());
            Console.WriteLine(uint8.ToString());
            Console.WriteLine(int16.ToString());
            Console.WriteLine(uint16.ToString());
            Console.WriteLine(int32.ToString());
            Console.WriteLine(uint32.ToString());
            Console.WriteLine(int64.ToString());
            Console.WriteLine(uint64.ToString());


            // 100 - 50 = 50
            Console.WriteLine("100 - 50 = 50");
            value -= 50;
            int8 -= 50;
            uint8 -= 50;
            int16 -= 50;
            uint16 -= 50;
            int32 -= 50;
            uint32 -= 50;
            int64 -= 50;
            uint64 -= 50;

            Console.WriteLine(int8.ToString());
            Console.WriteLine(uint8.ToString());
            Console.WriteLine(int16.ToString());
            Console.WriteLine(uint16.ToString());
            Console.WriteLine(int32.ToString());
            Console.WriteLine(uint32.ToString());
            Console.WriteLine(int64.ToString());
            Console.WriteLine(uint64.ToString());


            // 50 % 15 = 5
            Console.WriteLine("50 % 15 = 5");
            value %= 15;
            int8 %= 15;
            uint8 %= 15;
            int16 %= 15;
            uint16 %= 15;
            int32 %= 15;
            uint32 %= 15;
            int64 %= 15;
            uint64 %= 15;

            Console.WriteLine(int8.ToString());
            Console.WriteLine(uint8.ToString());
            Console.WriteLine(int16.ToString());
            Console.WriteLine(uint16.ToString());
            Console.WriteLine(int32.ToString());
            Console.WriteLine(uint32.ToString());
            Console.WriteLine(int64.ToString());
            Console.WriteLine(uint64.ToString());


            // 5 & 4 = 4
            Console.WriteLine("5 & 4 = 4     101 & 100 = 100");
            value &= 4;
            int8 &= 4;
            uint8 &= 4;
            int16 &= 4;
            uint16 &= 4;
            int32 &= 4;
            uint32 &= 4;
            int64 &= 4;
            uint64 &= 4;

            Console.WriteLine(int8.ToString());
            Console.WriteLine(uint8.ToString());
            Console.WriteLine(int16.ToString());
            Console.WriteLine(uint16.ToString());
            Console.WriteLine(int32.ToString());
            Console.WriteLine(uint32.ToString());
            Console.WriteLine(int64.ToString());
            Console.WriteLine(uint64.ToString());

            // 4 | 3 = 7
            Console.WriteLine("4 | 3 = 7     100 | 011 = 111");
            value |= 3;
            int8 |= 3;
            uint8 |= 3;
            int16 |= 3;
            uint16 |= 3;
            int32 |= 3;
            uint32 |= 3;
            int64 |= 3;
            uint64 |= 3;

            Console.WriteLine(int8.ToString());
            Console.WriteLine(uint8.ToString());
            Console.WriteLine(int16.ToString());
            Console.WriteLine(uint16.ToString());
            Console.WriteLine(int32.ToString());
            Console.WriteLine(uint32.ToString());
            Console.WriteLine(int64.ToString());
            Console.WriteLine(uint64.ToString());


            // 7 ^ 9 = 14
            Console.WriteLine("7 ^ 9 = 14     0111 ^ 1001 = 1110");
            value ^= 9;
            int8 ^= 9;
            uint8 ^= 9;
            int16 ^= 9;
            uint16 ^= 9;
            int32 ^= 9;
            uint32 ^= 9;
            int64 ^= 9;
            uint64 ^= 9;

            Console.WriteLine(int8.ToString());
            Console.WriteLine(uint8.ToString());
            Console.WriteLine(int16.ToString());
            Console.WriteLine(uint16.ToString());
            Console.WriteLine(int32.ToString());
            Console.WriteLine(uint32.ToString());
            Console.WriteLine(int64.ToString());
            Console.WriteLine(uint64.ToString());




            Console.ReadKey();
        }
    }
}
