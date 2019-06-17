using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using int8_t = System.SByte;
using uint8_t = System.Byte;
using int16_t = System.Int16;
using uint16_t = System.UInt16;
using int32_t = System.Int32;
using uint32_t = System.UInt32;
using int64_t = System.Int64;
using uint64_t = System.UInt64;

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
            Application.Run(new machineLearning2());
        }
    }
}
