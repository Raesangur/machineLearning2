using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machineLearning2
{
    /****************************** int8_t ***********************************/
    class int8_t
    {
        public SByte var
        {
            get
            {
                return var;
            }
            set
            {
                var = value;
            }
        }
        #region Constructors
        public int8_t() { var = 0; }
        public int8_t(byte value) { var = (SByte)value; }
        public int8_t(SByte value) { var = value; }
        public int8_t(Int16 value) { var = (SByte)value; }
        public int8_t(UInt16 value) { var = (SByte)value; }
        public int8_t(int value) { var = (SByte)value; }
        public int8_t(UInt32 value) { var = (SByte)value; }
        public int8_t(Int64 value) { var = (SByte)value; }
        public int8_t(UInt64 value) { var = (SByte)value; }
        public int8_t(int8_t value) { var = value.var; }
        public int8_t(uint8_t value) { var = (SByte)value.var; }
        public int8_t(int16_t value) { var = (SByte)value.var; }
        public int8_t(uint16_t value) { var = (SByte)value.var; }
        public int8_t(int32_t value) { var = (SByte)value.var; }
        public int8_t(uint32_t value) { var = (SByte)value.var; }
        public int8_t(int64_t value) { var = (SByte)value.var; }
        public int8_t(uint64_t value) { var = (SByte)value.var; }
        #endregion

        #region int8_t
        /* Math */
        public static int8_t operator +(int8_t var1, int8_t var2)       /* + */
        {
            int8_t result = new int8_t((SByte)(var1.var + var2.var));
            return result;
        }
        public static int8_t operator ++(int8_t var1)                   /* ++ */
        {
            var1.var++;
            return var1;
        }
        public static int8_t operator -(int8_t var1, int8_t var2)       /* - */
        {
            int8_t result = new int8_t((SByte)(var1.var - var2.var));
            return result;
        }
        public static int8_t operator --(int8_t var1)                   /* -- */
        {
            var1.var--;
            return var1;
        }
        public static int8_t operator *(int8_t var1, int8_t var2)       /* * */
        {
            int8_t result = new int8_t((SByte)var1.var * var2.var);
            return result;
        }
        public static int8_t operator /(int8_t var1, int8_t var2)       /* / */
        {
            int8_t result = new int8_t((SByte)var1.var / var2.var);
            return result;
        }
        public static int8_t operator %(int8_t var1, int8_t var2)       /* % */
        {
            int8_t result = new int8_t((SByte)var1.var % var2.var);
            return result;
        }
        public static int8_t operator &(int8_t var1, int8_t var2)       /* & */
        {
            int8_t result = new int8_t((SByte)var1.var & var2.var);
            return result;
        }
        public static int8_t operator |(int8_t var1, int8_t var2)       /* | */
        {
            int8_t result = new int8_t(var1.var | var2.var);
            return result;
        }
        public static int8_t operator ^(int8_t var1, int8_t var2)       /* ^ */
        {
            int8_t result = new int8_t((SByte)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int8_t var1, int8_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, int8_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, int8_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, int8_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, int8_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, int8_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Math */
        public static int8_t operator +(int8_t var1, uint8_t var2)       /* + */
        {
            int8_t result = new int8_t((SByte)(var1.var + var2.var));
            return result;
        }
        public static int8_t operator -(int8_t var1, uint8_t var2)       /* - */
        {
            int8_t result = new int8_t((SByte)(var1.var - var2.var));
            return result;
        }
        public static int8_t operator *(int8_t var1, uint8_t var2)       /* * */
        {
            int8_t result = new int8_t((SByte)var1.var * var2.var);
            return result;
        }
        public static int8_t operator /(int8_t var1, uint8_t var2)       /* / */
        {
            int8_t result = new int8_t((SByte)var1.var / var2.var);
            return result;
        }
        public static int8_t operator %(int8_t var1, uint8_t var2)       /* % */
        {
            int8_t result = new int8_t((SByte)var1.var % var2.var);
            return result;
        }
        public static int8_t operator &(int8_t var1, uint8_t var2)       /* & */
        {
            int8_t result = new int8_t((SByte)var1.var & var2.var);
            return result;
        }
        public static int8_t operator |(int8_t var1, uint8_t var2)       /* | */
        {
            int8_t result = new int8_t((SByte)var1.var | (SByte)var2.var);
            return result;
        }
        public static int8_t operator ^(int8_t var1, uint8_t var2)       /* ^ */
        {
            int8_t result = new int8_t((SByte)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int8_t var1, uint8_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, uint8_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, uint8_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, uint8_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, uint8_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, uint8_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        /* Math */
        public static int8_t operator +(int8_t var1, int16_t var2)       /* + */
        {
            int8_t result = new int8_t((SByte)(var1.var + var2.var));
            return result;
        }
        public static int8_t operator -(int8_t var1, int16_t var2)       /* - */
        {
            int8_t result = new int8_t((SByte)(var1.var - var2.var));
            return result;
        }
        public static int8_t operator *(int8_t var1, int16_t var2)       /* * */
        {
            int8_t result = new int8_t((SByte)var1.var * var2.var);
            return result;
        }
        public static int8_t operator /(int8_t var1, int16_t var2)       /* / */
        {
            int8_t result = new int8_t((SByte)var1.var / var2.var);
            return result;
        }
        public static int8_t operator %(int8_t var1, int16_t var2)       /* % */
        {
            int8_t result = new int8_t((SByte)var1.var % var2.var);
            return result;
        }
        public static int8_t operator &(int8_t var1, int16_t var2)       /* & */
        {
            int8_t result = new int8_t((SByte)var1.var & var2.var);
            return result;
        }
        public static int8_t operator |(int8_t var1, int16_t var2)       /* | */
        {
            int8_t result = new int8_t((SByte)var1.var | (SByte)var2.var);
            return result;
        }
        public static int8_t operator ^(int8_t var1, int16_t var2)       /* ^ */
        {
            int8_t result = new int8_t((SByte)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int8_t var1, int16_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, int16_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, int16_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, int16_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, int16_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, int16_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        public static int8_t operator +(int8_t var1, uint16_t var2)       /* + */
        {
            int8_t result = new int8_t((SByte)(var1.var + var2.var));
            return result;
        }
        public static int8_t operator -(int8_t var1, uint16_t var2)       /* - */
        {
            int8_t result = new int8_t((SByte)(var1.var - var2.var));
            return result;
        }
        public static int8_t operator *(int8_t var1, uint16_t var2)       /* * */
        {
            int8_t result = new int8_t((SByte)var1.var * var2.var);
            return result;
        }
        public static int8_t operator /(int8_t var1, uint16_t var2)       /* / */
        {
            int8_t result = new int8_t((SByte)var1.var / var2.var);
            return result;
        }
        public static int8_t operator %(int8_t var1, uint16_t var2)       /* % */
        {
            int8_t result = new int8_t((SByte)var1.var % var2.var);
            return result;
        }
        public static int8_t operator &(int8_t var1, uint16_t var2)       /* & */
        {
            int8_t result = new int8_t((SByte)var1.var & var2.var);
            return result;
        }
        public static int8_t operator |(int8_t var1, uint16_t var2)       /* | */
        {
            int8_t result = new int8_t((SByte)var1.var | (SByte)var2.var);
            return result;
        }
        public static int8_t operator ^(int8_t var1, uint16_t var2)       /* ^ */
        {
            int8_t result = new int8_t((SByte)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int8_t var1, uint16_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, uint16_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, uint16_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, uint16_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, uint16_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, uint16_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        public static int8_t operator +(int8_t var1, int32_t var2)       /* + */
        {
            int8_t result = new int8_t((SByte)(var1.var + var2.var));
            return result;
        }
        public static int8_t operator -(int8_t var1, int32_t var2)       /* - */
        {
            int8_t result = new int8_t((SByte)(var1.var - var2.var));
            return result;
        }
        public static int8_t operator *(int8_t var1, int32_t var2)       /* * */
        {
            int8_t result = new int8_t((SByte)var1.var * var2.var);
            return result;
        }
        public static int8_t operator /(int8_t var1, int32_t var2)       /* / */
        {
            int8_t result = new int8_t((SByte)var1.var / var2.var);
            return result;
        }
        public static int8_t operator %(int8_t var1, int32_t var2)       /* % */
        {
            int8_t result = new int8_t((SByte)var1.var % var2.var);
            return result;
        }
        public static int8_t operator &(int8_t var1, int32_t var2)       /* & */
        {
            int8_t result = new int8_t((SByte)var1.var & var2.var);
            return result;
        }
        public static int8_t operator |(int8_t var1, int32_t var2)       /* | */
        {
            int8_t result = new int8_t((SByte)var1.var | (SByte)var2.var);
            return result;
        }
        public static int8_t operator ^(int8_t var1, int32_t var2)       /* ^ */
        {
            int8_t result = new int8_t((SByte)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int8_t var1, int32_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, int32_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, int32_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, int32_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, int32_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, int32_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        public static int8_t operator +(int8_t var1, uint32_t var2)       /* + */
        {
            int8_t result = new int8_t((SByte)(var1.var + var2.var));
            return result;
        }
        public static int8_t operator -(int8_t var1, uint32_t var2)       /* - */
        {
            int8_t result = new int8_t((SByte)(var1.var - var2.var));
            return result;
        }
        public static int8_t operator *(int8_t var1, uint32_t var2)       /* * */
        {
            int8_t result = new int8_t((SByte)var1.var * var2.var);
            return result;
        }
        public static int8_t operator /(int8_t var1, uint32_t var2)       /* / */
        {
            int8_t result = new int8_t((SByte)var1.var / var2.var);
            return result;
        }
        public static int8_t operator %(int8_t var1, uint32_t var2)       /* % */
        {
            int8_t result = new int8_t((SByte)var1.var % var2.var);
            return result;
        }
        public static int8_t operator &(int8_t var1, uint32_t var2)       /* & */
        {
            int8_t result = new int8_t((SByte)var1.var & var2.var);
            return result;
        }
        public static int8_t operator |(int8_t var1, uint32_t var2)       /* | */
        {
            int8_t result = new int8_t((SByte)var1.var | (SByte)var2.var);
            return result;
        }
        public static int8_t operator ^(int8_t var1, uint32_t var2)       /* ^ */
        {
            int8_t result = new int8_t((SByte)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int8_t var1, uint32_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, uint32_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, uint32_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, uint32_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, uint32_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, uint32_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        public static int8_t operator +(int8_t var1, int64_t var2)       /* + */
        {
            int8_t result = new int8_t((SByte)(var1.var + var2.var));
            return result;
        }
        public static int8_t operator -(int8_t var1, int64_t var2)       /* - */
        {
            int8_t result = new int8_t((SByte)(var1.var - var2.var));
            return result;
        }
        public static int8_t operator *(int8_t var1, int64_t var2)       /* * */
        {
            int8_t result = new int8_t((SByte)var1.var * var2.var);
            return result;
        }
        public static int8_t operator /(int8_t var1, int64_t var2)       /* / */
        {
            int8_t result = new int8_t((SByte)var1.var / var2.var);
            return result;
        }
        public static int8_t operator %(int8_t var1, int64_t var2)       /* % */
        {
            int8_t result = new int8_t((SByte)var1.var % var2.var);
            return result;
        }
        public static int8_t operator &(int8_t var1, int64_t var2)       /* & */
        {
            int8_t result = new int8_t((SByte)var1.var & var2.var);
            return result;
        }
        public static int8_t operator |(int8_t var1, int64_t var2)       /* | */
        {
            int8_t result = new int8_t((SByte)var1.var | (SByte)var2.var);
            return result;
        }
        public static int8_t operator ^(int8_t var1, int64_t var2)       /* ^ */
        {
            int8_t result = new int8_t((SByte)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int8_t var1, int64_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, int64_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, int64_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, int64_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, int64_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, int64_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        public static int8_t operator +(int8_t var1, uint64_t var2)       /* + */
        {
            int8_t result = new int8_t((SByte)(var1.var + (Int64)var2.var));
            return result;
        }
        public static int8_t operator -(int8_t var1, uint64_t var2)       /* - */
        {
            int8_t result = new int8_t((SByte)(var1.var - (Int64)var2.var));
            return result;
        }
        public static int8_t operator *(int8_t var1, uint64_t var2)       /* * */
        {
            int8_t result = new int8_t((SByte)var1.var * (Int64)var2.var);
            return result;
        }
        public static int8_t operator /(int8_t var1, uint64_t var2)       /* / */
        {
            int8_t result = new int8_t((SByte)var1.var / (Int64)var2.var);
            return result;
        }
        public static int8_t operator %(int8_t var1, uint64_t var2)       /* % */
        {
            int8_t result = new int8_t((SByte)var1.var % (Int64)var2.var);
            return result;
        }
        public static int8_t operator &(int8_t var1, uint64_t var2)       /* & */
        {
            int8_t result = new int8_t((SByte)var1.var & (Int64)var2.var);
            return result;
        }
        public static int8_t operator |(int8_t var1, uint64_t var2)       /* | */
        {
            int8_t result = new int8_t((SByte)var1.var | (SByte)var2.var);
            return result;
        }
        public static int8_t operator ^(int8_t var1, uint64_t var2)       /* ^ */
        {
            int8_t result = new int8_t((SByte)var1.var ^ (Int64)var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int8_t var1, uint64_t var2)     /* > */
        {
            return (var1.var > (Int64)var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, uint64_t var2)     /* < */
        {
            return (var1.var < (Int64)var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, uint64_t var2)    /* <= */
        {
            return (var1.var <= (Int64)var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, uint64_t var2)    /* >= */
        {
            return (var1.var >= (Int64)var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, uint64_t var2)    /* == */
        {
            return (var1.var == (Int64)var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, uint64_t var2)    /* > */
        {
            return (var1.var != (Int64)var2.var) ? true : false;
        }
        #endregion
        #region int
        /* Math */
        public static int8_t operator +(int8_t var1, int var2)       /* + */
        {
            int8_t result = new int8_t((SByte)(var1.var + var2));
            return result;
        }
        public static int8_t operator -(int8_t var1, int var2)       /* - */
        {
            int8_t result = new int8_t((SByte)(var1.var - var2));
            return result;
        }
        public static int8_t operator *(int8_t var1, int var2)       /* * */
        {
            int8_t result = new int8_t((SByte)var1.var * var2);
            return result;
        }
        public static int8_t operator /(int8_t var1, int var2)       /* / */
        {
            int8_t result = new int8_t((SByte)var1.var / var2);
            return result;
        }
        public static int8_t operator %(int8_t var1, int var2)       /* % */
        {
            int8_t result = new int8_t((SByte)var1.var % var2);
            return result;
        }
        public static int8_t operator &(int8_t var1, int var2)       /* & */
        {
            int8_t result = new int8_t((SByte)var1.var & var2);
            return result;
        }
        public static int8_t operator |(int8_t var1, int var2)       /* | */
        {
            int8_t result = new int8_t((SByte)var1.var | (SByte)var2);
            return result;
        }
        public static int8_t operator ^(int8_t var1, int var2)       /* ^ */
        {
            int8_t result = new int8_t((SByte)var1.var ^ var2);
            return result;
        }

        /* Comparison */
        public static bool operator >(int8_t var1, int var2)     /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int8_t var1, int var2)     /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int8_t var1, int var2)    /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int8_t var1, int var2)    /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int8_t var1, int var2)    /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int8_t var1, int var2)    /* > */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Math */
        public static int8_t operator +(int8_t var1, byte var2)       /* + */
        {
            int8_t result = new int8_t((SByte)(var1.var + var2));
            return result;
        }
        public static int8_t operator -(int8_t var1, byte var2)       /* - */
        {
            int8_t result = new int8_t((SByte)(var1.var - var2));
            return result;
        }
        public static int8_t operator *(int8_t var1, byte var2)       /* * */
        {
            int8_t result = new int8_t((SByte)var1.var * var2);
            return result;
        }
        public static int8_t operator /(int8_t var1, byte var2)       /* / */
        {
            int8_t result = new int8_t((SByte)var1.var / var2);
            return result;
        }
        public static int8_t operator %(int8_t var1, byte var2)       /* % */
        {
            int8_t result = new int8_t((SByte)var1.var % var2);
            return result;
        }
        public static int8_t operator &(int8_t var1, byte var2)       /* & */
        {
            int8_t result = new int8_t((SByte)var1.var & var2);
            return result;
        }
        public static int8_t operator |(int8_t var1, byte var2)       /* | */
        {
            int8_t result = new int8_t((SByte)var1.var | (SByte)var2);
            return result;
        }
        public static int8_t operator ^(int8_t var1, byte var2)       /* ^ */
        {
            int8_t result = new int8_t((SByte)var1.var ^ var2);
            return result;
        }

        /* Comparison */
        public static bool operator >(int8_t var1, byte var2)     /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int8_t var1, byte var2)     /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int8_t var1, byte var2)    /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int8_t var1, byte var2)    /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int8_t var1, byte var2)    /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int8_t var1, byte var2)    /* > */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region specials
        public override bool Equals(object obj)
        {
            return (obj is int8_t) ? this == (int8_t)obj : false;
        }
        public override int GetHashCode()
        {
            return var;
        }
        public override string ToString()
        {
            return var.ToString();
        }
        #endregion
    }

    /****************************** uint8_t **********************************/
    class uint8_t
    {
        public byte var
        {
            get
            {
                return var;
            }
            set
            {
                var = value;
            }
        }
        #region Constructors
        public uint8_t() { var = 0; }
        public uint8_t(byte value) { var = value; }
        public uint8_t(SByte value) { var = (byte)value; }
        public uint8_t(Int16 value) { var = (byte)value; }
        public uint8_t(UInt16 value) { var = (byte)value; }
        public uint8_t(int value) { var = (byte)value; }
        public uint8_t(UInt32 value) { var = (byte)value; }
        public uint8_t(Int64 value) { var = (byte)value; }
        public uint8_t(UInt64 value) { var = (byte)value; }
        public uint8_t(int8_t value) { var = (byte)value.var; }
        public uint8_t(uint8_t value) { var = value.var; }
        public uint8_t(int16_t value) { var = (byte)value.var; }
        public uint8_t(uint16_t value) { var = (byte)value.var; }
        public uint8_t(int32_t value) { var = (byte)value.var; }
        public uint8_t(uint32_t value) { var = (byte)value.var; }
        public uint8_t(int64_t value) { var = (byte)value.var; }
        public uint8_t(uint64_t value) { var = (byte)value.var; }
        #endregion

        #region int8_t
        /* Math */
        public static uint8_t operator +(uint8_t var1, int8_t var2)       /* + */
        {
            uint8_t result = new uint8_t((byte)(var1.var + var2.var));
            return result;
        }
        public static uint8_t operator -(uint8_t var1, int8_t var2)       /* - */
        {
            uint8_t result = new uint8_t((byte)(var1.var - var2.var));
            return result;
        }
        public static uint8_t operator *(uint8_t var1, int8_t var2)       /* * */
        {
            uint8_t result = new uint8_t((byte)var1.var * var2.var);
            return result;
        }
        public static uint8_t operator /(uint8_t var1, int8_t var2)       /* / */
        {
            uint8_t result = new uint8_t((byte)var1.var / var2.var);
            return result;
        }
        public static uint8_t operator %(uint8_t var1, int8_t var2)       /* % */
        {
            uint8_t result = new uint8_t((byte)var1.var % var2.var);
            return result;
        }
        public static uint8_t operator &(uint8_t var1, int8_t var2)       /* & */
        {
            uint8_t result = new uint8_t((byte)var1.var & var2.var);
            return result;
        }
        public static uint8_t operator |(uint8_t var1, int8_t var2)       /* | */
        {
            uint8_t result = new uint8_t((byte)var1.var | (byte)var2.var);
            return result;
        }
        public static uint8_t operator ^(uint8_t var1, int8_t var2)       /* ^ */
        {
            uint8_t result = new uint8_t((byte)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, int8_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, int8_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, int8_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, int8_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, int8_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, int8_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Math */
        public static uint8_t operator +(uint8_t var1, uint8_t var2)       /* + */
        {
            uint8_t result = new uint8_t((byte)(var1.var + var2.var));
            return result;
        }
        public static uint8_t operator ++(uint8_t var1)                   /* ++ */
        {
            var1.var++;
            return var1;
        }
        public static uint8_t operator -(uint8_t var1, uint8_t var2)       /* - */
        {
            uint8_t result = new uint8_t((byte)(var1.var - var2.var));
            return result;
        }
        public static uint8_t operator --(uint8_t var1)                   /* -- */
        {
            var1.var--;
            return var1;
        }
        public static uint8_t operator *(uint8_t var1, uint8_t var2)       /* * */
        {
            uint8_t result = new uint8_t((byte)var1.var * var2.var);
            return result;
        }
        public static uint8_t operator /(uint8_t var1, uint8_t var2)       /* / */
        {
            uint8_t result = new uint8_t((byte)var1.var / var2.var);
            return result;
        }
        public static uint8_t operator %(uint8_t var1, uint8_t var2)       /* % */
        {
            uint8_t result = new uint8_t((byte)var1.var % var2.var);
            return result;
        }
        public static uint8_t operator &(uint8_t var1, uint8_t var2)       /* & */
        {
            uint8_t result = new uint8_t((byte)var1.var & var2.var);
            return result;
        }
        public static uint8_t operator |(uint8_t var1, uint8_t var2)       /* | */
        {
            uint8_t result = new uint8_t((byte)var1.var | var2.var);
            return result;
        }
        public static uint8_t operator ^(uint8_t var1, uint8_t var2)       /* ^ */
        {
            uint8_t result = new uint8_t((byte)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, uint8_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, uint8_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, uint8_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, uint8_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, uint8_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, uint8_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        /* Math */
        public static uint8_t operator +(uint8_t var1, int16_t var2)       /* + */
        {
            uint8_t result = new uint8_t((byte)(var1.var + var2.var));
            return result;
        }
        public static uint8_t operator -(uint8_t var1, int16_t var2)       /* - */
        {
            uint8_t result = new uint8_t((byte)(var1.var - var2.var));
            return result;
        }
        public static uint8_t operator *(uint8_t var1, int16_t var2)       /* * */
        {
            uint8_t result = new uint8_t((byte)var1.var * var2.var);
            return result;
        }
        public static uint8_t operator /(uint8_t var1, int16_t var2)       /* / */
        {
            uint8_t result = new uint8_t((byte)var1.var / var2.var);
            return result;
        }
        public static uint8_t operator %(uint8_t var1, int16_t var2)       /* % */
        {
            uint8_t result = new uint8_t((byte)var1.var % var2.var);
            return result;
        }
        public static uint8_t operator &(uint8_t var1, int16_t var2)       /* & */
        {
            uint8_t result = new uint8_t((byte)var1.var & var2.var);
            return result;
        }
        public static uint8_t operator |(uint8_t var1, int16_t var2)       /* | */
        {
            uint8_t result = new uint8_t((byte)var1.var | (byte)var2.var);
            return result;
        }
        public static uint8_t operator ^(uint8_t var1, int16_t var2)       /* ^ */
        {
            uint8_t result = new uint8_t((byte)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, int16_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, int16_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, int16_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, int16_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, int16_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, int16_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        /* Math */
        public static uint8_t operator +(uint8_t var1, uint16_t var2)       /* + */
        {
            uint8_t result = new uint8_t((byte)(var1.var + var2.var));
            return result;
        }
        public static uint8_t operator -(uint8_t var1, uint16_t var2)       /* - */
        {
            uint8_t result = new uint8_t((byte)(var1.var - var2.var));
            return result;
        }
        public static uint8_t operator *(uint8_t var1, uint16_t var2)       /* * */
        {
            uint8_t result = new uint8_t((byte)var1.var * var2.var);
            return result;
        }
        public static uint8_t operator /(uint8_t var1, uint16_t var2)       /* / */
        {
            uint8_t result = new uint8_t((byte)var1.var / var2.var);
            return result;
        }
        public static uint8_t operator %(uint8_t var1, uint16_t var2)       /* % */
        {
            uint8_t result = new uint8_t((byte)var1.var % var2.var);
            return result;
        }
        public static uint8_t operator &(uint8_t var1, uint16_t var2)       /* & */
        {
            uint8_t result = new uint8_t((byte)var1.var & var2.var);
            return result;
        }
        public static uint8_t operator |(uint8_t var1, uint16_t var2)       /* | */
        {
            uint8_t result = new uint8_t((byte)var1.var | (byte)var2.var);
            return result;
        }
        public static uint8_t operator ^(uint8_t var1, uint16_t var2)       /* ^ */
        {
            uint8_t result = new uint8_t((byte)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, uint16_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, uint16_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, uint16_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, uint16_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, uint16_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, uint16_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        /* Math */
        public static uint8_t operator +(uint8_t var1, int32_t var2)       /* + */
        {
            uint8_t result = new uint8_t((byte)(var1.var + var2.var));
            return result;
        }
        public static uint8_t operator -(uint8_t var1, int32_t var2)       /* - */
        {
            uint8_t result = new uint8_t((byte)(var1.var - var2.var));
            return result;
        }
        public static uint8_t operator *(uint8_t var1, int32_t var2)       /* * */
        {
            uint8_t result = new uint8_t((byte)var1.var * var2.var);
            return result;
        }
        public static uint8_t operator /(uint8_t var1, int32_t var2)       /* / */
        {
            uint8_t result = new uint8_t((byte)var1.var / var2.var);
            return result;
        }
        public static uint8_t operator %(uint8_t var1, int32_t var2)       /* % */
        {
            uint8_t result = new uint8_t((byte)var1.var % var2.var);
            return result;
        }
        public static uint8_t operator &(uint8_t var1, int32_t var2)       /* & */
        {
            uint8_t result = new uint8_t((byte)var1.var & var2.var);
            return result;
        }
        public static uint8_t operator |(uint8_t var1, int32_t var2)       /* | */
        {
            uint8_t result = new uint8_t((byte)var1.var | (byte)var2.var);
            return result;
        }
        public static uint8_t operator ^(uint8_t var1, int32_t var2)       /* ^ */
        {
            uint8_t result = new uint8_t((byte)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, int32_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, int32_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, int32_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, int32_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, int32_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, int32_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Math */
        public static uint8_t operator +(uint8_t var1, uint32_t var2)       /* + */
        {
            uint8_t result = new uint8_t((byte)(var1.var + var2.var));
            return result;
        }
        public static uint8_t operator -(uint8_t var1, uint32_t var2)       /* - */
        {
            uint8_t result = new uint8_t((byte)(var1.var - var2.var));
            return result;
        }
        public static uint8_t operator *(uint8_t var1, uint32_t var2)       /* * */
        {
            uint8_t result = new uint8_t((byte)var1.var * var2.var);
            return result;
        }
        public static uint8_t operator /(uint8_t var1, uint32_t var2)       /* / */
        {
            uint8_t result = new uint8_t((byte)var1.var / var2.var);
            return result;
        }
        public static uint8_t operator %(uint8_t var1, uint32_t var2)       /* % */
        {
            uint8_t result = new uint8_t((byte)var1.var % var2.var);
            return result;
        }
        public static uint8_t operator &(uint8_t var1, uint32_t var2)       /* & */
        {
            uint8_t result = new uint8_t((byte)var1.var & var2.var);
            return result;
        }
        public static uint8_t operator |(uint8_t var1, uint32_t var2)       /* | */
        {
            uint8_t result = new uint8_t((byte)var1.var | (byte)var2.var);
            return result;
        }
        public static uint8_t operator ^(uint8_t var1, uint32_t var2)       /* ^ */
        {
            uint8_t result = new uint8_t((byte)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, uint32_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, uint32_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, uint32_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, uint32_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, uint32_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, uint32_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        /* Math */
        public static uint8_t operator +(uint8_t var1, int64_t var2)       /* + */
        {
            uint8_t result = new uint8_t((byte)(var1.var + var2.var));
            return result;
        }
        public static uint8_t operator -(uint8_t var1, int64_t var2)       /* - */
        {
            uint8_t result = new uint8_t((byte)(var1.var - var2.var));
            return result;
        }
        public static uint8_t operator *(uint8_t var1, int64_t var2)       /* * */
        {
            uint8_t result = new uint8_t((byte)var1.var * var2.var);
            return result;
        }
        public static uint8_t operator /(uint8_t var1, int64_t var2)       /* / */
        {
            uint8_t result = new uint8_t((byte)var1.var / var2.var);
            return result;
        }
        public static uint8_t operator %(uint8_t var1, int64_t var2)       /* % */
        {
            uint8_t result = new uint8_t((byte)var1.var % var2.var);
            return result;
        }
        public static uint8_t operator &(uint8_t var1, int64_t var2)       /* & */
        {
            uint8_t result = new uint8_t((byte)var1.var & var2.var);
            return result;
        }
        public static uint8_t operator |(uint8_t var1, int64_t var2)       /* | */
        {
            uint8_t result = new uint8_t((byte)var1.var | (byte)var2.var);
            return result;
        }
        public static uint8_t operator ^(uint8_t var1, int64_t var2)       /* ^ */
        {
            uint8_t result = new uint8_t((byte)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, int64_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, int64_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, int64_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, int64_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, int64_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, int64_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        /* Math */
        public static uint8_t operator +(uint8_t var1, uint64_t var2)       /* + */
        {
            uint8_t result = new uint8_t((byte)(var1.var + var2.var));
            return result;
        }
        public static uint8_t operator -(uint8_t var1, uint64_t var2)       /* - */
        {
            uint8_t result = new uint8_t((byte)(var1.var - var2.var));
            return result;
        }
        public static uint8_t operator *(uint8_t var1, uint64_t var2)       /* * */
        {
            uint8_t result = new uint8_t((byte)var1.var * var2.var);
            return result;
        }
        public static uint8_t operator /(uint8_t var1, uint64_t var2)       /* / */
        {
            uint8_t result = new uint8_t((byte)var1.var / var2.var);
            return result;
        }
        public static uint8_t operator %(uint8_t var1, uint64_t var2)       /* % */
        {
            uint8_t result = new uint8_t((byte)var1.var % var2.var);
            return result;
        }
        public static uint8_t operator &(uint8_t var1, uint64_t var2)       /* & */
        {
            uint8_t result = new uint8_t((byte)var1.var & var2.var);
            return result;
        }
        public static uint8_t operator |(uint8_t var1, uint64_t var2)       /* | */
        {
            uint8_t result = new uint8_t((byte)var1.var | (byte)var2.var);
            return result;
        }
        public static uint8_t operator ^(uint8_t var1, uint64_t var2)       /* ^ */
        {
            uint8_t result = new uint8_t((byte)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, uint64_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, uint64_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, uint64_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, uint64_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, uint64_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, uint64_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int
        /* Math */
        public static uint8_t operator +(uint8_t var1, int var2)       /* + */
        {
            uint8_t result = new uint8_t((byte)(var1.var + var2));
            return result;
        }
        public static uint8_t operator -(uint8_t var1, int var2)       /* - */
        {
            uint8_t result = new uint8_t((byte)(var1.var - var2));
            return result;
        }
        public static uint8_t operator *(uint8_t var1, int var2)       /* * */
        {
            uint8_t result = new uint8_t((byte)var1.var * var2);
            return result;
        }
        public static uint8_t operator /(uint8_t var1, int var2)       /* / */
        {
            uint8_t result = new uint8_t((byte)var1.var / var2);
            return result;
        }
        public static uint8_t operator %(uint8_t var1, int var2)       /* % */
        {
            uint8_t result = new uint8_t((byte)var1.var % var2);
            return result;
        }
        public static uint8_t operator &(uint8_t var1, int var2)       /* & */
        {
            uint8_t result = new uint8_t((byte)var1.var & var2);
            return result;
        }
        public static uint8_t operator |(uint8_t var1, int var2)       /* | */
        {
            uint8_t result = new uint8_t((byte)var1.var | var2);
            return result;
        }
        public static uint8_t operator ^(uint8_t var1, int var2)       /* ^ */
        {
            uint8_t result = new uint8_t((byte)var1.var ^ var2);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, int var2)     /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint8_t var1, int var2)     /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint8_t var1, int var2)    /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint8_t var1, int var2)    /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint8_t var1, int var2)    /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint8_t var1, int var2)    /* > */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Math */
        public static uint8_t operator +(uint8_t var1, byte var2)       /* + */
        {
            uint8_t result = new uint8_t((byte)(var1.var + var2));
            return result;
        }
        public static uint8_t operator -(uint8_t var1, byte var2)       /* - */
        {
            uint8_t result = new uint8_t((byte)(var1.var - var2));
            return result;
        }
        public static uint8_t operator *(uint8_t var1, byte var2)       /* * */
        {
            uint8_t result = new uint8_t((byte)var1.var * var2);
            return result;
        }
        public static uint8_t operator /(uint8_t var1, byte var2)       /* / */
        {
            uint8_t result = new uint8_t((byte)var1.var / var2);
            return result;
        }
        public static uint8_t operator %(uint8_t var1, byte var2)       /* % */
        {
            uint8_t result = new uint8_t((byte)var1.var % var2);
            return result;
        }
        public static uint8_t operator &(uint8_t var1, byte var2)       /* & */
        {
            uint8_t result = new uint8_t((byte)var1.var & var2);
            return result;
        }
        public static uint8_t operator |(uint8_t var1, byte var2)       /* | */
        {
            uint8_t result = new uint8_t((byte)var1.var | var2);
            return result;
        }
        public static uint8_t operator ^(uint8_t var1, byte var2)       /* ^ */
        {
            uint8_t result = new uint8_t((byte)var1.var ^ var2);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, byte var2)     /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint8_t var1, byte var2)     /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint8_t var1, byte var2)    /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint8_t var1, byte var2)    /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint8_t var1, byte var2)    /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint8_t var1, byte var2)    /* > */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region specials
        public override bool Equals(object obj)
        {
            return (obj is uint8_t) ? this == (uint8_t)obj : false;
        }
        public override int GetHashCode()
        {
            return var;
        }
        public override string ToString()
        {
            return var.ToString();
        }
        #endregion
    }

    /****************************** int16_t **********************************/
    class int16_t
    {
        public Int16 var
        {
            get
            {
                return var;
            }
            set
            {
                var = value;
            }
        }
        #region Constructors
        public int16_t() { var = 0; }
        public int16_t(byte value) { var = (Int16)value; }
        public int16_t(SByte value) { var = (Int16)value; }
        public int16_t(Int16 value) { var = value; }
        public int16_t(UInt16 value) { var = (Int16)value; }
        public int16_t(int value) { var = (Int16)value; }
        public int16_t(UInt32 value) { var = (Int16)value; }
        public int16_t(Int64 value) { var = (Int16)value; }
        public int16_t(UInt64 value) { var = (Int16)value; }
        public int16_t(int8_t value) { var = (Int16)value.var; }
        public int16_t(uint8_t value) { var = (Int16)value.var; }
        public int16_t(int16_t value) { var = value.var; }
        public int16_t(uint16_t value) { var = (Int16)value.var; }
        public int16_t(int32_t value) { var = (Int16)value.var; }
        public int16_t(uint32_t value) { var = (Int16)value.var; }
        public int16_t(int64_t value) { var = (Int16)value.var; }
        public int16_t(uint64_t value) { var = (Int16)value.var; }
        #endregion

        #region int8_t
        /* Math */
        public static int16_t operator +(int16_t var1, int8_t var2)       /* + */
        {
            int16_t result = new int16_t((Int16)(var1.var + var2.var));
            return result;
        }
        public static int16_t operator -(int16_t var1, int8_t var2)       /* - */
        {
            int16_t result = new int16_t((Int16)(var1.var - var2.var));
            return result;
        }
        public static int16_t operator *(int16_t var1, int8_t var2)       /* * */
        {
            int16_t result = new int16_t((Int16)var1.var * var2.var);
            return result;
        }
        public static int16_t operator /(int16_t var1, int8_t var2)       /* / */
        {
            int16_t result = new int16_t((Int16)var1.var / var2.var);
            return result;
        }
        public static int16_t operator %(int16_t var1, int8_t var2)       /* % */
        {
            int16_t result = new int16_t((Int16)var1.var % var2.var);
            return result;
        }
        public static int16_t operator &(int16_t var1, int8_t var2)       /* & */
        {
            int16_t result = new int16_t((Int16)var1.var & var2.var);
            return result;
        }
        public static int16_t operator |(int16_t var1, int8_t var2)       /* | */
        {
            int16_t result = new int16_t((Int16)var1.var | (Int16)var2.var);
            return result;
        }
        public static int16_t operator ^(int16_t var1, int8_t var2)       /* ^ */
        {
            int16_t result = new int16_t((Int16)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int16_t var1, int8_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, int8_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, int8_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, int8_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, int8_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, int8_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Math */
        public static int16_t operator +(int16_t var1, uint8_t var2)       /* + */
        {
            int16_t result = new int16_t((Int16)(var1.var + var2.var));
            return result;
        }
        public static int16_t operator -(int16_t var1, uint8_t var2)       /* - */
        {
            int16_t result = new int16_t((Int16)(var1.var - var2.var));
            return result;
        }
        public static int16_t operator *(int16_t var1, uint8_t var2)       /* * */
        {
            int16_t result = new int16_t((Int16)var1.var * var2.var);
            return result;
        }
        public static int16_t operator /(int16_t var1, uint8_t var2)       /* / */
        {
            int16_t result = new int16_t((Int16)var1.var / var2.var);
            return result;
        }
        public static int16_t operator %(int16_t var1, uint8_t var2)       /* % */
        {
            int16_t result = new int16_t((Int16)var1.var % var2.var);
            return result;
        }
        public static int16_t operator &(int16_t var1, uint8_t var2)       /* & */
        {
            int16_t result = new int16_t((Int16)var1.var & var2.var);
            return result;
        }
        public static int16_t operator |(int16_t var1, uint8_t var2)       /* | */
        {
            int16_t result = new int16_t((Int16)var1.var | (Int16)var2.var);
            return result;
        }
        public static int16_t operator ^(int16_t var1, uint8_t var2)       /* ^ */
        {
            int16_t result = new int16_t((Int16)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int16_t var1, uint8_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, uint8_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, uint8_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, uint8_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, uint8_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, uint8_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        /* Math */
        public static int16_t operator +(int16_t var1, int16_t var2)       /* + */
        {
            int16_t result = new int16_t((Int16)(var1.var + var2.var));
            return result;
        }
        public static int16_t operator ++(int16_t var1)                   /* ++ */
        {
            var1.var++;
            return var1;
        }
        public static int16_t operator -(int16_t var1, int16_t var2)       /* - */
        {
            int16_t result = new int16_t((Int16)(var1.var - var2.var));
            return result;
        }
        public static int16_t operator --(int16_t var1)                   /* -- */
        {
            var1.var--;
            return var1;
        }
        public static int16_t operator *(int16_t var1, int16_t var2)       /* * */
        {
            int16_t result = new int16_t((Int16)var1.var * var2.var);
            return result;
        }
        public static int16_t operator /(int16_t var1, int16_t var2)       /* / */
        {
            int16_t result = new int16_t((Int16)var1.var / var2.var);
            return result;
        }
        public static int16_t operator %(int16_t var1, int16_t var2)       /* % */
        {
            int16_t result = new int16_t((Int16)var1.var % var2.var);
            return result;
        }
        public static int16_t operator &(int16_t var1, int16_t var2)       /* & */
        {
            int16_t result = new int16_t((Int16)var1.var & var2.var);
            return result;
        }
        public static int16_t operator |(int16_t var1, int16_t var2)       /* | */
        {
            int16_t result = new int16_t(var1.var | var2.var);
            return result;
        }
        public static int16_t operator ^(int16_t var1, int16_t var2)       /* ^ */
        {
            int16_t result = new int16_t((Int16)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int16_t var1, int16_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, int16_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, int16_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, int16_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, int16_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, int16_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        public static int16_t operator +(int16_t var1, uint16_t var2)       /* + */
        {
            int16_t result = new int16_t((Int16)(var1.var + var2.var));
            return result;
        }
        public static int16_t operator -(int16_t var1, uint16_t var2)       /* - */
        {
            int16_t result = new int16_t((Int16)(var1.var - var2.var));
            return result;
        }
        public static int16_t operator *(int16_t var1, uint16_t var2)       /* * */
        {
            int16_t result = new int16_t((Int16)var1.var * var2.var);
            return result;
        }
        public static int16_t operator /(int16_t var1, uint16_t var2)       /* / */
        {
            int16_t result = new int16_t((Int16)var1.var / var2.var);
            return result;
        }
        public static int16_t operator %(int16_t var1, uint16_t var2)       /* % */
        {
            int16_t result = new int16_t((Int16)var1.var % var2.var);
            return result;
        }
        public static int16_t operator &(int16_t var1, uint16_t var2)       /* & */
        {
            int16_t result = new int16_t((Int16)var1.var & var2.var);
            return result;
        }
        public static int16_t operator |(int16_t var1, uint16_t var2)       /* | */
        {
            int16_t result = new int16_t((Int16)var1.var | (Int16)var2.var);
            return result;
        }
        public static int16_t operator ^(int16_t var1, uint16_t var2)       /* ^ */
        {
            int16_t result = new int16_t((Int16)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int16_t var1, uint16_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, uint16_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, uint16_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, uint16_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, uint16_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, uint16_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        public static int16_t operator +(int16_t var1, int32_t var2)       /* + */
        {
            int16_t result = new int16_t((Int16)(var1.var + var2.var));
            return result;
        }
        public static int16_t operator -(int16_t var1, int32_t var2)       /* - */
        {
            int16_t result = new int16_t((Int16)(var1.var - var2.var));
            return result;
        }
        public static int16_t operator *(int16_t var1, int32_t var2)       /* * */
        {
            int16_t result = new int16_t((Int16)var1.var * var2.var);
            return result;
        }
        public static int16_t operator /(int16_t var1, int32_t var2)       /* / */
        {
            int16_t result = new int16_t((Int16)var1.var / var2.var);
            return result;
        }
        public static int16_t operator %(int16_t var1, int32_t var2)       /* % */
        {
            int16_t result = new int16_t((Int16)var1.var % var2.var);
            return result;
        }
        public static int16_t operator &(int16_t var1, int32_t var2)       /* & */
        {
            int16_t result = new int16_t((Int16)var1.var & var2.var);
            return result;
        }
        public static int16_t operator |(int16_t var1, int32_t var2)       /* | */
        {
            int16_t result = new int16_t((Int16)var1.var | (Int16)var2.var);
            return result;
        }
        public static int16_t operator ^(int16_t var1, int32_t var2)       /* ^ */
        {
            int16_t result = new int16_t((Int16)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int16_t var1, int32_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, int32_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, int32_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, int32_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, int32_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, int32_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        public static int16_t operator +(int16_t var1, uint32_t var2)       /* + */
        {
            int16_t result = new int16_t((Int16)(var1.var + var2.var));
            return result;
        }
        public static int16_t operator -(int16_t var1, uint32_t var2)       /* - */
        {
            int16_t result = new int16_t((Int16)(var1.var - var2.var));
            return result;
        }
        public static int16_t operator *(int16_t var1, uint32_t var2)       /* * */
        {
            int16_t result = new int16_t((Int16)var1.var * var2.var);
            return result;
        }
        public static int16_t operator /(int16_t var1, uint32_t var2)       /* / */
        {
            int16_t result = new int16_t((Int16)var1.var / var2.var);
            return result;
        }
        public static int16_t operator %(int16_t var1, uint32_t var2)       /* % */
        {
            int16_t result = new int16_t((Int16)var1.var % var2.var);
            return result;
        }
        public static int16_t operator &(int16_t var1, uint32_t var2)       /* & */
        {
            int16_t result = new int16_t((Int16)var1.var & var2.var);
            return result;
        }
        public static int16_t operator |(int16_t var1, uint32_t var2)       /* | */
        {
            int16_t result = new int16_t((Int16)var1.var | (Int16)var2.var);
            return result;
        }
        public static int16_t operator ^(int16_t var1, uint32_t var2)       /* ^ */
        {
            int16_t result = new int16_t((Int16)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int16_t var1, uint32_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, uint32_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, uint32_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, uint32_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, uint32_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, uint32_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        public static int16_t operator +(int16_t var1, int64_t var2)       /* + */
        {
            int16_t result = new int16_t((Int16)(var1.var + var2.var));
            return result;
        }
        public static int16_t operator -(int16_t var1, int64_t var2)       /* - */
        {
            int16_t result = new int16_t((Int16)(var1.var - var2.var));
            return result;
        }
        public static int16_t operator *(int16_t var1, int64_t var2)       /* * */
        {
            int16_t result = new int16_t((Int16)var1.var * var2.var);
            return result;
        }
        public static int16_t operator /(int16_t var1, int64_t var2)       /* / */
        {
            int16_t result = new int16_t((Int16)var1.var / var2.var);
            return result;
        }
        public static int16_t operator %(int16_t var1, int64_t var2)       /* % */
        {
            int16_t result = new int16_t((Int16)var1.var % var2.var);
            return result;
        }
        public static int16_t operator &(int16_t var1, int64_t var2)       /* & */
        {
            int16_t result = new int16_t((Int16)var1.var & var2.var);
            return result;
        }
        public static int16_t operator |(int16_t var1, int64_t var2)       /* | */
        {
            int16_t result = new int16_t((Int16)var1.var | (Int16)var2.var);
            return result;
        }
        public static int16_t operator ^(int16_t var1, int64_t var2)       /* ^ */
        {
            int16_t result = new int16_t((Int16)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int16_t var1, int64_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, int64_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, int64_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, int64_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, int64_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, int64_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        public static int16_t operator +(int16_t var1, uint64_t var2)       /* + */
        {
            int16_t result = new int16_t((Int16)(var1.var + (Int64)var2.var));
            return result;
        }
        public static int16_t operator -(int16_t var1, uint64_t var2)       /* - */
        {
            int16_t result = new int16_t((Int16)(var1.var - (Int64)var2.var));
            return result;
        }
        public static int16_t operator *(int16_t var1, uint64_t var2)       /* * */
        {
            int16_t result = new int16_t((Int16)var1.var * (Int64)var2.var);
            return result;
        }
        public static int16_t operator /(int16_t var1, uint64_t var2)       /* / */
        {
            int16_t result = new int16_t((Int16)var1.var / (Int64)var2.var);
            return result;
        }
        public static int16_t operator %(int16_t var1, uint64_t var2)       /* % */
        {
            int16_t result = new int16_t((Int16)var1.var % (Int64)var2.var);
            return result;
        }
        public static int16_t operator &(int16_t var1, uint64_t var2)       /* & */
        {
            int16_t result = new int16_t((Int16)var1.var & (Int64)var2.var);
            return result;
        }
        public static int16_t operator |(int16_t var1, uint64_t var2)       /* | */
        {
            int16_t result = new int16_t((Int16)var1.var | (Int16)var2.var);
            return result;
        }
        public static int16_t operator ^(int16_t var1, uint64_t var2)       /* ^ */
        {
            int16_t result = new int16_t((Int16)var1.var ^ (Int64)var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int16_t var1, uint64_t var2)     /* > */
        {
            return (var1.var > (Int64)var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, uint64_t var2)     /* < */
        {
            return (var1.var < (Int64)var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, uint64_t var2)    /* <= */
        {
            return (var1.var <= (Int64)var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, uint64_t var2)    /* >= */
        {
            return (var1.var >= (Int64)var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, uint64_t var2)    /* == */
        {
            return (var1.var == (Int64)var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, uint64_t var2)    /* > */
        {
            return (var1.var != (Int64)var2.var) ? true : false;
        }
        #endregion
        #region int
        /* Math */
        public static int16_t operator +(int16_t var1, int var2)       /* + */
        {
            int16_t result = new int16_t((Int16)(var1.var + var2));
            return result;
        }
        public static int16_t operator -(int16_t var1, int var2)       /* - */
        {
            int16_t result = new int16_t((Int16)(var1.var - var2));
            return result;
        }
        public static int16_t operator *(int16_t var1, int var2)       /* * */
        {
            int16_t result = new int16_t((Int16)var1.var * var2);
            return result;
        }
        public static int16_t operator /(int16_t var1, int var2)       /* / */
        {
            int16_t result = new int16_t((Int16)var1.var / var2);
            return result;
        }
        public static int16_t operator %(int16_t var1, int var2)       /* % */
        {
            int16_t result = new int16_t((Int16)var1.var % var2);
            return result;
        }
        public static int16_t operator &(int16_t var1, int var2)       /* & */
        {
            int16_t result = new int16_t((Int16)var1.var & var2);
            return result;
        }
        public static int16_t operator |(int16_t var1, int var2)       /* | */
        {
            int16_t result = new int16_t((Int16)var1.var | (Int16)var2);
            return result;
        }
        public static int16_t operator ^(int16_t var1, int var2)       /* ^ */
        {
            int16_t result = new int16_t((Int16)var1.var ^ var2);
            return result;
        }

        /* Comparison */
        public static bool operator >(int16_t var1, int var2)     /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int16_t var1, int var2)     /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int16_t var1, int var2)    /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int16_t var1, int var2)    /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int16_t var1, int var2)    /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int16_t var1, int var2)    /* > */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Math */
        public static int16_t operator +(int16_t var1, byte var2)       /* + */
        {
            int16_t result = new int16_t((Int16)(var1.var + var2));
            return result;
        }
        public static int16_t operator -(int16_t var1, byte var2)       /* - */
        {
            int16_t result = new int16_t((Int16)(var1.var - var2));
            return result;
        }
        public static int16_t operator *(int16_t var1, byte var2)       /* * */
        {
            int16_t result = new int16_t((Int16)var1.var * var2);
            return result;
        }
        public static int16_t operator /(int16_t var1, byte var2)       /* / */
        {
            int16_t result = new int16_t((Int16)var1.var / var2);
            return result;
        }
        public static int16_t operator %(int16_t var1, byte var2)       /* % */
        {
            int16_t result = new int16_t((Int16)var1.var % var2);
            return result;
        }
        public static int16_t operator &(int16_t var1, byte var2)       /* & */
        {
            int16_t result = new int16_t((Int16)var1.var & var2);
            return result;
        }
        public static int16_t operator |(int16_t var1, byte var2)       /* | */
        {
            int16_t result = new int16_t((Int16)var1.var | (Int16)var2);
            return result;
        }
        public static int16_t operator ^(int16_t var1, byte var2)       /* ^ */
        {
            int16_t result = new int16_t((Int16)var1.var ^ var2);
            return result;
        }

        /* Comparison */
        public static bool operator >(int16_t var1, byte var2)     /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int16_t var1, byte var2)     /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int16_t var1, byte var2)    /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int16_t var1, byte var2)    /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int16_t var1, byte var2)    /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int16_t var1, byte var2)    /* > */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region specials
        public override bool Equals(object obj)
        {
            return (obj is int16_t) ? this == (int16_t)obj : false;
        }
        public override int GetHashCode()
        {
            return var;
        }
        public override string ToString()
        {
            return var.ToString();
        }
        #endregion
    }

    /***************************** uint16_t **********************************/
    class uint16_t
    {
        public UInt16 var
        {
            get
            {
                return var;
            }
            set
            {
                var = value;
            }
        }

        #region Constructors
        public uint16_t() { var = 0; }
        public uint16_t(byte value) { var = (UInt16)value; }
        public uint16_t(SByte value) { var = (UInt16)value; }
        public uint16_t(Int16 value) { var = (UInt16)value; }
        public uint16_t(UInt16 value) { var = value; }
        public uint16_t(int value) { var = (UInt16)value; }
        public uint16_t(UInt32 value) { var = (UInt16)value; }
        public uint16_t(Int64 value) { var = (UInt16)value; }
        public uint16_t(UInt64 value) { var = (UInt16)value; }
        public uint16_t(int8_t value) { var = (UInt16)value.var; }
        public uint16_t(uint8_t value) { var = (UInt16)value.var; }
        public uint16_t(int16_t value) { var = (UInt16)value.var; }
        public uint16_t(uint16_t value) { var = value.var; }
        public uint16_t(int32_t value) { var = (UInt16)value.var; }
        public uint16_t(uint32_t value) { var = (UInt16)value.var; }
        public uint16_t(int64_t value) { var = (UInt16)value.var; }
        public uint16_t(uint64_t value) { var = (UInt16)value.var; }
        #endregion

        #region int8_t
        /* Math */
        public static uint16_t operator +(uint16_t var1, int8_t var2)       /* + */
        {
            uint16_t result = new uint16_t((UInt16)(var1.var + var2.var));
            return result;
        }
        public static uint16_t operator -(uint16_t var1, int8_t var2)       /* - */
        {
            uint16_t result = new uint16_t((UInt16)(var1.var - var2.var));
            return result;
        }
        public static uint16_t operator *(uint16_t var1, int8_t var2)       /* * */
        {
            uint16_t result = new uint16_t((UInt16)var1.var * var2.var);
            return result;
        }
        public static uint16_t operator /(uint16_t var1, int8_t var2)       /* / */
        {
            uint16_t result = new uint16_t((UInt16)var1.var / var2.var);
            return result;
        }
        public static uint16_t operator %(uint16_t var1, int8_t var2)       /* % */
        {
            uint16_t result = new uint16_t((UInt16)var1.var % var2.var);
            return result;
        }
        public static uint16_t operator &(uint16_t var1, int8_t var2)       /* & */
        {
            uint16_t result = new uint16_t((UInt16)var1.var & var2.var);
            return result;
        }
        public static uint16_t operator |(uint16_t var1, int8_t var2)       /* | */
        {
            uint16_t result = new uint16_t((UInt16)var1.var | (UInt16)(byte)var2.var);
            return result;
        }
        public static uint16_t operator ^(uint16_t var1, int8_t var2)       /* ^ */
        {
            uint16_t result = new uint16_t((UInt16)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, int8_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, int8_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, int8_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, int8_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, int8_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, int8_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Math */
        public static uint16_t operator +(uint16_t var1, uint8_t var2)       /* + */
        {
            uint16_t result = new uint16_t((UInt16)(var1.var + var2.var));
            return result;
        }
        public static uint16_t operator -(uint16_t var1, uint8_t var2)       /* - */
        {
            uint16_t result = new uint16_t((UInt16)(var1.var - var2.var));
            return result;
        }
        public static uint16_t operator *(uint16_t var1, uint8_t var2)       /* * */
        {
            uint16_t result = new uint16_t((UInt16)var1.var * var2.var);
            return result;
        }
        public static uint16_t operator /(uint16_t var1, uint8_t var2)       /* / */
        {
            uint16_t result = new uint16_t((UInt16)var1.var / var2.var);
            return result;
        }
        public static uint16_t operator %(uint16_t var1, uint8_t var2)       /* % */
        {
            uint16_t result = new uint16_t((UInt16)var1.var % var2.var);
            return result;
        }
        public static uint16_t operator &(uint16_t var1, uint8_t var2)       /* & */
        {
            uint16_t result = new uint16_t((UInt16)var1.var & var2.var);
            return result;
        }
        public static uint16_t operator |(uint16_t var1, uint8_t var2)       /* | */
        {
            uint16_t result = new uint16_t((UInt16)var1.var | (UInt16)var2.var);
            return result;
        }
        public static uint16_t operator ^(uint16_t var1, uint8_t var2)       /* ^ */
        {
            uint16_t result = new uint16_t((UInt16)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, uint8_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, uint8_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, uint8_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, uint8_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, uint8_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, uint8_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        /* Math */
        public static uint16_t operator +(uint16_t var1, int16_t var2)       /* + */
        {
            uint16_t result = new uint16_t((UInt16)(var1.var + var2.var));
            return result;
        }
        public static uint16_t operator -(uint16_t var1, int16_t var2)       /* - */
        {
            uint16_t result = new uint16_t((UInt16)(var1.var - var2.var));
            return result;
        }
        public static uint16_t operator *(uint16_t var1, int16_t var2)       /* * */
        {
            uint16_t result = new uint16_t((UInt16)var1.var * var2.var);
            return result;
        }
        public static uint16_t operator /(uint16_t var1, int16_t var2)       /* / */
        {
            uint16_t result = new uint16_t((UInt16)var1.var / var2.var);
            return result;
        }
        public static uint16_t operator %(uint16_t var1, int16_t var2)       /* % */
        {
            uint16_t result = new uint16_t((UInt16)var1.var % var2.var);
            return result;
        }
        public static uint16_t operator &(uint16_t var1, int16_t var2)       /* & */
        {
            uint16_t result = new uint16_t((UInt16)var1.var & var2.var);
            return result;
        }
        public static uint16_t operator |(uint16_t var1, int16_t var2)       /* | */
        {
            uint16_t result = new uint16_t((UInt16)var1.var | (UInt16)var2.var);
            return result;
        }
        public static uint16_t operator ^(uint16_t var1, int16_t var2)       /* ^ */
        {
            uint16_t result = new uint16_t((UInt16)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, int16_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, int16_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, int16_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, int16_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, int16_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, int16_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        /* Math */
        public static uint16_t operator +(uint16_t var1, uint16_t var2)       /* + */
        {
            uint16_t result = new uint16_t((UInt16)(var1.var + var2.var));
            return result;
        }
        public static uint16_t operator ++(uint16_t var1)                   /* ++ */
        {
            var1.var++;
            return var1;
        }
        public static uint16_t operator -(uint16_t var1, uint16_t var2)       /* - */
        {
            uint16_t result = new uint16_t((UInt16)(var1.var - var2.var));
            return result;
        }
        public static uint16_t operator --(uint16_t var1)                   /* -- */
        {
            var1.var--;
            return var1;
        }
        public static uint16_t operator *(uint16_t var1, uint16_t var2)       /* * */
        {
            uint16_t result = new uint16_t((UInt16)var1.var * var2.var);
            return result;
        }
        public static uint16_t operator /(uint16_t var1, uint16_t var2)       /* / */
        {
            uint16_t result = new uint16_t((UInt16)var1.var / var2.var);
            return result;
        }
        public static uint16_t operator %(uint16_t var1, uint16_t var2)       /* % */
        {
            uint16_t result = new uint16_t((UInt16)var1.var % var2.var);
            return result;
        }
        public static uint16_t operator &(uint16_t var1, uint16_t var2)       /* & */
        {
            uint16_t result = new uint16_t((UInt16)var1.var & var2.var);
            return result;
        }
        public static uint16_t operator |(uint16_t var1, uint16_t var2)       /* | */
        {
            uint16_t result = new uint16_t(var1.var | var2.var);
            return result;
        }
        public static uint16_t operator ^(uint16_t var1, uint16_t var2)       /* ^ */
        {
            uint16_t result = new uint16_t((UInt16)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, uint16_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, uint16_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, uint16_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, uint16_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, uint16_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, uint16_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        /* Math */
        public static uint16_t operator +(uint16_t var1, int32_t var2)       /* + */
        {
            uint16_t result = new uint16_t((UInt16)(var1.var + var2.var));
            return result;
        }
        public static uint16_t operator -(uint16_t var1, int32_t var2)       /* - */
        {
            uint16_t result = new uint16_t((UInt16)(var1.var - var2.var));
            return result;
        }
        public static uint16_t operator *(uint16_t var1, int32_t var2)       /* * */
        {
            uint16_t result = new uint16_t((UInt16)var1.var * var2.var);
            return result;
        }
        public static uint16_t operator /(uint16_t var1, int32_t var2)       /* / */
        {
            uint16_t result = new uint16_t((UInt16)var1.var / var2.var);
            return result;
        }
        public static uint16_t operator %(uint16_t var1, int32_t var2)       /* % */
        {
            uint16_t result = new uint16_t((UInt16)var1.var % var2.var);
            return result;
        }
        public static uint16_t operator &(uint16_t var1, int32_t var2)       /* & */
        {
            uint16_t result = new uint16_t((UInt16)var1.var & var2.var);
            return result;
        }
        public static uint16_t operator |(uint16_t var1, int32_t var2)       /* | */
        {
            uint16_t result = new uint16_t((UInt16)var1.var | (UInt16)var2.var);
            return result;
        }
        public static uint16_t operator ^(uint16_t var1, int32_t var2)       /* ^ */
        {
            uint16_t result = new uint16_t((UInt16)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, int32_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, int32_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, int32_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, int32_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, int32_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, int32_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Math */
        public static uint16_t operator +(uint16_t var1, uint32_t var2)       /* + */
        {
            uint16_t result = new uint16_t((UInt16)(var1.var + var2.var));
            return result;
        }
        public static uint16_t operator -(uint16_t var1, uint32_t var2)       /* - */
        {
            uint16_t result = new uint16_t((UInt16)(var1.var - var2.var));
            return result;
        }
        public static uint16_t operator *(uint16_t var1, uint32_t var2)       /* * */
        {
            uint16_t result = new uint16_t((UInt16)var1.var * var2.var);
            return result;
        }
        public static uint16_t operator /(uint16_t var1, uint32_t var2)       /* / */
        {
            uint16_t result = new uint16_t((UInt16)var1.var / var2.var);
            return result;
        }
        public static uint16_t operator %(uint16_t var1, uint32_t var2)       /* % */
        {
            uint16_t result = new uint16_t((UInt16)var1.var % var2.var);
            return result;
        }
        public static uint16_t operator &(uint16_t var1, uint32_t var2)       /* & */
        {
            uint16_t result = new uint16_t((UInt16)var1.var & var2.var);
            return result;
        }
        public static uint16_t operator |(uint16_t var1, uint32_t var2)       /* | */
        {
            uint16_t result = new uint16_t((UInt16)var1.var | (UInt16)var2.var);
            return result;
        }
        public static uint16_t operator ^(uint16_t var1, uint32_t var2)       /* ^ */
        {
            uint16_t result = new uint16_t((UInt16)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, uint32_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, uint32_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, uint32_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, uint32_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, uint32_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, uint32_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        /* Math */
        public static uint16_t operator +(uint16_t var1, int64_t var2)       /* + */
        {
            uint16_t result = new uint16_t((UInt16)(var1.var + var2.var));
            return result;
        }
        public static uint16_t operator -(uint16_t var1, int64_t var2)       /* - */
        {
            uint16_t result = new uint16_t((UInt16)(var1.var - var2.var));
            return result;
        }
        public static uint16_t operator *(uint16_t var1, int64_t var2)       /* * */
        {
            uint16_t result = new uint16_t((UInt16)var1.var * var2.var);
            return result;
        }
        public static uint16_t operator /(uint16_t var1, int64_t var2)       /* / */
        {
            uint16_t result = new uint16_t((UInt16)var1.var / var2.var);
            return result;
        }
        public static uint16_t operator %(uint16_t var1, int64_t var2)       /* % */
        {
            uint16_t result = new uint16_t((UInt16)var1.var % var2.var);
            return result;
        }
        public static uint16_t operator &(uint16_t var1, int64_t var2)       /* & */
        {
            uint16_t result = new uint16_t((UInt16)var1.var & var2.var);
            return result;
        }
        public static uint16_t operator |(uint16_t var1, int64_t var2)       /* | */
        {
            uint16_t result = new uint16_t((UInt16)var1.var | (UInt16)var2.var);
            return result;
        }
        public static uint16_t operator ^(uint16_t var1, int64_t var2)       /* ^ */
        {
            uint16_t result = new uint16_t((UInt16)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, int64_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, int64_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, int64_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, int64_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, int64_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, int64_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        /* Math */
        public static uint16_t operator +(uint16_t var1, uint64_t var2)       /* + */
        {
            uint16_t result = new uint16_t((UInt16)(var1.var + var2.var));
            return result;
        }
        public static uint16_t operator -(uint16_t var1, uint64_t var2)       /* - */
        {
            uint16_t result = new uint16_t((UInt16)(var1.var - var2.var));
            return result;
        }
        public static uint16_t operator *(uint16_t var1, uint64_t var2)       /* * */
        {
            uint16_t result = new uint16_t((UInt16)var1.var * var2.var);
            return result;
        }
        public static uint16_t operator /(uint16_t var1, uint64_t var2)       /* / */
        {
            uint16_t result = new uint16_t((UInt16)var1.var / var2.var);
            return result;
        }
        public static uint16_t operator %(uint16_t var1, uint64_t var2)       /* % */
        {
            uint16_t result = new uint16_t((UInt16)var1.var % var2.var);
            return result;
        }
        public static uint16_t operator &(uint16_t var1, uint64_t var2)       /* & */
        {
            uint16_t result = new uint16_t((UInt16)var1.var & var2.var);
            return result;
        }
        public static uint16_t operator |(uint16_t var1, uint64_t var2)       /* | */
        {
            uint16_t result = new uint16_t((UInt16)var1.var | (UInt16)var2.var);
            return result;
        }
        public static uint16_t operator ^(uint16_t var1, uint64_t var2)       /* ^ */
        {
            uint16_t result = new uint16_t((UInt16)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, uint64_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, uint64_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, uint64_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, uint64_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, uint64_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, uint64_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int
        /* Math */
        public static uint16_t operator +(uint16_t var1, int var2)       /* + */
        {
            uint16_t result = new uint16_t((UInt16)(var1.var + var2));
            return result;
        }
        public static uint16_t operator -(uint16_t var1, int var2)       /* - */
        {
            uint16_t result = new uint16_t((UInt16)(var1.var - var2));
            return result;
        }
        public static uint16_t operator *(uint16_t var1, int var2)       /* * */
        {
            uint16_t result = new uint16_t((UInt16)var1.var * var2);
            return result;
        }
        public static uint16_t operator /(uint16_t var1, int var2)       /* / */
        {
            uint16_t result = new uint16_t((UInt16)var1.var / var2);
            return result;
        }
        public static uint16_t operator %(uint16_t var1, int var2)       /* % */
        {
            uint16_t result = new uint16_t((UInt16)var1.var % var2);
            return result;
        }
        public static uint16_t operator &(uint16_t var1, int var2)       /* & */
        {
            uint16_t result = new uint16_t((UInt16)var1.var & var2);
            return result;
        }
        public static uint16_t operator |(uint16_t var1, int var2)       /* | */
        {
            uint16_t result = new uint16_t((UInt16)var1.var | (UInt16)var2);
            return result;
        }
        public static uint16_t operator ^(uint16_t var1, int var2)       /* ^ */
        {
            uint16_t result = new uint16_t((UInt16)var1.var ^ var2);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, int var2)     /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint16_t var1, int var2)     /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint16_t var1, int var2)    /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint16_t var1, int var2)    /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint16_t var1, int var2)    /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint16_t var1, int var2)    /* > */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Math */
        public static uint16_t operator +(uint16_t var1, byte var2)       /* + */
        {
            uint16_t result = new uint16_t((UInt16)(var1.var + var2));
            return result;
        }
        public static uint16_t operator -(uint16_t var1, byte var2)       /* - */
        {
            uint16_t result = new uint16_t((UInt16)(var1.var - var2));
            return result;
        }
        public static uint16_t operator *(uint16_t var1, byte var2)       /* * */
        {
            uint16_t result = new uint16_t((UInt16)var1.var * var2);
            return result;
        }
        public static uint16_t operator /(uint16_t var1, byte var2)       /* / */
        {
            uint16_t result = new uint16_t((UInt16)var1.var / var2);
            return result;
        }
        public static uint16_t operator %(uint16_t var1, byte var2)       /* % */
        {
            uint16_t result = new uint16_t((UInt16)var1.var % var2);
            return result;
        }
        public static uint16_t operator &(uint16_t var1, byte var2)       /* & */
        {
            uint16_t result = new uint16_t((UInt16)var1.var & var2);
            return result;
        }
        public static uint16_t operator |(uint16_t var1, byte var2)       /* | */
        {
            uint16_t result = new uint16_t((UInt16)var1.var | (UInt16)var2);
            return result;
        }
        public static uint16_t operator ^(uint16_t var1, byte var2)       /* ^ */
        {
            uint16_t result = new uint16_t((UInt16)var1.var ^ var2);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, byte var2)     /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint16_t var1, byte var2)     /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint16_t var1, byte var2)    /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint16_t var1, byte var2)    /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint16_t var1, byte var2)    /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint16_t var1, byte var2)    /* > */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region specials
        public override bool Equals(object obj)
        {
            return (obj is uint16_t) ? this == (uint16_t)obj : false;
        }
        public override int GetHashCode()
        {
            return var;
        }
        public override string ToString()
        {
            return var.ToString();
        }
        #endregion
    }

    /****************************** int32_t **********************************/
    class int32_t
    {
        public Int32 var
        {
            get
            {
                return var;
            }
            set
            {
                var = value;
            }
        }

        #region Constructors
        public int32_t() { var = 0; }
        public int32_t(byte value) { var = (Int32)value; }
        public int32_t(SByte value) { var = (Int32)value; }
        public int32_t(Int16 value) { var = (Int32)value; }
        public int32_t(UInt16 value) { var = (Int32)value; }
        public int32_t(int value) { var = value; }
        public int32_t(UInt32 value) { var = (Int32)value; }
        public int32_t(Int64 value) { var = (Int32)value; }
        public int32_t(UInt64 value) { var = (Int32)value; }
        public int32_t(int8_t value) { var = (Int32)value.var; }
        public int32_t(uint8_t value) { var = (Int32)value.var; }
        public int32_t(int16_t value) { var = (Int32)value.var; }
        public int32_t(uint16_t value) { var = (Int32)value.var; }
        public int32_t(int32_t value) { var = value.var; }
        public int32_t(uint32_t value) { var = (Int32)value.var; }
        public int32_t(int64_t value) { var = (Int32)value.var; }
        public int32_t(uint64_t value) { var = (Int32)value.var; }
        #endregion

        #region int8_t
        /* Math */
        public static int32_t operator +(int32_t var1, int8_t var2)       /* + */
        {
            int32_t result = new int32_t((Int32)(var1.var + var2.var));
            return result;
        }
        public static int32_t operator -(int32_t var1, int8_t var2)       /* - */
        {
            int32_t result = new int32_t((Int32)(var1.var - var2.var));
            return result;
        }
        public static int32_t operator *(int32_t var1, int8_t var2)       /* * */
        {
            int32_t result = new int32_t((Int32)var1.var * var2.var);
            return result;
        }
        public static int32_t operator /(int32_t var1, int8_t var2)       /* / */
        {
            int32_t result = new int32_t((Int32)var1.var / var2.var);
            return result;
        }
        public static int32_t operator %(int32_t var1, int8_t var2)       /* % */
        {
            int32_t result = new int32_t((Int32)var1.var % var2.var);
            return result;
        }
        public static int32_t operator &(int32_t var1, int8_t var2)       /* & */
        {
            int32_t result = new int32_t((Int32)var1.var & var2.var);
            return result;
        }
        public static int32_t operator |(int32_t var1, int8_t var2)       /* | */
        {
            int32_t result = new int32_t((Int32)var1.var | (Int32)var2.var);
            return result;
        }
        public static int32_t operator ^(int32_t var1, int8_t var2)       /* ^ */
        {
            int32_t result = new int32_t((Int32)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int32_t var1, int8_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, int8_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, int8_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, int8_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, int8_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, int8_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Math */
        public static int32_t operator +(int32_t var1, uint8_t var2)       /* + */
        {
            int32_t result = new int32_t((Int32)(var1.var + var2.var));
            return result;
        }
        public static int32_t operator -(int32_t var1, uint8_t var2)       /* - */
        {
            int32_t result = new int32_t((Int32)(var1.var - var2.var));
            return result;
        }
        public static int32_t operator *(int32_t var1, uint8_t var2)       /* * */
        {
            int32_t result = new int32_t((Int32)var1.var * var2.var);
            return result;
        }
        public static int32_t operator /(int32_t var1, uint8_t var2)       /* / */
        {
            int32_t result = new int32_t((Int32)var1.var / var2.var);
            return result;
        }
        public static int32_t operator %(int32_t var1, uint8_t var2)       /* % */
        {
            int32_t result = new int32_t((Int32)var1.var % var2.var);
            return result;
        }
        public static int32_t operator &(int32_t var1, uint8_t var2)       /* & */
        {
            int32_t result = new int32_t((Int32)var1.var & var2.var);
            return result;
        }
        public static int32_t operator |(int32_t var1, uint8_t var2)       /* | */
        {
            int32_t result = new int32_t((Int32)var1.var | (Int32)var2.var);
            return result;
        }
        public static int32_t operator ^(int32_t var1, uint8_t var2)       /* ^ */
        {
            int32_t result = new int32_t((Int32)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int32_t var1, uint8_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, uint8_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, uint8_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, uint8_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, uint8_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, uint8_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        public static int32_t operator +(int32_t var1, int16_t var2)       /* + */
        {
            int32_t result = new int32_t((Int32)(var1.var + var2.var));
            return result;
        }
        public static int32_t operator -(int32_t var1, int16_t var2)       /* - */
        {
            int32_t result = new int32_t((Int32)(var1.var - var2.var));
            return result;
        }
        public static int32_t operator *(int32_t var1, int16_t var2)       /* * */
        {
            int32_t result = new int32_t((Int32)var1.var * var2.var);
            return result;
        }
        public static int32_t operator /(int32_t var1, int16_t var2)       /* / */
        {
            int32_t result = new int32_t((Int32)var1.var / var2.var);
            return result;
        }
        public static int32_t operator %(int32_t var1, int16_t var2)       /* % */
        {
            int32_t result = new int32_t((Int32)var1.var % var2.var);
            return result;
        }
        public static int32_t operator &(int32_t var1, int16_t var2)       /* & */
        {
            int32_t result = new int32_t((Int32)var1.var & var2.var);
            return result;
        }
        public static int32_t operator |(int32_t var1, int16_t var2)       /* | */
        {
            int32_t result = new int32_t((Int32)var1.var | (Int32)var2.var);
            return result;
        }
        public static int32_t operator ^(int32_t var1, int16_t var2)       /* ^ */
        {
            int32_t result = new int32_t((Int32)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int32_t var1, int16_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, int16_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, int16_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, int16_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, int16_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, int16_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        public static int32_t operator +(int32_t var1, uint16_t var2)       /* + */
        {
            int32_t result = new int32_t((Int32)(var1.var + var2.var));
            return result;
        }
        public static int32_t operator -(int32_t var1, uint16_t var2)       /* - */
        {
            int32_t result = new int32_t((Int32)(var1.var - var2.var));
            return result;
        }
        public static int32_t operator *(int32_t var1, uint16_t var2)       /* * */
        {
            int32_t result = new int32_t((Int32)var1.var * var2.var);
            return result;
        }
        public static int32_t operator /(int32_t var1, uint16_t var2)       /* / */
        {
            int32_t result = new int32_t((Int32)var1.var / var2.var);
            return result;
        }
        public static int32_t operator %(int32_t var1, uint16_t var2)       /* % */
        {
            int32_t result = new int32_t((Int32)var1.var % var2.var);
            return result;
        }
        public static int32_t operator &(int32_t var1, uint16_t var2)       /* & */
        {
            int32_t result = new int32_t((Int32)var1.var & var2.var);
            return result;
        }
        public static int32_t operator |(int32_t var1, uint16_t var2)       /* | */
        {
            int32_t result = new int32_t((Int32)var1.var | (Int32)var2.var);
            return result;
        }
        public static int32_t operator ^(int32_t var1, uint16_t var2)       /* ^ */
        {
            int32_t result = new int32_t((Int32)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int32_t var1, uint16_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, uint16_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, uint16_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, uint16_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, uint16_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, uint16_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        /* Math */
        public static int32_t operator +(int32_t var1, int32_t var2)       /* + */
        {
            int32_t result = new int32_t((Int32)(var1.var + var2.var));
            return result;
        }
        public static int32_t operator ++(int32_t var1)                   /* ++ */
        {
            var1.var++;
            return var1;
        }
        public static int32_t operator -(int32_t var1, int32_t var2)       /* - */
        {
            int32_t result = new int32_t((Int32)(var1.var - var2.var));
            return result;
        }
        public static int32_t operator --(int32_t var1)                   /* -- */
        {
            var1.var--;
            return var1;
        }
        public static int32_t operator *(int32_t var1, int32_t var2)       /* * */
        {
            int32_t result = new int32_t((Int32)var1.var * var2.var);
            return result;
        }
        public static int32_t operator /(int32_t var1, int32_t var2)       /* / */
        {
            int32_t result = new int32_t((Int32)var1.var / var2.var);
            return result;
        }
        public static int32_t operator %(int32_t var1, int32_t var2)       /* % */
        {
            int32_t result = new int32_t((Int32)var1.var % var2.var);
            return result;
        }
        public static int32_t operator &(int32_t var1, int32_t var2)       /* & */
        {
            int32_t result = new int32_t((Int32)var1.var & var2.var);
            return result;
        }
        public static int32_t operator |(int32_t var1, int32_t var2)       /* | */
        {
            int32_t result = new int32_t(var1.var | var2.var);
            return result;
        }
        public static int32_t operator ^(int32_t var1, int32_t var2)       /* ^ */
        {
            int32_t result = new int32_t((Int32)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int32_t var1, int32_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, int32_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, int32_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, int32_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, int32_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, int32_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        public static int32_t operator +(int32_t var1, uint32_t var2)       /* + */
        {
            int32_t result = new int32_t((Int32)(var1.var + var2.var));
            return result;
        }
        public static int32_t operator -(int32_t var1, uint32_t var2)       /* - */
        {
            int32_t result = new int32_t((Int32)(var1.var - var2.var));
            return result;
        }
        public static int32_t operator *(int32_t var1, uint32_t var2)       /* * */
        {
            int32_t result = new int32_t((Int32)var1.var * var2.var);
            return result;
        }
        public static int32_t operator /(int32_t var1, uint32_t var2)       /* / */
        {
            int32_t result = new int32_t((Int32)var1.var / var2.var);
            return result;
        }
        public static int32_t operator %(int32_t var1, uint32_t var2)       /* % */
        {
            int32_t result = new int32_t((Int32)var1.var % var2.var);
            return result;
        }
        public static int32_t operator &(int32_t var1, uint32_t var2)       /* & */
        {
            int32_t result = new int32_t((Int32)var1.var & var2.var);
            return result;
        }
        public static int32_t operator |(int32_t var1, uint32_t var2)       /* | */
        {
            int32_t result = new int32_t((Int32)var1.var | (Int32)var2.var);
            return result;
        }
        public static int32_t operator ^(int32_t var1, uint32_t var2)       /* ^ */
        {
            int32_t result = new int32_t((Int32)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int32_t var1, uint32_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, uint32_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, uint32_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, uint32_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, uint32_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, uint32_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        public static int32_t operator +(int32_t var1, int64_t var2)       /* + */
        {
            int32_t result = new int32_t((Int32)(var1.var + var2.var));
            return result;
        }
        public static int32_t operator -(int32_t var1, int64_t var2)       /* - */
        {
            int32_t result = new int32_t((Int32)(var1.var - var2.var));
            return result;
        }
        public static int32_t operator *(int32_t var1, int64_t var2)       /* * */
        {
            int32_t result = new int32_t((Int32)var1.var * var2.var);
            return result;
        }
        public static int32_t operator /(int32_t var1, int64_t var2)       /* / */
        {
            int32_t result = new int32_t((Int32)var1.var / var2.var);
            return result;
        }
        public static int32_t operator %(int32_t var1, int64_t var2)       /* % */
        {
            int32_t result = new int32_t((Int32)var1.var % var2.var);
            return result;
        }
        public static int32_t operator &(int32_t var1, int64_t var2)       /* & */
        {
            int32_t result = new int32_t((Int32)var1.var & var2.var);
            return result;
        }
        public static int32_t operator |(int32_t var1, int64_t var2)       /* | */
        {
            int32_t result = new int32_t((Int32)var1.var | (Int32)var2.var);
            return result;
        }
        public static int32_t operator ^(int32_t var1, int64_t var2)       /* ^ */
        {
            int32_t result = new int32_t((Int32)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int32_t var1, int64_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, int64_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, int64_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, int64_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, int64_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, int64_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        public static int32_t operator +(int32_t var1, uint64_t var2)       /* + */
        {
            int32_t result = new int32_t((Int32)(var1.var + (Int64)var2.var));
            return result;
        }
        public static int32_t operator -(int32_t var1, uint64_t var2)       /* - */
        {
            int32_t result = new int32_t((Int32)(var1.var - (Int64)var2.var));
            return result;
        }
        public static int32_t operator *(int32_t var1, uint64_t var2)       /* * */
        {
            int32_t result = new int32_t((Int32)var1.var * (Int64)var2.var);
            return result;
        }
        public static int32_t operator /(int32_t var1, uint64_t var2)       /* / */
        {
            int32_t result = new int32_t((Int32)var1.var / (Int64)var2.var);
            return result;
        }
        public static int32_t operator %(int32_t var1, uint64_t var2)       /* % */
        {
            int32_t result = new int32_t((Int32)var1.var % (Int64)var2.var);
            return result;
        }
        public static int32_t operator &(int32_t var1, uint64_t var2)       /* & */
        {
            int32_t result = new int32_t((Int32)var1.var & (Int64)var2.var);
            return result;
        }
        public static int32_t operator |(int32_t var1, uint64_t var2)       /* | */
        {
            int32_t result = new int32_t((Int32)var1.var | (Int32)var2.var);
            return result;
        }
        public static int32_t operator ^(int32_t var1, uint64_t var2)       /* ^ */
        {
            int32_t result = new int32_t((Int32)var1.var ^ (Int64)var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int32_t var1, uint64_t var2)     /* > */
        {
            return (var1.var > (Int64)var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, uint64_t var2)     /* < */
        {
            return (var1.var < (Int64)var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, uint64_t var2)    /* <= */
        {
            return (var1.var <= (Int64)var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, uint64_t var2)    /* >= */
        {
            return (var1.var >= (Int64)var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, uint64_t var2)    /* == */
        {
            return (var1.var == (Int64)var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, uint64_t var2)    /* > */
        {
            return (var1.var != (Int64)var2.var) ? true : false;
        }
        #endregion
        #region int
        /* Math */
        public static int32_t operator +(int32_t var1, int var2)       /* + */
        {
            int32_t result = new int32_t((Int32)(var1.var + var2));
            return result;
        }
        public static int32_t operator -(int32_t var1, int var2)       /* - */
        {
            int32_t result = new int32_t((Int32)(var1.var - var2));
            return result;
        }
        public static int32_t operator *(int32_t var1, int var2)       /* * */
        {
            int32_t result = new int32_t((Int32)var1.var * var2);
            return result;
        }
        public static int32_t operator /(int32_t var1, int var2)       /* / */
        {
            int32_t result = new int32_t((Int32)var1.var / var2);
            return result;
        }
        public static int32_t operator %(int32_t var1, int var2)       /* % */
        {
            int32_t result = new int32_t((Int32)var1.var % var2);
            return result;
        }
        public static int32_t operator &(int32_t var1, int var2)       /* & */
        {
            int32_t result = new int32_t((Int32)var1.var & var2);
            return result;
        }
        public static int32_t operator |(int32_t var1, int var2)       /* | */
        {
            int32_t result = new int32_t((Int32)var1.var | (Int32)var2);
            return result;
        }
        public static int32_t operator ^(int32_t var1, int var2)       /* ^ */
        {
            int32_t result = new int32_t((Int32)var1.var ^ var2);
            return result;
        }

        /* Comparison */
        public static bool operator >(int32_t var1, int var2)     /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int32_t var1, int var2)     /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int32_t var1, int var2)    /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int32_t var1, int var2)    /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int32_t var1, int var2)    /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int32_t var1, int var2)    /* > */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Math */
        public static int32_t operator +(int32_t var1, byte var2)       /* + */
        {
            int32_t result = new int32_t((Int32)(var1.var + var2));
            return result;
        }
        public static int32_t operator -(int32_t var1, byte var2)       /* - */
        {
            int32_t result = new int32_t((Int32)(var1.var - var2));
            return result;
        }
        public static int32_t operator *(int32_t var1, byte var2)       /* * */
        {
            int32_t result = new int32_t((Int32)var1.var * var2);
            return result;
        }
        public static int32_t operator /(int32_t var1, byte var2)       /* / */
        {
            int32_t result = new int32_t((Int32)var1.var / var2);
            return result;
        }
        public static int32_t operator %(int32_t var1, byte var2)       /* % */
        {
            int32_t result = new int32_t((Int32)var1.var % var2);
            return result;
        }
        public static int32_t operator &(int32_t var1, byte var2)       /* & */
        {
            int32_t result = new int32_t((Int32)var1.var & var2);
            return result;
        }
        public static int32_t operator |(int32_t var1, byte var2)       /* | */
        {
            int32_t result = new int32_t((Int32)var1.var | (Int32)var2);
            return result;
        }
        public static int32_t operator ^(int32_t var1, byte var2)       /* ^ */
        {
            int32_t result = new int32_t((Int32)var1.var ^ var2);
            return result;
        }

        /* Comparison */
        public static bool operator >(int32_t var1, byte var2)     /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int32_t var1, byte var2)     /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int32_t var1, byte var2)    /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int32_t var1, byte var2)    /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int32_t var1, byte var2)    /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int32_t var1, byte var2)    /* > */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region specials
        public override bool Equals(object obj)
        {
            return (obj is int32_t) ? this == (int32_t)obj : false;
        }
        public override int GetHashCode()
        {
            return var;
        }
        public override string ToString()
        {
            return var.ToString();
        }
        #endregion
    }

    /****************************** uint32_t **********************************/
    class uint32_t
    {
        public UInt32 var
        {
            get
            {
                return var;
            }
            set
            {
                var = value;
            }
        }

        #region Constructors
        public uint32_t() { var = 0; }
        public uint32_t(byte value) { var = (UInt32)value; }
        public uint32_t(SByte value) { var = (UInt32)value; }
        public uint32_t(Int16 value) { var = (UInt32)value; }
        public uint32_t(UInt16 value) { var = (UInt32)value; }
        public uint32_t(int value) { var = (UInt32)value; }
        public uint32_t(UInt32 value) { var = value; }
        public uint32_t(Int64 value) { var = (UInt32)value; }
        public uint32_t(UInt64 value) { var = (UInt32)value; }
        public uint32_t(int8_t value) { var = (UInt32)value.var; }
        public uint32_t(uint8_t value) { var = (UInt32)value.var; }
        public uint32_t(int16_t value) { var = (UInt32)value.var; }
        public uint32_t(uint16_t value) { var = (UInt32)value.var; }
        public uint32_t(int32_t value) { var = (UInt32)value.var; }
        public uint32_t(uint32_t value) { var = value.var; }
        public uint32_t(int64_t value) { var = (UInt32)value.var; }
        public uint32_t(uint64_t value) { var = (UInt32)value.var; }
        #endregion

        #region int8_t
        /* Math */
        public static uint32_t operator +(uint32_t var1, int8_t var2)       /* + */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var + var2.var));
            return result;
        }
        public static uint32_t operator -(uint32_t var1, int8_t var2)       /* - */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var - var2.var));
            return result;
        }
        public static uint32_t operator *(uint32_t var1, int8_t var2)       /* * */
        {
            uint32_t result = new uint32_t((UInt32)((UInt32)var1.var * var2.var));
            return result;
        }
        public static uint32_t operator /(uint32_t var1, int8_t var2)       /* / */
        {
            uint32_t result = new uint32_t((UInt32)((UInt32)var1.var / var2.var));
            return result;
        }
        public static uint32_t operator %(uint32_t var1, int8_t var2)       /* % */
        {
            uint32_t result = new uint32_t((UInt32)((UInt32)var1.var % var2.var));
            return result;
        }
        public static uint32_t operator &(uint32_t var1, int8_t var2)       /* & */
        {
            uint32_t result = new uint32_t((UInt32)((UInt32)var1.var & var2.var));
            return result;
        }
        public static uint32_t operator |(uint32_t var1, int8_t var2)       /* | */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var | (byte)(var2.var)));
            return result;
        }
        public static uint32_t operator ^(uint32_t var1, int8_t var2)       /* ^ */
        {
            uint32_t result = new uint32_t((UInt32)((UInt32)var1.var ^ var2.var));
            return result;
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, int8_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, int8_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, int8_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, int8_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, int8_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, int8_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Math */
        public static uint32_t operator +(uint32_t var1, uint8_t var2)       /* + */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var + var2.var));
            return result;
        }
        public static uint32_t operator -(uint32_t var1, uint8_t var2)       /* - */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var - var2.var));
            return result;
        }
        public static uint32_t operator *(uint32_t var1, uint8_t var2)       /* * */
        {
            uint32_t result = new uint32_t((UInt32)var1.var * var2.var);
            return result;
        }
        public static uint32_t operator /(uint32_t var1, uint8_t var2)       /* / */
        {
            uint32_t result = new uint32_t((UInt32)var1.var / var2.var);
            return result;
        }
        public static uint32_t operator %(uint32_t var1, uint8_t var2)       /* % */
        {
            uint32_t result = new uint32_t((UInt32)var1.var % var2.var);
            return result;
        }
        public static uint32_t operator &(uint32_t var1, uint8_t var2)       /* & */
        {
            uint32_t result = new uint32_t((UInt32)var1.var & var2.var);
            return result;
        }
        public static uint32_t operator |(uint32_t var1, uint8_t var2)       /* | */
        {
            uint32_t result = new uint32_t((UInt32)var1.var | (UInt32)var2.var);
            return result;
        }
        public static uint32_t operator ^(uint32_t var1, uint8_t var2)       /* ^ */
        {
            uint32_t result = new uint32_t((UInt32)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, uint8_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, uint8_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, uint8_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, uint8_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, uint8_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, uint8_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        public static uint32_t operator +(uint32_t var1, int16_t var2)       /* + */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var + var2.var));
            return result;
        }
        public static uint32_t operator -(uint32_t var1, int16_t var2)       /* - */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var - var2.var));
            return result;
        }
        public static uint32_t operator *(uint32_t var1, int16_t var2)       /* * */
        {
            uint32_t result = new uint32_t((UInt32)((UInt32)var1.var * var2.var));
            return result;
        }
        public static uint32_t operator /(uint32_t var1, int16_t var2)       /* / */
        {
            uint32_t result = new uint32_t((UInt32)((UInt32)var1.var / var2.var));
            return result;
        }
        public static uint32_t operator %(uint32_t var1, int16_t var2)       /* % */
        {
            uint32_t result = new uint32_t((UInt32)((UInt32)var1.var % var2.var));
            return result;
        }
        public static uint32_t operator &(uint32_t var1, int16_t var2)       /* & */
        {
            uint32_t result = new uint32_t((UInt32)((UInt32)var1.var & var2.var));
            return result;
        }
        public static uint32_t operator |(uint32_t var1, int16_t var2)       /* | */
        {
            uint32_t result = new uint32_t(var1.var | (UInt16)var2.var);
            return result;
        }
        public static uint32_t operator ^(uint32_t var1, int16_t var2)       /* ^ */
        {
            uint32_t result = new uint32_t((UInt32)((UInt32)var1.var ^ var2.var));
            return result;
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, int16_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, int16_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, int16_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, int16_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, int16_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, int16_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        public static uint32_t operator +(uint32_t var1, uint16_t var2)       /* + */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var + var2.var));
            return result;
        }
        public static uint32_t operator -(uint32_t var1, uint16_t var2)       /* - */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var - var2.var));
            return result;
        }
        public static uint32_t operator *(uint32_t var1, uint16_t var2)       /* * */
        {
            uint32_t result = new uint32_t((UInt32)var1.var * var2.var);
            return result;
        }
        public static uint32_t operator /(uint32_t var1, uint16_t var2)       /* / */
        {
            uint32_t result = new uint32_t((UInt32)var1.var / var2.var);
            return result;
        }
        public static uint32_t operator %(uint32_t var1, uint16_t var2)       /* % */
        {
            uint32_t result = new uint32_t((UInt32)var1.var % var2.var);
            return result;
        }
        public static uint32_t operator &(uint32_t var1, uint16_t var2)       /* & */
        {
            uint32_t result = new uint32_t((UInt32)var1.var & var2.var);
            return result;
        }
        public static uint32_t operator |(uint32_t var1, uint16_t var2)       /* | */
        {
            uint32_t result = new uint32_t((UInt32)var1.var | (UInt32)var2.var);
            return result;
        }
        public static uint32_t operator ^(uint32_t var1, uint16_t var2)       /* ^ */
        {
            uint32_t result = new uint32_t((UInt32)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, uint16_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, uint16_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, uint16_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, uint16_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, uint16_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, uint16_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        public static uint32_t operator +(uint32_t var1, int32_t var2)       /* + */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var + var2.var));
            return result;
        }
        public static uint32_t operator -(uint32_t var1, int32_t var2)       /* - */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var - var2.var));
            return result;
        }
        public static uint32_t operator *(uint32_t var1, int32_t var2)       /* * */
        {
            uint32_t result = new uint32_t((UInt32)((UInt32)var1.var * var2.var));
            return result;
        }
        public static uint32_t operator /(uint32_t var1, int32_t var2)       /* / */
        {
            uint32_t result = new uint32_t((UInt32)((UInt32)var1.var / var2.var));
            return result;
        }
        public static uint32_t operator %(uint32_t var1, int32_t var2)       /* % */
        {
            uint32_t result = new uint32_t((UInt32)((UInt32)var1.var % var2.var));
            return result;
        }
        public static uint32_t operator &(uint32_t var1, int32_t var2)       /* & */
        {
            uint32_t result = new uint32_t((UInt32)((UInt32)var1.var & var2.var));
            return result;
        }
        public static uint32_t operator |(uint32_t var1, int32_t var2)       /* | */
        {
            uint32_t result = new uint32_t((UInt32)var1.var | (UInt32)var2.var);
            return result;
        }
        public static uint32_t operator ^(uint32_t var1, int32_t var2)       /* ^ */
        {
            uint32_t result = new uint32_t((UInt32)((UInt32)var1.var ^ var2.var));
            return result;
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, int32_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, int32_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, int32_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, int32_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, int32_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, int32_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Math */
        public static uint32_t operator +(uint32_t var1, uint32_t var2)       /* + */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var + var2.var));
            return result;
        }
        public static uint32_t operator ++(uint32_t var1)                   /* ++ */
        {
            var1.var++;
            return var1;
        }
        public static uint32_t operator -(uint32_t var1, uint32_t var2)       /* - */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var - var2.var));
            return result;
        }
        public static uint32_t operator --(uint32_t var1)                   /* -- */
        {
            var1.var--;
            return var1;
        }
        public static uint32_t operator *(uint32_t var1, uint32_t var2)       /* * */
        {
            uint32_t result = new uint32_t((UInt32)var1.var * var2.var);
            return result;
        }
        public static uint32_t operator /(uint32_t var1, uint32_t var2)       /* / */
        {
            uint32_t result = new uint32_t((UInt32)var1.var / var2.var);
            return result;
        }
        public static uint32_t operator %(uint32_t var1, uint32_t var2)       /* % */
        {
            uint32_t result = new uint32_t((UInt32)var1.var % var2.var);
            return result;
        }
        public static uint32_t operator &(uint32_t var1, uint32_t var2)       /* & */
        {
            uint32_t result = new uint32_t((UInt32)var1.var & var2.var);
            return result;
        }
        public static uint32_t operator |(uint32_t var1, uint32_t var2)       /* | */
        {
            uint32_t result = new uint32_t(var1.var | var2.var);
            return result;
        }
        public static uint32_t operator ^(uint32_t var1, uint32_t var2)       /* ^ */
        {
            uint32_t result = new uint32_t((UInt32)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, uint32_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, uint32_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, uint32_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, uint32_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, uint32_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, uint32_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        public static uint32_t operator +(uint32_t var1, int64_t var2)       /* + */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var + var2.var));
            return result;
        }
        public static uint32_t operator -(uint32_t var1, int64_t var2)       /* - */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var - var2.var));
            return result;
        }
        public static uint32_t operator *(uint32_t var1, int64_t var2)       /* * */
        {
            uint32_t result = new uint32_t((UInt32)var1.var * var2.var);
            return result;
        }
        public static uint32_t operator /(uint32_t var1, int64_t var2)       /* / */
        {
            uint32_t result = new uint32_t((UInt32)var1.var / var2.var);
            return result;
        }
        public static uint32_t operator %(uint32_t var1, int64_t var2)       /* % */
        {
            uint32_t result = new uint32_t((UInt32)var1.var % var2.var);
            return result;
        }
        public static uint32_t operator &(uint32_t var1, int64_t var2)       /* & */
        {
            uint32_t result = new uint32_t((UInt32)var1.var & var2.var);
            return result;
        }
        public static uint32_t operator |(uint32_t var1, int64_t var2)       /* | */
        {
            uint32_t result = new uint32_t((UInt32)var1.var | (UInt32)var2.var);
            return result;
        }
        public static uint32_t operator ^(uint32_t var1, int64_t var2)       /* ^ */
        {
            uint32_t result = new uint32_t((UInt32)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, int64_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, int64_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, int64_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, int64_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, int64_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, int64_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        public static uint32_t operator +(uint32_t var1, uint64_t var2)       /* + */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var + var2.var));
            return result;
        }
        public static uint32_t operator -(uint32_t var1, uint64_t var2)       /* - */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var - var2.var));
            return result;
        }
        public static uint32_t operator *(uint32_t var1, uint64_t var2)       /* * */
        {
            uint32_t result = new uint32_t((UInt32)var1.var * var2.var);
            return result;
        }
        public static uint32_t operator /(uint32_t var1, uint64_t var2)       /* / */
        {
            uint32_t result = new uint32_t((UInt32)var1.var / var2.var);
            return result;
        }
        public static uint32_t operator %(uint32_t var1, uint64_t var2)       /* % */
        {
            uint32_t result = new uint32_t((UInt32)var1.var % var2.var);
            return result;
        }
        public static uint32_t operator &(uint32_t var1, uint64_t var2)       /* & */
        {
            uint32_t result = new uint32_t((UInt32)var1.var & var2.var);
            return result;
        }
        public static uint32_t operator |(uint32_t var1, uint64_t var2)       /* | */
        {
            uint32_t result = new uint32_t((UInt32)var1.var | (UInt32)var2.var);
            return result;
        }
        public static uint32_t operator ^(uint32_t var1, uint64_t var2)       /* ^ */
        {
            uint32_t result = new uint32_t((UInt32)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, uint64_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, uint64_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, uint64_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, uint64_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, uint64_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, uint64_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int
        /* Math */
        public static uint32_t operator +(uint32_t var1, int var2)       /* + */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var + var2));
            return result;
        }
        public static uint32_t operator -(uint32_t var1, int var2)       /* - */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var - var2));
            return result;
        }
        public static uint32_t operator *(uint32_t var1, int var2)       /* * */
        {
            uint32_t result = new uint32_t((UInt32)((UInt32)var1.var * var2));
            return result;
        }
        public static uint32_t operator /(uint32_t var1, int var2)       /* / */
        {
            uint32_t result = new uint32_t((UInt32)((UInt32)var1.var / var2));
            return result;
        }
        public static uint32_t operator %(uint32_t var1, int var2)       /* % */
        {
            uint32_t result = new uint32_t((UInt32)((UInt32)var1.var % var2));
            return result;
        }
        public static uint32_t operator &(uint32_t var1, int var2)       /* & */
        {
            uint32_t result = new uint32_t((UInt32)((UInt32)var1.var & var2));
            return result;
        }
        public static uint32_t operator |(uint32_t var1, int var2)       /* | */
        {
            uint32_t result = new uint32_t((UInt32)var1.var | (UInt32)var2);
            return result;
        }
        public static uint32_t operator ^(uint32_t var1, int var2)       /* ^ */
        {
            uint32_t result = new uint32_t((UInt32)((UInt32)var1.var ^ var2));
            return result;
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, int var2)     /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint32_t var1, int var2)     /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint32_t var1, int var2)    /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint32_t var1, int var2)    /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint32_t var1, int var2)    /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint32_t var1, int var2)    /* > */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Math */
        public static uint32_t operator +(uint32_t var1, byte var2)       /* + */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var + var2));
            return result;
        }
        public static uint32_t operator -(uint32_t var1, byte var2)       /* - */
        {
            uint32_t result = new uint32_t((UInt32)(var1.var - var2));
            return result;
        }
        public static uint32_t operator *(uint32_t var1, byte var2)       /* * */
        {
            uint32_t result = new uint32_t((UInt32)var1.var * var2);
            return result;
        }
        public static uint32_t operator /(uint32_t var1, byte var2)       /* / */
        {
            uint32_t result = new uint32_t((UInt32)var1.var / var2);
            return result;
        }
        public static uint32_t operator %(uint32_t var1, byte var2)       /* % */
        {
            uint32_t result = new uint32_t((UInt32)var1.var % var2);
            return result;
        }
        public static uint32_t operator &(uint32_t var1, byte var2)       /* & */
        {
            uint32_t result = new uint32_t((UInt32)var1.var & var2);
            return result;
        }
        public static uint32_t operator |(uint32_t var1, byte var2)       /* | */
        {
            uint32_t result = new uint32_t((UInt32)var1.var | (UInt32)var2);
            return result;
        }
        public static uint32_t operator ^(uint32_t var1, byte var2)       /* ^ */
        {
            uint32_t result = new uint32_t((UInt32)var1.var ^ var2);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, byte var2)     /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint32_t var1, byte var2)     /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint32_t var1, byte var2)    /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint32_t var1, byte var2)    /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint32_t var1, byte var2)    /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint32_t var1, byte var2)    /* > */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region specials
        public override bool Equals(object obj)
        {
            return (obj is uint32_t) ? this == (uint32_t)obj : false;
        }
        public override string ToString()
        {
            return var.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }

    /****************************** int64_t **********************************/
    class int64_t
    {
        public Int64 var
        {
            get
            {
                return var;
            }
            set
            {
                var = value;
            }
        }

        #region Constructors
        public int64_t() { var = 0; }
        public int64_t(byte value) { var = (Int64)value; }
        public int64_t(SByte value) { var = (Int64)value; }
        public int64_t(Int16 value) { var = (Int64)value; }
        public int64_t(UInt16 value) { var = (Int64)value; }
        public int64_t(int value) { var = (Int64)value; }
        public int64_t(UInt32 value) { var = (Int64)value; }
        public int64_t(Int64 value) { var = value; }
        public int64_t(UInt64 value) { var = (Int64)value; }
        public int64_t(int8_t value) { var = (Int64)value.var; }
        public int64_t(uint8_t value) { var = (Int64)value.var; }
        public int64_t(int16_t value) { var = (Int64)value.var; }
        public int64_t(uint16_t value) { var = (Int64)value.var; }
        public int64_t(int32_t value) { var = (Int64)value.var; }
        public int64_t(uint32_t value) { var = (Int64)value.var; }
        public int64_t(int64_t value) { var = value.var; }
        public int64_t(uint64_t value) { var = (Int64)value.var; }
        #endregion

        #region int8_t
        /* Math */
        public static int64_t operator +(int64_t var1, int8_t var2)       /* + */
        {
            int64_t result = new int64_t((Int64)(var1.var + var2.var));
            return result;
        }
        public static int64_t operator -(int64_t var1, int8_t var2)       /* - */
        {
            int64_t result = new int64_t((Int64)(var1.var - var2.var));
            return result;
        }
        public static int64_t operator *(int64_t var1, int8_t var2)       /* * */
        {
            int64_t result = new int64_t((Int64)((Int64)var1.var * var2.var));
            return result;
        }
        public static int64_t operator /(int64_t var1, int8_t var2)       /* / */
        {
            int64_t result = new int64_t((Int64)((Int64)var1.var / var2.var));
            return result;
        }
        public static int64_t operator %(int64_t var1, int8_t var2)       /* % */
        {
            int64_t result = new int64_t((Int64)((Int64)var1.var % var2.var));
            return result;
        }
        public static int64_t operator &(int64_t var1, int8_t var2)       /* & */
        {
            int64_t result = new int64_t((Int64)((Int64)var1.var & var2.var));
            return result;
        }
        public static int64_t operator |(int64_t var1, int8_t var2)       /* | */
        {
            int64_t result = new int64_t((Int64)(var1.var | (byte)(var2.var)));
            return result;
        }
        public static int64_t operator ^(int64_t var1, int8_t var2)       /* ^ */
        {
            int64_t result = new int64_t((Int64)((Int64)var1.var ^ var2.var));
            return result;
        }

        /* Comparison */
        public static bool operator >(int64_t var1, int8_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int64_t var1, int8_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int64_t var1, int8_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int64_t var1, int8_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int64_t var1, int8_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int64_t var1, int8_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Math */
        public static int64_t operator +(int64_t var1, uint8_t var2)       /* + */
        {
            int64_t result = new int64_t((Int64)(var1.var + var2.var));
            return result;
        }
        public static int64_t operator -(int64_t var1, uint8_t var2)       /* - */
        {
            int64_t result = new int64_t((Int64)(var1.var - var2.var));
            return result;
        }
        public static int64_t operator *(int64_t var1, uint8_t var2)       /* * */
        {
            int64_t result = new int64_t((Int64)var1.var * var2.var);
            return result;
        }
        public static int64_t operator /(int64_t var1, uint8_t var2)       /* / */
        {
            int64_t result = new int64_t((Int64)var1.var / var2.var);
            return result;
        }
        public static int64_t operator %(int64_t var1, uint8_t var2)       /* % */
        {
            int64_t result = new int64_t((Int64)var1.var % var2.var);
            return result;
        }
        public static int64_t operator &(int64_t var1, uint8_t var2)       /* & */
        {
            int64_t result = new int64_t((Int64)var1.var & var2.var);
            return result;
        }
        public static int64_t operator |(int64_t var1, uint8_t var2)       /* | */
        {
            int64_t result = new int64_t((Int64)var1.var | (Int64)var2.var);
            return result;
        }
        public static int64_t operator ^(int64_t var1, uint8_t var2)       /* ^ */
        {
            int64_t result = new int64_t((Int64)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int64_t var1, uint8_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int64_t var1, uint8_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int64_t var1, uint8_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int64_t var1, uint8_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int64_t var1, uint8_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int64_t var1, uint8_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        public static int64_t operator +(int64_t var1, int16_t var2)       /* + */
        {
            int64_t result = new int64_t((Int64)(var1.var + var2.var));
            return result;
        }
        public static int64_t operator -(int64_t var1, int16_t var2)       /* - */
        {
            int64_t result = new int64_t((Int64)(var1.var - var2.var));
            return result;
        }
        public static int64_t operator *(int64_t var1, int16_t var2)       /* * */
        {
            int64_t result = new int64_t((Int64)((Int64)var1.var * var2.var));
            return result;
        }
        public static int64_t operator /(int64_t var1, int16_t var2)       /* / */
        {
            int64_t result = new int64_t((Int64)((Int64)var1.var / var2.var));
            return result;
        }
        public static int64_t operator %(int64_t var1, int16_t var2)       /* % */
        {
            int64_t result = new int64_t((Int64)((Int64)var1.var % var2.var));
            return result;
        }
        public static int64_t operator &(int64_t var1, int16_t var2)       /* & */
        {
            int64_t result = new int64_t((Int64)((Int64)var1.var & var2.var));
            return result;
        }
        public static int64_t operator |(int64_t var1, int16_t var2)       /* | */
        {
            int64_t result = new int64_t(var1.var | (UInt16)var2.var);
            return result;
        }
        public static int64_t operator ^(int64_t var1, int16_t var2)       /* ^ */
        {
            int64_t result = new int64_t((Int64)((Int64)var1.var ^ var2.var));
            return result;
        }

        /* Comparison */
        public static bool operator >(int64_t var1, int16_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int64_t var1, int16_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int64_t var1, int16_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int64_t var1, int16_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int64_t var1, int16_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int64_t var1, int16_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        public static int64_t operator +(int64_t var1, uint16_t var2)       /* + */
        {
            int64_t result = new int64_t((Int64)(var1.var + var2.var));
            return result;
        }
        public static int64_t operator -(int64_t var1, uint16_t var2)       /* - */
        {
            int64_t result = new int64_t((Int64)(var1.var - var2.var));
            return result;
        }
        public static int64_t operator *(int64_t var1, uint16_t var2)       /* * */
        {
            int64_t result = new int64_t((Int64)var1.var * var2.var);
            return result;
        }
        public static int64_t operator /(int64_t var1, uint16_t var2)       /* / */
        {
            int64_t result = new int64_t((Int64)var1.var / var2.var);
            return result;
        }
        public static int64_t operator %(int64_t var1, uint16_t var2)       /* % */
        {
            int64_t result = new int64_t((Int64)var1.var % var2.var);
            return result;
        }
        public static int64_t operator &(int64_t var1, uint16_t var2)       /* & */
        {
            int64_t result = new int64_t((Int64)var1.var & var2.var);
            return result;
        }
        public static int64_t operator |(int64_t var1, uint16_t var2)       /* | */
        {
            int64_t result = new int64_t((Int64)var1.var | (Int64)var2.var);
            return result;
        }
        public static int64_t operator ^(int64_t var1, uint16_t var2)       /* ^ */
        {
            int64_t result = new int64_t((Int64)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int64_t var1, uint16_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int64_t var1, uint16_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int64_t var1, uint16_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int64_t var1, uint16_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int64_t var1, uint16_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int64_t var1, uint16_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        public static int64_t operator +(int64_t var1, int32_t var2)       /* + */
        {
            int64_t result = new int64_t((Int64)(var1.var + var2.var));
            return result;
        }
        public static int64_t operator -(int64_t var1, int32_t var2)       /* - */
        {
            int64_t result = new int64_t((Int64)(var1.var - var2.var));
            return result;
        }
        public static int64_t operator *(int64_t var1, int32_t var2)       /* * */
        {
            int64_t result = new int64_t((Int64)((Int64)var1.var * var2.var));
            return result;
        }
        public static int64_t operator /(int64_t var1, int32_t var2)       /* / */
        {
            int64_t result = new int64_t((Int64)((Int64)var1.var / var2.var));
            return result;
        }
        public static int64_t operator %(int64_t var1, int32_t var2)       /* % */
        {
            int64_t result = new int64_t((Int64)((Int64)var1.var % var2.var));
            return result;
        }
        public static int64_t operator &(int64_t var1, int32_t var2)       /* & */
        {
            int64_t result = new int64_t((Int64)((Int64)var1.var & var2.var));
            return result;
        }
        public static int64_t operator |(int64_t var1, int32_t var2)       /* | */
        {
            int64_t result = new int64_t((Int64)var1.var | (Int64)var2.var);
            return result;
        }
        public static int64_t operator ^(int64_t var1, int32_t var2)       /* ^ */
        {
            int64_t result = new int64_t((Int64)((Int64)var1.var ^ var2.var));
            return result;
        }

        /* Comparison */
        public static bool operator >(int64_t var1, int32_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int64_t var1, int32_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int64_t var1, int32_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int64_t var1, int32_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int64_t var1, int32_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int64_t var1, int32_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Math */
        public static int64_t operator +(int64_t var1, uint32_t var2)       /* + */
        {
            int64_t result = new int64_t((Int64)(var1.var + var2.var));
            return result;
        }
        public static int64_t operator ++(int64_t var1)                   /* ++ */
        {
            var1.var++;
            return var1;
        }
        public static int64_t operator -(int64_t var1, uint32_t var2)       /* - */
        {
            int64_t result = new int64_t((Int64)(var1.var - var2.var));
            return result;
        }
        public static int64_t operator --(int64_t var1)                   /* -- */
        {
            var1.var--;
            return var1;
        }
        public static int64_t operator *(int64_t var1, uint32_t var2)       /* * */
        {
            int64_t result = new int64_t((Int64)var1.var * var2.var);
            return result;
        }
        public static int64_t operator /(int64_t var1, uint32_t var2)       /* / */
        {
            int64_t result = new int64_t((Int64)var1.var / var2.var);
            return result;
        }
        public static int64_t operator %(int64_t var1, uint32_t var2)       /* % */
        {
            int64_t result = new int64_t((Int64)var1.var % var2.var);
            return result;
        }
        public static int64_t operator &(int64_t var1, uint32_t var2)       /* & */
        {
            int64_t result = new int64_t((Int64)var1.var & var2.var);
            return result;
        }
        public static int64_t operator |(int64_t var1, uint32_t var2)       /* | */
        {
            int64_t result = new int64_t(var1.var | var2.var);
            return result;
        }
        public static int64_t operator ^(int64_t var1, uint32_t var2)       /* ^ */
        {
            int64_t result = new int64_t((Int64)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int64_t var1, uint32_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int64_t var1, uint32_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int64_t var1, uint32_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int64_t var1, uint32_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int64_t var1, uint32_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int64_t var1, uint32_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        public static int64_t operator +(int64_t var1, int64_t var2)       /* + */
        {
            int64_t result = new int64_t((Int64)(var1.var + var2.var));
            return result;
        }
        public static int64_t operator -(int64_t var1, int64_t var2)       /* - */
        {
            int64_t result = new int64_t((Int64)(var1.var - var2.var));
            return result;
        }
        public static int64_t operator *(int64_t var1, int64_t var2)       /* * */
        {
            int64_t result = new int64_t((Int64)var1.var * var2.var);
            return result;
        }
        public static int64_t operator /(int64_t var1, int64_t var2)       /* / */
        {
            int64_t result = new int64_t((Int64)var1.var / var2.var);
            return result;
        }
        public static int64_t operator %(int64_t var1, int64_t var2)       /* % */
        {
            int64_t result = new int64_t((Int64)var1.var % var2.var);
            return result;
        }
        public static int64_t operator &(int64_t var1, int64_t var2)       /* & */
        {
            int64_t result = new int64_t((Int64)var1.var & var2.var);
            return result;
        }
        public static int64_t operator |(int64_t var1, int64_t var2)       /* | */
        {
            int64_t result = new int64_t((Int64)var1.var | (Int64)var2.var);
            return result;
        }
        public static int64_t operator ^(int64_t var1, int64_t var2)       /* ^ */
        {
            int64_t result = new int64_t((Int64)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int64_t var1, int64_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int64_t var1, int64_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int64_t var1, int64_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int64_t var1, int64_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int64_t var1, int64_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int64_t var1, int64_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        public static int64_t operator +(int64_t var1, uint64_t var2)       /* + */
        {
            int64_t result = new int64_t((Int64)(var1.var + (Int64)var2.var));
            return result;
        }
        public static int64_t operator -(int64_t var1, uint64_t var2)       /* - */
        {
            int64_t result = new int64_t((Int64)(var1.var - (Int64)var2.var));
            return result;
        }
        public static int64_t operator *(int64_t var1, uint64_t var2)       /* * */
        {
            int64_t result = new int64_t((Int64)var1.var * (Int64)var2.var);
            return result;
        }
        public static int64_t operator /(int64_t var1, uint64_t var2)       /* / */
        {
            int64_t result = new int64_t((Int64)var1.var / (Int64)var2.var);
            return result;
        }
        public static int64_t operator %(int64_t var1, uint64_t var2)       /* % */
        {
            int64_t result = new int64_t((Int64)var1.var % (Int64)var2.var);
            return result;
        }
        public static int64_t operator &(int64_t var1, uint64_t var2)       /* & */
        {
            int64_t result = new int64_t((Int64)var1.var & (Int64)var2.var);
            return result;
        }
        public static int64_t operator |(int64_t var1, uint64_t var2)       /* | */
        {
            int64_t result = new int64_t((Int64)var1.var | (Int64)var2.var);
            return result;
        }
        public static int64_t operator ^(int64_t var1, uint64_t var2)       /* ^ */
        {
            int64_t result = new int64_t((Int64)var1.var ^ (Int64)var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(int64_t var1, uint64_t var2)     /* > */
        {
            return (var1.var > (Int64)var2.var) ? true : false;
        }
        public static bool operator <(int64_t var1, uint64_t var2)     /* < */
        {
            return (var1.var < (Int64)var2.var) ? true : false;
        }
        public static bool operator <=(int64_t var1, uint64_t var2)    /* <= */
        {
            return (var1.var <= (Int64)var2.var) ? true : false;
        }
        public static bool operator >=(int64_t var1, uint64_t var2)    /* >= */
        {
            return (var1.var >= (Int64)var2.var) ? true : false;
        }
        public static bool operator ==(int64_t var1, uint64_t var2)    /* == */
        {
            return (var1.var == (Int64)var2.var) ? true : false;
        }
        public static bool operator !=(int64_t var1, uint64_t var2)    /* > */
        {
            return (var1.var != (Int64)var2.var) ? true : false;
        }
        #endregion
        #region int
        /* Math */
        public static int64_t operator +(int64_t var1, int var2)       /* + */
        {
            int64_t result = new int64_t((Int64)(var1.var + var2));
            return result;
        }
        public static int64_t operator -(int64_t var1, int var2)       /* - */
        {
            int64_t result = new int64_t((Int64)(var1.var - var2));
            return result;
        }
        public static int64_t operator *(int64_t var1, int var2)       /* * */
        {
            int64_t result = new int64_t((Int64)((Int64)var1.var * var2));
            return result;
        }
        public static int64_t operator /(int64_t var1, int var2)       /* / */
        {
            int64_t result = new int64_t((Int64)((Int64)var1.var / var2));
            return result;
        }
        public static int64_t operator %(int64_t var1, int var2)       /* % */
        {
            int64_t result = new int64_t((Int64)((Int64)var1.var % var2));
            return result;
        }
        public static int64_t operator &(int64_t var1, int var2)       /* & */
        {
            int64_t result = new int64_t((Int64)((Int64)var1.var & var2));
            return result;
        }
        public static int64_t operator |(int64_t var1, int var2)       /* | */
        {
            int64_t result = new int64_t((Int64)var1.var | (Int64)var2);
            return result;
        }
        public static int64_t operator ^(int64_t var1, int var2)       /* ^ */
        {
            int64_t result = new int64_t((Int64)((Int64)var1.var ^ var2));
            return result;
        }

        /* Comparison */
        public static bool operator >(int64_t var1, int var2)     /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int64_t var1, int var2)     /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int64_t var1, int var2)    /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int64_t var1, int var2)    /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int64_t var1, int var2)    /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int64_t var1, int var2)    /* > */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Math */
        public static int64_t operator +(int64_t var1, byte var2)       /* + */
        {
            int64_t result = new int64_t((Int64)(var1.var + var2));
            return result;
        }
        public static int64_t operator -(int64_t var1, byte var2)       /* - */
        {
            int64_t result = new int64_t((Int64)(var1.var - var2));
            return result;
        }
        public static int64_t operator *(int64_t var1, byte var2)       /* * */
        {
            int64_t result = new int64_t((Int64)var1.var * var2);
            return result;
        }
        public static int64_t operator /(int64_t var1, byte var2)       /* / */
        {
            int64_t result = new int64_t((Int64)var1.var / var2);
            return result;
        }
        public static int64_t operator %(int64_t var1, byte var2)       /* % */
        {
            int64_t result = new int64_t((Int64)var1.var % var2);
            return result;
        }
        public static int64_t operator &(int64_t var1, byte var2)       /* & */
        {
            int64_t result = new int64_t((Int64)var1.var & var2);
            return result;
        }
        public static int64_t operator |(int64_t var1, byte var2)       /* | */
        {
            int64_t result = new int64_t((Int64)var1.var | (Int64)var2);
            return result;
        }
        public static int64_t operator ^(int64_t var1, byte var2)       /* ^ */
        {
            int64_t result = new int64_t((Int64)var1.var ^ var2);
            return result;
        }

        /* Comparison */
        public static bool operator >(int64_t var1, byte var2)     /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int64_t var1, byte var2)     /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int64_t var1, byte var2)    /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int64_t var1, byte var2)    /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int64_t var1, byte var2)    /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int64_t var1, byte var2)    /* > */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region specials
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return var.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }

    /****************************** uint64_t **********************************/
    class uint64_t
    {
        public UInt64 var
        {
            get
            {
                return var;
            }
            set
            {
                var = value;
            }
        }

        #region Constructors
        public uint64_t() { var = 0; }
        public uint64_t(byte value) { var = (UInt64)value; }
        public uint64_t(SByte value) { var = (UInt64)value; }
        public uint64_t(Int16 value) { var = (UInt64)value; }
        public uint64_t(UInt16 value) { var = (UInt64)value; }
        public uint64_t(int value) { var = (UInt64)value; }
        public uint64_t(UInt32 value) { var = (UInt64)value; }
        public uint64_t(Int64 value) { var = (UInt64)value; }
        public uint64_t(UInt64 value) { var = value; }
        public uint64_t(int8_t value) { var = (UInt64)value.var; }
        public uint64_t(uint8_t value) { var = (UInt64)value.var; }
        public uint64_t(int16_t value) { var = (UInt64)value.var; }
        public uint64_t(uint16_t value) { var = (UInt64)value.var; }
        public uint64_t(int32_t value) { var = (UInt64)value.var; }
        public uint64_t(uint32_t value) { var = (UInt64)value.var; }
        public uint64_t(int64_t value) { var = (UInt64)value.var; }
        public uint64_t(uint64_t value) { var = value.var; }
        #endregion

        #region int8_t
        /* Math */
        public static uint64_t operator +(uint64_t var1, int8_t var2)       /* + */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var + (byte)var2.var));
            return result;
        }
        public static uint64_t operator -(uint64_t var1, int8_t var2)       /* - */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var - (byte)var2.var));
            return result;
        }
        public static uint64_t operator *(uint64_t var1, int8_t var2)       /* * */
        {
            uint64_t result = new uint64_t((UInt64)((UInt64)var1.var * (byte)var2.var));
            return result;
        }
        public static uint64_t operator /(uint64_t var1, int8_t var2)       /* / */
        {
            uint64_t result = new uint64_t((UInt64)((UInt64)var1.var / (byte)var2.var));
            return result;
        }
        public static uint64_t operator %(uint64_t var1, int8_t var2)       /* % */
        {
            uint64_t result = new uint64_t((UInt64)((UInt64)var1.var % (byte)var2.var));
            return result;
        }
        public static uint64_t operator &(uint64_t var1, int8_t var2)       /* & */
        {
            uint64_t result = new uint64_t((UInt64)((UInt64)var1.var & (byte)var2.var));
            return result;
        }
        public static uint64_t operator |(uint64_t var1, int8_t var2)       /* | */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var | (byte)(var2.var)));
            return result;
        }
        public static uint64_t operator ^(uint64_t var1, int8_t var2)       /* ^ */
        {
            uint64_t result = new uint64_t((UInt64)((UInt64)var1.var ^ (byte)var2.var));
            return result;
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, int8_t var2)     /* > */
        {
            return (var1.var > (byte)var2.var) ? true : false;
        }
        public static bool operator <(uint64_t var1, int8_t var2)     /* < */
        {
            return (var1.var < (byte)var2.var) ? true : false;
        }
        public static bool operator <=(uint64_t var1, int8_t var2)    /* <= */
        {
            return (var1.var <= (byte)var2.var) ? true : false;
        }
        public static bool operator >=(uint64_t var1, int8_t var2)    /* >= */
        {
            return (var1.var >= (byte)var2.var) ? true : false;
        }
        public static bool operator ==(uint64_t var1, int8_t var2)    /* == */
        {
            return (var1.var == (byte)var2.var) ? true : false;
        }
        public static bool operator !=(uint64_t var1, int8_t var2)    /* > */
        {
            return (var1.var != (byte)var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Math */
        public static uint64_t operator +(uint64_t var1, uint8_t var2)       /* + */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var + var2.var));
            return result;
        }
        public static uint64_t operator -(uint64_t var1, uint8_t var2)       /* - */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var - var2.var));
            return result;
        }
        public static uint64_t operator *(uint64_t var1, uint8_t var2)       /* * */
        {
            uint64_t result = new uint64_t((UInt64)var1.var * var2.var);
            return result;
        }
        public static uint64_t operator /(uint64_t var1, uint8_t var2)       /* / */
        {
            uint64_t result = new uint64_t((UInt64)var1.var / var2.var);
            return result;
        }
        public static uint64_t operator %(uint64_t var1, uint8_t var2)       /* % */
        {
            uint64_t result = new uint64_t((UInt64)var1.var % var2.var);
            return result;
        }
        public static uint64_t operator &(uint64_t var1, uint8_t var2)       /* & */
        {
            uint64_t result = new uint64_t((UInt64)var1.var & var2.var);
            return result;
        }
        public static uint64_t operator |(uint64_t var1, uint8_t var2)       /* | */
        {
            uint64_t result = new uint64_t((UInt64)var1.var | (UInt64)var2.var);
            return result;
        }
        public static uint64_t operator ^(uint64_t var1, uint8_t var2)       /* ^ */
        {
            uint64_t result = new uint64_t((UInt64)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, uint8_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint64_t var1, uint8_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint64_t var1, uint8_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint64_t var1, uint8_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint64_t var1, uint8_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint64_t var1, uint8_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        public static uint64_t operator +(uint64_t var1, int16_t var2)       /* + */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var + (UInt16)var2.var));
            return result;
        }
        public static uint64_t operator -(uint64_t var1, int16_t var2)       /* - */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var - (UInt16)var2.var));
            return result;
        }
        public static uint64_t operator *(uint64_t var1, int16_t var2)       /* * */
        {
            uint64_t result = new uint64_t((UInt64)((UInt64)var1.var * (UInt16)var2.var));
            return result;
        }
        public static uint64_t operator /(uint64_t var1, int16_t var2)       /* / */
        {
            uint64_t result = new uint64_t((UInt64)((UInt64)var1.var / (UInt16)var2.var));
            return result;
        }
        public static uint64_t operator %(uint64_t var1, int16_t var2)       /* % */
        {
            uint64_t result = new uint64_t((UInt64)((UInt64)var1.var % (UInt16)var2.var));
            return result;
        }
        public static uint64_t operator &(uint64_t var1, int16_t var2)       /* & */
        {
            uint64_t result = new uint64_t((UInt64)((UInt64)var1.var & (UInt16)var2.var));
            return result;
        }
        public static uint64_t operator |(uint64_t var1, int16_t var2)       /* | */
        {
            uint64_t result = new uint64_t(var1.var | (UInt16)var2.var);
            return result;
        }
        public static uint64_t operator ^(uint64_t var1, int16_t var2)       /* ^ */
        {
            uint64_t result = new uint64_t((UInt64)((UInt64)var1.var ^ (UInt16)var2.var));
            return result;
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, int16_t var2)     /* > */
        {
            return (var1.var > (UInt16)var2.var) ? true : false;
        }
        public static bool operator <(uint64_t var1, int16_t var2)     /* < */
        {
            return (var1.var < (UInt16)var2.var) ? true : false;
        }
        public static bool operator <=(uint64_t var1, int16_t var2)    /* <= */
        {
            return (var1.var <= (UInt16)var2.var) ? true : false;
        }
        public static bool operator >=(uint64_t var1, int16_t var2)    /* >= */
        {
            return (var1.var >= (UInt16)var2.var) ? true : false;
        }
        public static bool operator ==(uint64_t var1, int16_t var2)    /* == */
        {
            return (var1.var == (UInt16)var2.var) ? true : false;
        }
        public static bool operator !=(uint64_t var1, int16_t var2)    /* > */
        {
            return (var1.var != (UInt16)var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        public static uint64_t operator +(uint64_t var1, uint16_t var2)       /* + */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var + var2.var));
            return result;
        }
        public static uint64_t operator -(uint64_t var1, uint16_t var2)       /* - */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var - var2.var));
            return result;
        }
        public static uint64_t operator *(uint64_t var1, uint16_t var2)       /* * */
        {
            uint64_t result = new uint64_t((UInt64)var1.var * var2.var);
            return result;
        }
        public static uint64_t operator /(uint64_t var1, uint16_t var2)       /* / */
        {
            uint64_t result = new uint64_t((UInt64)var1.var / var2.var);
            return result;
        }
        public static uint64_t operator %(uint64_t var1, uint16_t var2)       /* % */
        {
            uint64_t result = new uint64_t((UInt64)var1.var % var2.var);
            return result;
        }
        public static uint64_t operator &(uint64_t var1, uint16_t var2)       /* & */
        {
            uint64_t result = new uint64_t((UInt64)var1.var & var2.var);
            return result;
        }
        public static uint64_t operator |(uint64_t var1, uint16_t var2)       /* | */
        {
            uint64_t result = new uint64_t((UInt64)var1.var | (UInt64)var2.var);
            return result;
        }
        public static uint64_t operator ^(uint64_t var1, uint16_t var2)       /* ^ */
        {
            uint64_t result = new uint64_t((UInt64)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, uint16_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint64_t var1, uint16_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint64_t var1, uint16_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint64_t var1, uint16_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint64_t var1, uint16_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint64_t var1, uint16_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        public static uint64_t operator +(uint64_t var1, int32_t var2)       /* + */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var + (UInt32)var2.var));
            return result;
        }
        public static uint64_t operator -(uint64_t var1, int32_t var2)       /* - */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var - (UInt32)var2.var));
            return result;
        }
        public static uint64_t operator *(uint64_t var1, int32_t var2)       /* * */
        {
            uint64_t result = new uint64_t((UInt64)((UInt64)var1.var * (UInt32)var2.var));
            return result;
        }
        public static uint64_t operator /(uint64_t var1, int32_t var2)       /* / */
        {
            uint64_t result = new uint64_t((UInt64)((UInt64)var1.var / (UInt32)var2.var));
            return result;
        }
        public static uint64_t operator %(uint64_t var1, int32_t var2)       /* % */
        {
            uint64_t result = new uint64_t((UInt64)((UInt64)var1.var % (UInt32)var2.var));
            return result;
        }
        public static uint64_t operator &(uint64_t var1, int32_t var2)       /* & */
        {
            uint64_t result = new uint64_t((UInt64)((UInt64)var1.var & (UInt32)var2.var));
            return result;
        }
        public static uint64_t operator |(uint64_t var1, int32_t var2)       /* | */
        {
            uint64_t result = new uint64_t(var1.var | (UInt32)var2.var);
            return result;
        }
        public static uint64_t operator ^(uint64_t var1, int32_t var2)       /* ^ */
        {
            uint64_t result = new uint64_t((UInt64)((UInt64)var1.var ^ (UInt32)var2.var));
            return result;
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, int32_t var2)     /* > */
        {
            return (var1.var > (UInt32)var2.var) ? true : false;
        }
        public static bool operator <(uint64_t var1, int32_t var2)     /* < */
        {
            return (var1.var < (UInt32)var2.var) ? true : false;
        }
        public static bool operator <=(uint64_t var1, int32_t var2)    /* <= */
        {
            return (var1.var <= (UInt32)var2.var) ? true : false;
        }
        public static bool operator >=(uint64_t var1, int32_t var2)    /* >= */
        {
            return (var1.var >= (UInt32)var2.var) ? true : false;
        }
        public static bool operator ==(uint64_t var1, int32_t var2)    /* == */
        {
            return (var1.var == (UInt32)var2.var) ? true : false;
        }
        public static bool operator !=(uint64_t var1, int32_t var2)    /* > */
        {
            return (var1.var != (UInt32)var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Math */
        public static uint64_t operator +(uint64_t var1, uint32_t var2)       /* + */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var + var2.var));
            return result;
        }
        public static uint64_t operator ++(uint64_t var1)                   /* ++ */
        {
            var1.var++;
            return var1;
        }
        public static uint64_t operator -(uint64_t var1, uint32_t var2)       /* - */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var - var2.var));
            return result;
        }
        public static uint64_t operator --(uint64_t var1)                   /* -- */
        {
            var1.var--;
            return var1;
        }
        public static uint64_t operator *(uint64_t var1, uint32_t var2)       /* * */
        {
            uint64_t result = new uint64_t((UInt64)var1.var * var2.var);
            return result;
        }
        public static uint64_t operator /(uint64_t var1, uint32_t var2)       /* / */
        {
            uint64_t result = new uint64_t((UInt64)var1.var / var2.var);
            return result;
        }
        public static uint64_t operator %(uint64_t var1, uint32_t var2)       /* % */
        {
            uint64_t result = new uint64_t((UInt64)var1.var % var2.var);
            return result;
        }
        public static uint64_t operator &(uint64_t var1, uint32_t var2)       /* & */
        {
            uint64_t result = new uint64_t((UInt64)var1.var & var2.var);
            return result;
        }
        public static uint64_t operator |(uint64_t var1, uint32_t var2)       /* | */
        {
            uint64_t result = new uint64_t(var1.var | var2.var);
            return result;
        }
        public static uint64_t operator ^(uint64_t var1, uint32_t var2)       /* ^ */
        {
            uint64_t result = new uint64_t((UInt64)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, uint32_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint64_t var1, uint32_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint64_t var1, uint32_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint64_t var1, uint32_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint64_t var1, uint32_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint64_t var1, uint32_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        public static uint64_t operator +(uint64_t var1, int64_t var2)       /* + */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var + (UInt64)var2.var));
            return result;
        }
        public static uint64_t operator -(uint64_t var1, int64_t var2)       /* - */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var - (UInt64)var2.var));
            return result;
        }
        public static uint64_t operator *(uint64_t var1, int64_t var2)       /* * */
        {
            uint64_t result = new uint64_t((UInt64)var1.var * (UInt64)var2.var);
            return result;
        }
        public static uint64_t operator /(uint64_t var1, int64_t var2)       /* / */
        {
            uint64_t result = new uint64_t((UInt64)var1.var / (UInt64)var2.var);
            return result;
        }
        public static uint64_t operator %(uint64_t var1, int64_t var2)       /* % */
        {
            uint64_t result = new uint64_t((UInt64)var1.var % (UInt64)var2.var);
            return result;
        }
        public static uint64_t operator &(uint64_t var1, int64_t var2)       /* & */
        {
            uint64_t result = new uint64_t((UInt64)var1.var & (UInt64)var2.var);
            return result;
        }
        public static uint64_t operator |(uint64_t var1, int64_t var2)       /* | */
        {
            uint64_t result = new uint64_t((UInt64)var1.var | (UInt64)var2.var);
            return result;
        }
        public static uint64_t operator ^(uint64_t var1, int64_t var2)       /* ^ */
        {
            uint64_t result = new uint64_t((UInt64)var1.var ^ (UInt64)var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, int64_t var2)     /* > */
        {
            return (var1.var > (UInt64)var2.var) ? true : false;
        }
        public static bool operator <(uint64_t var1, int64_t var2)     /* < */
        {
            return (var1.var < (UInt64)var2.var) ? true : false;
        }
        public static bool operator <=(uint64_t var1, int64_t var2)    /* <= */
        {
            return (var1.var <= (UInt64)var2.var) ? true : false;
        }
        public static bool operator >=(uint64_t var1, int64_t var2)    /* >= */
        {
            return (var1.var >= (UInt64)var2.var) ? true : false;
        }
        public static bool operator ==(uint64_t var1, int64_t var2)    /* == */
        {
            return (var1.var == (UInt64)var2.var) ? true : false;
        }
        public static bool operator !=(uint64_t var1, int64_t var2)    /* > */
        {
            return (var1.var != (UInt64)var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        public static uint64_t operator +(uint64_t var1, uint64_t var2)       /* + */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var + var2.var));
            return result;
        }
        public static uint64_t operator -(uint64_t var1, uint64_t var2)       /* - */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var - var2.var));
            return result;
        }
        public static uint64_t operator *(uint64_t var1, uint64_t var2)       /* * */
        {
            uint64_t result = new uint64_t((UInt64)var1.var * var2.var);
            return result;
        }
        public static uint64_t operator /(uint64_t var1, uint64_t var2)       /* / */
        {
            uint64_t result = new uint64_t((UInt64)var1.var / var2.var);
            return result;
        }
        public static uint64_t operator %(uint64_t var1, uint64_t var2)       /* % */
        {
            uint64_t result = new uint64_t((UInt64)var1.var % var2.var);
            return result;
        }
        public static uint64_t operator &(uint64_t var1, uint64_t var2)       /* & */
        {
            uint64_t result = new uint64_t((UInt64)var1.var & var2.var);
            return result;
        }
        public static uint64_t operator |(uint64_t var1, uint64_t var2)       /* | */
        {
            uint64_t result = new uint64_t((UInt64)var1.var | (UInt64)var2.var);
            return result;
        }
        public static uint64_t operator ^(uint64_t var1, uint64_t var2)       /* ^ */
        {
            uint64_t result = new uint64_t((UInt64)var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, uint64_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint64_t var1, uint64_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint64_t var1, uint64_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint64_t var1, uint64_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint64_t var1, uint64_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint64_t var1, uint64_t var2)    /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int
        /* Math */
        public static uint64_t operator +(uint64_t var1, int var2)       /* + */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var + (UInt32)var2));
            return result;
        }
        public static uint64_t operator -(uint64_t var1, int var2)       /* - */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var - (UInt32)var2));
            return result;
        }
        public static uint64_t operator *(uint64_t var1, int var2)       /* * */
        {
            uint64_t result = new uint64_t((UInt64)((UInt64)var1.var * (UInt32)var2));
            return result;
        }
        public static uint64_t operator /(uint64_t var1, int var2)       /* / */
        {
            uint64_t result = new uint64_t((UInt64)((UInt64)var1.var / (UInt32)var2));
            return result;
        }
        public static uint64_t operator %(uint64_t var1, int var2)       /* % */
        {
            uint64_t result = new uint64_t((UInt64)((UInt64)var1.var % (UInt32)var2));
            return result;
        }
        public static uint64_t operator &(uint64_t var1, int var2)       /* & */
        {
            uint64_t result = new uint64_t((UInt64)((UInt64)var1.var & (UInt32)var2));
            return result;
        }
        public static uint64_t operator |(uint64_t var1, int var2)       /* | */
        {
            uint64_t result = new uint64_t(var1.var | (UInt32)var2);
            return result;
        }
        public static uint64_t operator ^(uint64_t var1, int var2)       /* ^ */
        {
            uint64_t result = new uint64_t((UInt64)((UInt64)var1.var ^ (UInt32)var2));
            return result;
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, int var2)     /* > */
        {
            return (var1.var > (UInt32)var2) ? true : false;
        }
        public static bool operator <(uint64_t var1, int var2)     /* < */
        {
            return (var1.var < (UInt32)var2) ? true : false;
        }
        public static bool operator <=(uint64_t var1, int var2)    /* <= */
        {
            return (var1.var <= (UInt32)var2) ? true : false;
        }
        public static bool operator >=(uint64_t var1, int var2)    /* >= */
        {
            return (var1.var >= (UInt32)var2) ? true : false;
        }
        public static bool operator ==(uint64_t var1, int var2)    /* == */
        {
            return (var1.var == (UInt32)var2) ? true : false;
        }
        public static bool operator !=(uint64_t var1, int var2)    /* > */
        {
            return (var1.var != (UInt32)var2) ? true : false;
        }
        #endregion
        #region byte
        /* Math */
        public static uint64_t operator +(uint64_t var1, byte var2)       /* + */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var + var2));
            return result;
        }
        public static uint64_t operator -(uint64_t var1, byte var2)       /* - */
        {
            uint64_t result = new uint64_t((UInt64)(var1.var - var2));
            return result;
        }
        public static uint64_t operator *(uint64_t var1, byte var2)       /* * */
        {
            uint64_t result = new uint64_t((UInt64)var1.var * var2);
            return result;
        }
        public static uint64_t operator /(uint64_t var1, byte var2)       /* / */
        {
            uint64_t result = new uint64_t((UInt64)var1.var / var2);
            return result;
        }
        public static uint64_t operator %(uint64_t var1, byte var2)       /* % */
        {
            uint64_t result = new uint64_t((UInt64)var1.var % var2);
            return result;
        }
        public static uint64_t operator &(uint64_t var1, byte var2)       /* & */
        {
            uint64_t result = new uint64_t((UInt64)var1.var & var2);
            return result;
        }
        public static uint64_t operator |(uint64_t var1, byte var2)       /* | */
        {
            uint64_t result = new uint64_t((UInt64)var1.var | (UInt64)var2);
            return result;
        }
        public static uint64_t operator ^(uint64_t var1, byte var2)       /* ^ */
        {
            uint64_t result = new uint64_t((UInt64)var1.var ^ var2);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, byte var2)     /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint64_t var1, byte var2)     /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint64_t var1, byte var2)    /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint64_t var1, byte var2)    /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint64_t var1, byte var2)    /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint64_t var1, byte var2)    /* > */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region specials
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return var.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}