using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*****************************************************************************/
/* TODO:
 * - bool support
 * - sbyte, short, ushort, uint, long and ulong support
 * - float and double support
 * - size_t
 * - parsing, strings
 * - Compares
 * - Lists & arrays
 * */

namespace stdint
{
    /****************************** int8_t ***********************************/
    class int8_t
    {
        public SByte var = 0;

        #region Constructors
        public int8_t()                 { var = 0; }
        public int8_t(byte value)       { var = (SByte)value; }
        public int8_t(SByte value)      { var = value; }
        public int8_t(Int16 value)      { var = (SByte)value; }
        public int8_t(UInt16 value)     { var = (SByte)value; }
        public int8_t(int value)        { var = (SByte)value; }
        public int8_t(UInt32 value)     { var = (SByte)value; }
        public int8_t(Int64 value)      { var = (SByte)value; }
        public int8_t(UInt64 value)     { var = (SByte)value; }
        public int8_t(int8_t value)     { var = value.var; }
        public int8_t(uint8_t value)    { var = (SByte)value.var; }
        public int8_t(int16_t value)    { var = (SByte)value.var; }
        public int8_t(uint16_t value)   { var = (SByte)value.var; }
        public int8_t(int32_t value)    { var = (SByte)value.var; }
        public int8_t(uint32_t value)   { var = (SByte)value.var; }
        public int8_t(int64_t value)    { var = (SByte)value.var; }
        public int8_t(uint64_t value)   { var = (SByte)value.var; }
        #endregion

        #region int8_t
        /* Assignment */
        public static implicit operator sbyte(int8_t obj)
        {
            return obj.var;
        }

        public static implicit operator int8_t(sbyte var)
        {
            return new int8_t(var);
        }

        /* Math */
        public static int8_t operator +(int8_t var1, int8_t var2)       /* + */
        {
            return new int8_t(var1.var + var2.var);
        }
        public static int8_t operator ++(int8_t var1)                   /* ++ */
        {
            return (var1.var++);
        }
        public static int8_t operator -(int8_t var1, int8_t var2)       /* - */
        {
            return new int8_t(var1.var - var2.var);
        }
        public static int8_t operator --(int8_t var1)                   /* -- */
        {
            return (var1.var--);
        }
        public static int8_t operator *(int8_t var1, int8_t var2)       /* * */
        {
            return new int8_t(var1.var * var2.var);
        }
        public static int8_t operator /(int8_t var1, int8_t var2)       /* / */
        {
            return new int8_t(var1.var / var2.var);
        }
        public static int8_t operator %(int8_t var1, int8_t var2)       /* % */
        {
            return new int8_t(var1.var % var2.var);
        }
        public static int8_t operator &(int8_t var1, int8_t var2)       /* & */
        {
            return new int8_t(var1.var & var2.var);
        }
        public static int8_t operator |(int8_t var1, int8_t var2)       /* | */
        {
            return new int8_t(var1.var | var2.var);
        }
        public static int8_t operator ^(int8_t var1, int8_t var2)       /* ^ */
        {
            return new int8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, int8_t var2)         /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, int8_t var2)         /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, int8_t var2)        /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, int8_t var2)        /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, int8_t var2)        /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, int8_t var2)        /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Assignment */
        public static implicit operator byte(int8_t obj)
        {
            return (byte)obj.var;
        }

        public static implicit operator int8_t(byte var)
        {
            return new int8_t(var);
        }

        /* Math */
        public static int8_t operator +(int8_t var1, uint8_t var2)       /* + */
        {
            return new int8_t(var1.var + var2.var);
        }
        public static int8_t operator -(int8_t var1, uint8_t var2)       /* - */
        {
            return new int8_t(var1.var - var2.var);
        }
        public static int8_t operator *(int8_t var1, uint8_t var2)       /* * */
        {
            return new int8_t(var1.var * var2.var);
        }
        public static int8_t operator /(int8_t var1, uint8_t var2)       /* / */
        {
            return new int8_t(var1.var * var2.var);
        }
        public static int8_t operator %(int8_t var1, uint8_t var2)       /* % */
        {
            return new int8_t(var1.var % var2.var);
        }
        public static int8_t operator &(int8_t var1, uint8_t var2)       /* & */
        {
            return new int8_t(var1.var & var2.var);
        }
        public static int8_t operator |(int8_t var1, uint8_t var2)       /* | */
        {
            return new int8_t((byte)var1.var | var2.var);
        }
        public static int8_t operator ^(int8_t var1, uint8_t var2)       /* ^ */
        {
            return new int8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, uint8_t var2)        /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, uint8_t var2)        /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, uint8_t var2)       /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, uint8_t var2)       /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, uint8_t var2)       /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, uint8_t var2)       /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        /* Assignment */
        public static implicit operator Int16(int8_t obj)
        {
            return obj.var;
        }

        public static implicit operator int8_t(Int16 var)
        {
            return new int8_t(var);
        }

        /* Math */
        public static int8_t operator +(int8_t var1, int16_t var2)       /* + */
        {
            return new int8_t(var1.var + var2.var);
        }
        public static int8_t operator -(int8_t var1, int16_t var2)       /* - */
        {
            return new int8_t(var1.var - var2.var);
        }
        public static int8_t operator *(int8_t var1, int16_t var2)       /* * */
        {
            return new int8_t(var1.var * var2.var);
        }
        public static int8_t operator /(int8_t var1, int16_t var2)       /* / */
        {
            return new int8_t(var1.var / var2.var);
        }
        public static int8_t operator %(int8_t var1, int16_t var2)       /* % */
        {
            return new int8_t(var1.var % var2.var);
        }
        public static int8_t operator &(int8_t var1, int16_t var2)       /* & */
        {
            return new int8_t(var1.var & var2.var);
        }
        public static int8_t operator |(int8_t var1, int16_t var2)       /* | */
        {
            return new int8_t((byte)var1.var | (UInt16)var2.var);
        }
        public static int8_t operator ^(int8_t var1, int16_t var2)       /* ^ */
        {
            return new int8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, int16_t var2)        /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, int16_t var2)        /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, int16_t var2)       /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, int16_t var2)       /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, int16_t var2)       /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, int16_t var2)       /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        /* Assignment */
        public static implicit operator UInt16(int8_t obj)
        {
            return (ushort)obj.var;
        }

        public static implicit operator int8_t(UInt16 var)
        {
            return new int8_t(var);
        }

        /* Math */
        public static int8_t operator +(int8_t var1, uint16_t var2)     /* + */
        {
            return new int8_t(var1.var + var2.var);
        }
        public static int8_t operator -(int8_t var1, uint16_t var2)     /* - */
        {
            return new int8_t(var1.var - var2.var);
        }
        public static int8_t operator *(int8_t var1, uint16_t var2)     /* * */
        {
            return new int8_t(var1.var * var2.var);
        }
        public static int8_t operator /(int8_t var1, uint16_t var2)     /* / */
        {
            return new int8_t(var1.var / var2.var);
        }
        public static int8_t operator %(int8_t var1, uint16_t var2)     /* % */
        {
            return new int8_t(var1.var % var2.var);
        }
        public static int8_t operator &(int8_t var1, uint16_t var2)     /* & */
        {
            return new int8_t(var1.var & var2.var);
        }
        public static int8_t operator |(int8_t var1, uint16_t var2)     /* | */
        {
            return new int8_t((byte)var1.var | var2.var);
        }
        public static int8_t operator ^(int8_t var1, uint16_t var2)     /* ^ */
        {
            return new int8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, uint16_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, uint16_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, uint16_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, uint16_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, uint16_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, uint16_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        /* Assignment */
        public static implicit operator Int32(int8_t obj)
        {
            return obj.var;
        }

        public static implicit operator int8_t(Int32 var)
        {
            return new int8_t(var);
        }

        /* Math */
        public static int8_t operator +(int8_t var1, int32_t var2)      /* + */
        {
            return new int8_t(var1.var + var2.var);
        }
        public static int8_t operator -(int8_t var1, int32_t var2)      /* - */
        {
            return new int8_t(var1.var - var2.var);
        }
        public static int8_t operator *(int8_t var1, int32_t var2)      /* * */
        {
            return new int8_t(var1.var * var2.var);
        }
        public static int8_t operator /(int8_t var1, int32_t var2)      /* / */
        {
            return new int8_t(var1.var / var2.var);
        }
        public static int8_t operator %(int8_t var1, int32_t var2)      /* % */
        {
            return new int8_t(var1.var % var2.var);
        }
        public static int8_t operator &(int8_t var1, int32_t var2)      /* & */
        {
            return new int8_t(var1.var & var2.var);
        }
        public static int8_t operator |(int8_t var1, int32_t var2)      /* | */
        {
            return new int8_t((byte)var1.var | var2.var);
        }
        public static int8_t operator ^(int8_t var1, int32_t var2)      /* ^ */
        {
            return new int8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, int32_t var2)        /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, int32_t var2)        /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, int32_t var2)       /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, int32_t var2)       /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, int32_t var2)       /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, int32_t var2)       /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Assignment */
        public static implicit operator UInt32(int8_t obj)
        {
            return (uint)obj.var;
        }

        public static implicit operator int8_t(UInt32 var)
        {
            return new int8_t(var);
        }

        /* Math */
        public static int8_t operator +(int8_t var1, uint32_t var2)     /* + */
        {
            return new int8_t(var1.var + var2.var);
        }
        public static int8_t operator -(int8_t var1, uint32_t var2)     /* - */
        {
            return new int8_t(var1.var - var2.var);
        }
        public static int8_t operator *(int8_t var1, uint32_t var2)     /* * */
        {
            return new int8_t(var1.var * var2.var);
        }
        public static int8_t operator /(int8_t var1, uint32_t var2)     /* / */
        {
            return new int8_t(var1.var / var2.var);
        }
        public static int8_t operator %(int8_t var1, uint32_t var2)     /* % */
        {
            return new int8_t(var1.var % var2.var);
        }
        public static int8_t operator &(int8_t var1, uint32_t var2)     /* & */
        {
            return new int8_t(var1.var & var2.var);
        }
        public static int8_t operator |(int8_t var1, uint32_t var2)     /* | */
        {
            return new int8_t((byte)var1.var |var2.var);
        }
        public static int8_t operator ^(int8_t var1, uint32_t var2)     /* ^ */
        {
            return new int8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, uint32_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, uint32_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, uint32_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, uint32_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, uint32_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, uint32_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        /* Assignment */
        public static implicit operator Int64(int8_t obj)
        {
            return obj.var;
        }

        public static implicit operator int8_t(Int64 var)
        {
            return new int8_t(var);
        }

        /* Math */
        public static int8_t operator +(int8_t var1, int64_t var2)      /* + */
        {
            return new int8_t(var1.var + var2.var);
        }
        public static int8_t operator -(int8_t var1, int64_t var2)      /* - */
        {
            return new int8_t(var1.var - var2.var);
        }
        public static int8_t operator *(int8_t var1, int64_t var2)      /* * */
        {
            return new int8_t(var1.var * var2.var);
        }
        public static int8_t operator /(int8_t var1, int64_t var2)      /* / */
        {
            return new int8_t(var1.var / var2.var);
        }
        public static int8_t operator %(int8_t var1, int64_t var2)      /* % */
        {
            return new int8_t(var1.var % var2.var);
        }
        public static int8_t operator &(int8_t var1, int64_t var2)      /* & */
        {
            int8_t result = new int8_t(var1.var & var2.var);
            return new int8_t(var1.var & var2.var);
        }
        public static int8_t operator |(int8_t var1, int64_t var2)      /* | */
        {
            return new int8_t((byte)var1.var | (ulong)var2.var);
        }
        public static int8_t operator ^(int8_t var1, int64_t var2)      /* ^ */
        {
            return new int8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, int64_t var2)        /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, int64_t var2)        /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, int64_t var2)       /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, int64_t var2)       /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, int64_t var2)       /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, int64_t var2)       /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        /* Assignment */
        public static implicit operator UInt64(int8_t obj)
        {
            return (ulong)obj.var;
        }

        public static implicit operator int8_t(UInt64 var)
        {
            return new int8_t(var);
        }

        /* Math */
        public static int8_t operator +(int8_t var1, uint64_t var2)     /* + */
        {
            return new int8_t((ulong)var1.var + var2.var);
        }
        public static int8_t operator -(int8_t var1, uint64_t var2)     /* - */
        {
            return new int8_t((ulong)var1.var - var2.var);
        }
        public static int8_t operator *(int8_t var1, uint64_t var2)     /* * */
        {
            return new int8_t((ulong)var1.var * var2.var);
        }
        public static int8_t operator /(int8_t var1, uint64_t var2)     /* / */
        {
            return new int8_t((ulong)var1.var / var2.var);
        }
        public static int8_t operator %(int8_t var1, uint64_t var2)     /* % */
        {
            return new int8_t((ulong)var1.var / var2.var);
        }
        public static int8_t operator &(int8_t var1, uint64_t var2)     /* & */
        {
            return new int8_t((ulong)var1.var & var2.var);
        }
        public static int8_t operator |(int8_t var1, uint64_t var2)     /* | */
        {
            return new int8_t((byte)var1.var | var2.var);
        }
        public static int8_t operator ^(int8_t var1, uint64_t var2)     /* ^ */
        {
            return new int8_t((ulong)var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, uint64_t var2)       /* > */
        {
            return ((UInt64)var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, uint64_t var2)       /* < */
        {
            return ((UInt64)var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, uint64_t var2)      /* <= */
        {
            return ((UInt64)var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, uint64_t var2)      /* >= */
        {
            return ((UInt64)var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, uint64_t var2)      /* == */
        {
            return ((UInt64)var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, uint64_t var2)      /* != */
        {
            return ((UInt64)var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int
        /* Math */
        public static int8_t operator +(int8_t var1, int var2)          /* + */
        {
            return new int8_t(var1.var + var2);
        }
        public static int8_t operator -(int8_t var1, int var2)          /* - */
        {
            return new int8_t(var1.var - var2);
        }
        public static int8_t operator *(int8_t var1, int var2)          /* * */
        {
            return new int8_t(var1.var * var2);
        }
        public static int8_t operator /(int8_t var1, int var2)          /* / */
        {
            int8_t result = new int8_t((int)var1.var / var2);
            return new int8_t(var1.var / var2);
        }
        public static int8_t operator %(int8_t var1, int var2)          /* % */
        {
            return new int8_t(var1.var % var2);
        }
        public static int8_t operator &(int8_t var1, int var2)          /* & */
        {
            return new int8_t(var1.var & var2);
        }
        public static int8_t operator |(int8_t var1, int var2)          /* | */
        {
            return new int8_t((byte)var1.var | (uint)var2);
        }
        public static int8_t operator ^(int8_t var1, int var2)          /* ^ */
        {
            return new int8_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, int var2)            /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int8_t var1, int var2)            /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int8_t var1, int var2)           /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int8_t var1, int var2)           /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int8_t var1, int var2)           /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int8_t var1, int var2)           /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Math */
        public static int8_t operator +(int8_t var1, byte var2)         /* + */
        {
            return new int8_t(var1.var + var2);
        }
        public static int8_t operator -(int8_t var1, byte var2)         /* - */
        {
            return new int8_t(var1.var - var2);
        }
        public static int8_t operator *(int8_t var1, byte var2)         /* * */
        {
            return new int8_t(var1.var * var2);
        }
        public static int8_t operator /(int8_t var1, byte var2)         /* / */
        {
            return new int8_t(var1.var / var2);
        }
        public static int8_t operator %(int8_t var1, byte var2)         /* % */
        {
            return new int8_t(var1.var % var2);
        }
        public static int8_t operator &(int8_t var1, byte var2)         /* & */
        {
            return new int8_t(var1.var & var2);
        }
        public static int8_t operator |(int8_t var1, byte var2)         /* | */
        {
            return new int8_t((byte)var1.var | var2);
        }
        public static int8_t operator ^(int8_t var1, byte var2)         /* != */
        {
            return new int8_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, byte var2)           /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int8_t var1, byte var2)           /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int8_t var1, byte var2)          /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int8_t var1, byte var2)          /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int8_t var1, byte var2)          /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int8_t var1, byte var2)          /* != */
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
        public byte var = 0;

        #region Constructors
        public uint8_t()                { var = 0; }
        public uint8_t(byte value)      { var = value; }
        public uint8_t(SByte value)     { var = (byte)value; }
        public uint8_t(Int16 value)     { var = (byte)value; }
        public uint8_t(UInt16 value)    { var = (byte)value; }
        public uint8_t(int value)       { var = (byte)value; }
        public uint8_t(UInt32 value)    { var = (byte)value; }
        public uint8_t(Int64 value)     { var = (byte)value; }
        public uint8_t(UInt64 value)    { var = (byte)value; }
        public uint8_t(int8_t value)    { var = (byte)value.var; }
        public uint8_t(uint8_t value)   { var = value.var; }
        public uint8_t(int16_t value)   { var = (byte)value.var; }
        public uint8_t(uint16_t value)  { var = (byte)value.var; }
        public uint8_t(int32_t value)   { var = (byte)value.var; }
        public uint8_t(uint32_t value)  { var = (byte)value.var; }
        public uint8_t(int64_t value)   { var = (byte)value.var; }
        public uint8_t(uint64_t value)  { var = (byte)value.var; }
        #endregion

        #region int8_t
        /* Assignment */
        public static implicit operator sbyte(uint8_t obj)
        {
            return (sbyte)obj.var;
        }

        public static implicit operator uint8_t(sbyte var)
        {
            return new uint8_t(var);
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, int8_t var2)     /* + */
        {
            return new uint8_t(var1.var + var2.var);
        }
        public static uint8_t operator -(uint8_t var1, int8_t var2)     /* - */
        {
            return new uint8_t(var1.var - var2.var);
        }
        public static uint8_t operator *(uint8_t var1, int8_t var2)     /* * */
        {
            return new uint8_t(var1.var * var2.var);
        }
        public static uint8_t operator /(uint8_t var1, int8_t var2)     /* / */
        {
            return new uint8_t(var1.var / var2.var);
        }
        public static uint8_t operator %(uint8_t var1, int8_t var2)     /* % */
        {
            return new uint8_t(var1.var % var2.var);
        }
        public static uint8_t operator &(uint8_t var1, int8_t var2)     /* & */
        {
            return new uint8_t(var1.var & var2.var);
        }
        public static uint8_t operator |(uint8_t var1, int8_t var2)     /* | */
        {
            return new uint8_t(var1.var | (byte)var2.var);
        }
        public static uint8_t operator ^(uint8_t var1, int8_t var2)     /* ^ */
        {
            return new uint8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, int8_t var2)        /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, int8_t var2)        /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, int8_t var2)       /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, int8_t var2)       /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, int8_t var2)       /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, int8_t var2)       /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Assignment */
        public static implicit operator byte(uint8_t obj)
        {
            return obj.var;
        }

        public static implicit operator uint8_t(byte var)
        {
            return new uint8_t(var);
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, uint8_t var2)    /* + */
        {
            return new uint8_t(var1.var + var2.var);
        }
        public static uint8_t operator ++(uint8_t var1)                 /* ++ */
        {
            return (var1.var++);
        }
        public static uint8_t operator -(uint8_t var1, uint8_t var2)    /* - */
        {
            return new uint8_t(var1.var - var2.var);
        }
        public static uint8_t operator --(uint8_t var1)                 /* -- */
        {
            return (var1.var--);
        }
        public static uint8_t operator *(uint8_t var1, uint8_t var2)    /* * */
        {
            return new uint8_t(var1.var * var2.var);
        }
        public static uint8_t operator /(uint8_t var1, uint8_t var2)    /* / */
        {
            return new uint8_t(var1.var / var2.var);
        }
        public static uint8_t operator %(uint8_t var1, uint8_t var2)    /* % */
        {
            return new uint8_t(var1.var % var2.var);
        }
        public static uint8_t operator &(uint8_t var1, uint8_t var2)    /* & */
        {
            return new uint8_t(var1.var & var2.var);
        }
        public static uint8_t operator |(uint8_t var1, uint8_t var2)    /* | */
        {
            return new uint8_t(var1.var | var2.var);
        }
        public static uint8_t operator ^(uint8_t var1, uint8_t var2)    /* ^ */
        {
            return new uint8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, uint8_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, uint8_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, uint8_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, uint8_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, uint8_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, uint8_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        /* Assignment */
        public static implicit operator Int16(uint8_t obj)
        {
            return obj.var;
        }

        public static implicit operator uint8_t(Int16 var)
        {
            return new uint8_t(var);
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, int16_t var2)    /* + */
        {
            return new uint8_t(var1.var + var2.var);
        }
        public static uint8_t operator -(uint8_t var1, int16_t var2)    /* - */
        {
            return new uint8_t(var1.var - var2.var);
        }
        public static uint8_t operator *(uint8_t var1, int16_t var2)    /* * */
        {
            return new uint8_t(var1.var * var2.var);
        }
        public static uint8_t operator /(uint8_t var1, int16_t var2)    /* / */
        {
            return new uint8_t(var1.var / var2.var);
        }
        public static uint8_t operator %(uint8_t var1, int16_t var2)    /* % */
        {
            return new uint8_t(var1.var % var2.var);
        }
        public static uint8_t operator &(uint8_t var1, int16_t var2)    /* & */
        {
            return new uint8_t(var1.var & var2.var);
        }
        public static uint8_t operator |(uint8_t var1, int16_t var2)    /* | */
        {
            return new uint8_t(var1.var | (ushort)var2.var);
        }
        public static uint8_t operator ^(uint8_t var1, int16_t var2)    /* ^ */
        {
            return new uint8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, int16_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, int16_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, int16_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, int16_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, int16_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, int16_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        /* Assignment */
        public static implicit operator UInt16(uint8_t obj)
        {
            return obj.var;
        }

        public static implicit operator uint8_t(UInt16 var)
        {
            return new uint8_t(var);
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, uint16_t var2)   /* + */
        {
            return new uint8_t(var1.var + var2.var);
        }
        public static uint8_t operator -(uint8_t var1, uint16_t var2)   /* - */
        {
            return new uint8_t(var1.var - var2.var);
        }
        public static uint8_t operator *(uint8_t var1, uint16_t var2)   /* * */
        {
            return new uint8_t(var1.var * var2.var);
        }
        public static uint8_t operator /(uint8_t var1, uint16_t var2)   /* / */
        {
            return new uint8_t(var1.var / var2.var);
        }
        public static uint8_t operator %(uint8_t var1, uint16_t var2)   /* % */
        {
            return new uint8_t(var1.var % var2.var);
        }
        public static uint8_t operator &(uint8_t var1, uint16_t var2)   /* & */
        {
            return new uint8_t(var1.var & var2.var);
        }
        public static uint8_t operator |(uint8_t var1, uint16_t var2)   /* | */
        {
            return new uint8_t(var1.var | var2.var);
        }
        public static uint8_t operator ^(uint8_t var1, uint16_t var2)   /* ^ */
        {
            return new uint8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, uint16_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, uint16_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, uint16_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, uint16_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, uint16_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, uint16_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        /* Assignment */
        public static implicit operator Int32(uint8_t obj)
        {
            return obj.var;
        }

        public static implicit operator uint8_t(Int32 var)
        {
            return new uint8_t(var);
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, int32_t var2)    /* + */
        {
            return new uint8_t(var1.var + var2.var);
        }
        public static uint8_t operator -(uint8_t var1, int32_t var2)    /* - */
        {
            return new uint8_t(var1.var - var2.var);
        }
        public static uint8_t operator *(uint8_t var1, int32_t var2)    /* * */
        {
            return new uint8_t(var1.var * var2.var);
        }
        public static uint8_t operator /(uint8_t var1, int32_t var2)    /* / */
        {
            return new uint8_t(var1.var / var2.var);
        }
        public static uint8_t operator %(uint8_t var1, int32_t var2)    /* % */
        {
            return new uint8_t(var1.var & var2.var);
        }
        public static uint8_t operator &(uint8_t var1, int32_t var2)    /* & */
        {
            return new uint8_t(var1.var & var2.var);
        }
        public static uint8_t operator |(uint8_t var1, int32_t var2)    /* | */
        {
            return new uint8_t(var1.var | (uint)var2.var);
        }
        public static uint8_t operator ^(uint8_t var1, int32_t var2)    /* ^ */
        {
            uint8_t result = new uint8_t(var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, int32_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, int32_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, int32_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, int32_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, int32_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, int32_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Assignment */
        public static implicit operator UInt32(uint8_t obj)
        {
            return obj.var;
        }

        public static implicit operator uint8_t(UInt32 var)
        {
            return new uint8_t(var);
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, uint32_t var2)   /* + */
        {
            return new uint8_t(var1.var + var2.var);
        }
        public static uint8_t operator -(uint8_t var1, uint32_t var2)   /* - */
        {
            return new uint8_t(var1.var - var2.var);
        }
        public static uint8_t operator *(uint8_t var1, uint32_t var2)   /* * */
        {
            return new uint8_t(var1.var * var2.var);
        }
        public static uint8_t operator /(uint8_t var1, uint32_t var2)   /* / */
        {
            return new uint8_t(var1.var / var2.var);
        }
        public static uint8_t operator %(uint8_t var1, uint32_t var2)   /* % */
        {
            return new uint8_t(var1.var % var2.var);
        }
        public static uint8_t operator &(uint8_t var1, uint32_t var2)   /* & */
        {
            return new uint8_t(var1.var & var2.var);
        }
        public static uint8_t operator |(uint8_t var1, uint32_t var2)   /* | */
        {
            return new uint8_t(var1.var | var2.var);
        }
        public static uint8_t operator ^(uint8_t var1, uint32_t var2)   /* ^ */
        {
            return new uint8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, uint32_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, uint32_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, uint32_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, uint32_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, uint32_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, uint32_t var2)     /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        /* Assignment */
        public static implicit operator Int64(uint8_t obj)
        {
            return obj.var;
        }

        public static implicit operator uint8_t(Int64 var)
        {
            return new uint8_t(var);
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, int64_t var2)    /* + */
        {
            return new uint8_t(var1.var + var2.var);
        }
        public static uint8_t operator -(uint8_t var1, int64_t var2)    /* - */
        {
            return new uint8_t(var1.var - var2.var);
        }
        public static uint8_t operator *(uint8_t var1, int64_t var2)    /* * */
        {
            return new uint8_t(var1.var * var2.var);
        }
        public static uint8_t operator /(uint8_t var1, int64_t var2)    /* / */
        {
            return new uint8_t(var1.var / var2.var);
        }
        public static uint8_t operator %(uint8_t var1, int64_t var2)    /* % */
        {
            return new uint8_t(var1.var % var2.var);
        }
        public static uint8_t operator &(uint8_t var1, int64_t var2)    /* & */
        {
            return new uint8_t(var1.var & var2.var);
        }
        public static uint8_t operator |(uint8_t var1, int64_t var2)    /* | */
        {
            return new uint8_t(var1.var | (ulong)var2.var);
        }
        public static uint8_t operator ^(uint8_t var1, int64_t var2)    /* ^ */
        {
            return new uint8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, int64_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, int64_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, int64_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, int64_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, int64_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, int64_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        /* Assignment */
        public static implicit operator UInt64(uint8_t obj)
        {
            return obj.var;
        }

        public static implicit operator uint8_t(UInt64 var)
        {
            return new uint8_t(var);
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, uint64_t var2)   /* + */
        {
            return new uint8_t(var1.var + var2.var);
        }
        public static uint8_t operator -(uint8_t var1, uint64_t var2)   /* - */
        {
            return new uint8_t(var1.var - var2.var);
        }
        public static uint8_t operator *(uint8_t var1, uint64_t var2)   /* * */
        {
            return new uint8_t(var1.var * var2.var);
        }
        public static uint8_t operator /(uint8_t var1, uint64_t var2)   /* / */
        {
            return new uint8_t(var1.var / var2.var);
        }
        public static uint8_t operator %(uint8_t var1, uint64_t var2)   /* % */
        {
            return new uint8_t(var1.var % var2.var);
        }
        public static uint8_t operator &(uint8_t var1, uint64_t var2)   /* & */
        {
            return new uint8_t(var1.var & var2.var);
        }
        public static uint8_t operator |(uint8_t var1, uint64_t var2)   /* | */
        {
            return new uint8_t(var1.var | var2.var);
        }
        public static uint8_t operator ^(uint8_t var1, uint64_t var2)   /* ^ */
        {
            return new uint8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, uint64_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, uint64_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, uint64_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, uint64_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, uint64_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, uint64_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int
        /* Math */
        public static uint8_t operator +(uint8_t var1, int var2)        /* + */
        {
            return new uint8_t(var1.var + var2);
        }
        public static uint8_t operator -(uint8_t var1, int var2)        /* - */
        {
            return new uint8_t(var1.var - var2);
        }
        public static uint8_t operator *(uint8_t var1, int var2)        /* * */
        {
            return new uint8_t(var1.var * var2);
        }
        public static uint8_t operator /(uint8_t var1, int var2)        /* / */
        {
            return new uint8_t(var1.var / var2);
        }
        public static uint8_t operator %(uint8_t var1, int var2)        /* % */
        {
            return new uint8_t(var1.var % var2);
        }
        public static uint8_t operator &(uint8_t var1, int var2)        /* & */
        {
            return new uint8_t(var1.var & var2);
        }
        public static uint8_t operator |(uint8_t var1, int var2)        /* | */
        {
            return new uint8_t(var1.var | var2);
        }
        public static uint8_t operator ^(uint8_t var1, int var2)        /* ^ */
        {
            return new uint8_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, int var2)           /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint8_t var1, int var2)           /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint8_t var1, int var2)          /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint8_t var1, int var2)          /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint8_t var1, int var2)          /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint8_t var1, int var2)          /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Math */
        public static uint8_t operator +(uint8_t var1, byte var2)       /* + */
        {
            return new uint8_t(var1.var + var2);
        }
        public static uint8_t operator -(uint8_t var1, byte var2)       /* - */
        {
            return new uint8_t(var1.var - var2);
        }
        public static uint8_t operator *(uint8_t var1, byte var2)       /* * */
        {
            return new uint8_t(var1.var * var2);
        }
        public static uint8_t operator /(uint8_t var1, byte var2)       /* / */
        {
            return new uint8_t(var1.var / var2);
        }
        public static uint8_t operator %(uint8_t var1, byte var2)       /* % */
        {
            return new uint8_t(var1.var % var2);
        }
        public static uint8_t operator &(uint8_t var1, byte var2)       /* & */
        {
            return new uint8_t(var1.var & var2);
        }
        public static uint8_t operator |(uint8_t var1, byte var2)       /* | */
        {
            return new uint8_t(var1.var | var2);
        }
        public static uint8_t operator ^(uint8_t var1, byte var2)       /* ^ */
        {
            return new uint8_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, byte var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint8_t var1, byte var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint8_t var1, byte var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint8_t var1, byte var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint8_t var1, byte var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint8_t var1, byte var2)         /* > */
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
        public Int16 var = 0;

        #region Constructors
        public int16_t()                { var = 0; }
        public int16_t(byte value)      { var = (Int16)value; }
        public int16_t(SByte value)     { var = (Int16)value; }
        public int16_t(Int16 value)     { var = value; }
        public int16_t(UInt16 value)    { var = (Int16)value; }
        public int16_t(int value)       { var = (Int16)value; }
        public int16_t(UInt32 value)    { var = (Int16)value; }
        public int16_t(Int64 value)     { var = (Int16)value; }
        public int16_t(UInt64 value)    { var = (Int16)value; }
        public int16_t(int8_t value)    { var = (Int16)value.var; }
        public int16_t(uint8_t value)   { var = (Int16)value.var; }
        public int16_t(int16_t value)   { var = value.var; }
        public int16_t(uint16_t value)  { var = (Int16)value.var; }
        public int16_t(int32_t value)   { var = (Int16)value.var; }
        public int16_t(uint32_t value)  { var = (Int16)value.var; }
        public int16_t(int64_t value)   { var = (Int16)value.var; }
        public int16_t(uint64_t value)  { var = (Int16)value.var; }
        #endregion

        #region int8_t
        /* Assignment */
        public static implicit operator sbyte(int16_t obj)
        {
            return (sbyte)obj.var;
        }

        public static implicit operator int16_t(sbyte var)
        {
            return new int16_t(var);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, int8_t var2)     /* + */
        {
            return new int16_t(var1.var + var2.var);
        }
        public static int16_t operator -(int16_t var1, int8_t var2)     /* - */
        {
            return new int16_t(var1.var - var2.var);
        }
        public static int16_t operator *(int16_t var1, int8_t var2)     /* * */
        {
            return new int16_t(var1.var * var2.var);
        }
        public static int16_t operator /(int16_t var1, int8_t var2)     /* / */
        {
            return new int16_t(var1.var / var2.var);
        }
        public static int16_t operator %(int16_t var1, int8_t var2)     /* % */
        {
            return new int16_t(var1.var % var2.var);
        }
        public static int16_t operator &(int16_t var1, int8_t var2)     /* & */
        {
            return new int16_t(var1.var & var2.var);
        }
        public static int16_t operator |(int16_t var1, int8_t var2)     /* | */
        {
            return new int16_t((ushort)var1.var | (byte)var2.var);
        }
        public static int16_t operator ^(int16_t var1, int8_t var2)     /* ^ */
        {
            return new int16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, int8_t var2)        /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, int8_t var2)        /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, int8_t var2)       /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, int8_t var2)       /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, int8_t var2)       /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, int8_t var2)       /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Assignment */
        public static implicit operator byte(int16_t obj)
        {
            return (byte)obj.var;
        }

        public static implicit operator int16_t(byte var)
        {
            return new int16_t(var);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, uint8_t var2)    /* + */
        {
            return new int16_t(var1.var + var2.var);
        }
        public static int16_t operator -(int16_t var1, uint8_t var2)    /* - */
        {
            return new int16_t(var1.var - var2.var);
        }
        public static int16_t operator *(int16_t var1, uint8_t var2)    /* * */
        {
            return new int16_t(var1.var * var2.var);
        }
        public static int16_t operator /(int16_t var1, uint8_t var2)    /* / */
        {
            return new int16_t(var1.var / var2.var);
        }
        public static int16_t operator %(int16_t var1, uint8_t var2)    /* % */
        {
            return new int16_t(var1.var % var2.var);
        }
        public static int16_t operator &(int16_t var1, uint8_t var2)    /* & */
        {
            return new int16_t(var1.var & var2.var);
        }
        public static int16_t operator |(int16_t var1, uint8_t var2)    /* | */
        {
            return new int16_t((ushort)var1.var | var2.var);
        }
        public static int16_t operator ^(int16_t var1, uint8_t var2)    /* ^ */
        {
            return new int16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, uint8_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, uint8_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, uint8_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, uint8_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, uint8_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, uint8_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        /* Assignment */
        public static implicit operator Int16(int16_t obj)
        {
            return obj.var;
        }

        public static implicit operator int16_t(Int16 var)
        {
            return new int16_t(var);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, int16_t var2)    /* + */
        {
            return new int16_t(var1.var + var2.var);
        }
        public static int16_t operator ++(int16_t obj)                  /* ++ */
        {
            return (obj.var++);
        }
        public static int16_t operator -(int16_t var1, int16_t var2)    /* - */
        {
            return new int16_t(var1.var - var2.var);
        }
        public static int16_t operator --(int16_t obj)
        {
            return (obj.var--);
        }
        public static int16_t operator *(int16_t var1, int16_t var2)    /* * */
        {
            return new int16_t(var1.var * var2.var);
        }
        public static int16_t operator /(int16_t var1, int16_t var2)    /* / */
        {
            return new int16_t(var1.var / var2.var);
        }
        public static int16_t operator %(int16_t var1, int16_t var2)    /* % */
        {
            return new int16_t(var1.var % var2.var);
        }
        public static int16_t operator &(int16_t var1, int16_t var2)    /* & */
        {
            return new int16_t(var1.var & var2.var);
        }
        public static int16_t operator |(int16_t var1, int16_t var2)    /* | */
        {
            return new int16_t(var1.var | var2.var);
        }
        public static int16_t operator ^(int16_t var1, int16_t var2)    /* ^ */
        {
            return new int16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, int16_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, int16_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, int16_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, int16_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, int16_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, int16_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        /* Assignment */
        public static implicit operator UInt16(int16_t obj)
        {
            return (ushort)obj.var;
        }

        public static implicit operator int16_t(UInt16 var)
        {
            return new int16_t(var);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, uint16_t var2)   /* + */
        {
            return new int16_t(var1.var + var2.var);
        }
        public static int16_t operator -(int16_t var1, uint16_t var2)   /* - */
        {
            return new int16_t(var1.var - var2.var);
        }
        public static int16_t operator *(int16_t var1, uint16_t var2)   /* * */
        {
            return new int16_t(var1.var * var2.var);
        }
        public static int16_t operator /(int16_t var1, uint16_t var2)   /* / */
        {
            return new int16_t(var1.var / var2.var);
        }
        public static int16_t operator %(int16_t var1, uint16_t var2)   /* % */
        {
            return new int16_t(var1.var % var2.var);
        }
        public static int16_t operator &(int16_t var1, uint16_t var2)   /* & */
        {
            return new int16_t(var1.var & var2.var);
        }
        public static int16_t operator |(int16_t var1, uint16_t var2)   /* | */
        {
            return new int16_t((ushort)var1.var | var2.var);
        }
        public static int16_t operator ^(int16_t var1, uint16_t var2)   /* ^ */
        {
            return new int16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, uint16_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, uint16_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, uint16_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, uint16_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, uint16_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, uint16_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        /* Assignment */
        public static implicit operator Int32(int16_t obj)
        {
            return obj.var;
        }

        public static implicit operator int16_t(Int32 var)
        {
            return new int16_t(var);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, int32_t var2)    /* + */
        {
            return new int16_t(var1.var + var2.var);
        }
        public static int16_t operator -(int16_t var1, int32_t var2)    /* - */
        {
            return new int16_t(var1.var - var2.var);
        }
        public static int16_t operator *(int16_t var1, int32_t var2)    /* * */
        {
            return new int16_t(var1.var * var2.var);
        }
        public static int16_t operator /(int16_t var1, int32_t var2)    /* / */
        {
            return new int16_t(var1.var / var2.var);
        }
        public static int16_t operator %(int16_t var1, int32_t var2)    /* % */
        {
            return new int16_t(var1.var % var2.var);
        }
        public static int16_t operator &(int16_t var1, int32_t var2)    /* & */
        {
            return new int16_t(var1.var & var2.var);
        }
        public static int16_t operator |(int16_t var1, int32_t var2)    /* | */
        {
            return new int16_t((ushort)var1.var | var2.var);
        }
        public static int16_t operator ^(int16_t var1, int32_t var2)    /* ^ */
        {
            return new int16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, int32_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, int32_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, int32_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, int32_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, int32_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, int32_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Assignment */
        public static implicit operator UInt32(int16_t obj)
        {
            return (uint)obj.var;
        }

        public static implicit operator int16_t(UInt32 var)
        {
            return new int16_t(var);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, uint32_t var2)   /* + */
        {
            return new int16_t(var1.var + var2.var);
        }
        public static int16_t operator -(int16_t var1, uint32_t var2)   /* - */
        {
            return new int16_t(var1.var - var2.var);
        }
        public static int16_t operator *(int16_t var1, uint32_t var2)   /* * */
        {
            return new int16_t(var1.var * var2.var);
        }
        public static int16_t operator /(int16_t var1, uint32_t var2)   /* / */
        {
            return new int16_t(var1.var / var2.var);
        }
        public static int16_t operator %(int16_t var1, uint32_t var2)   /* % */
        {
            return new int16_t(var1.var % var2.var);
        }
        public static int16_t operator &(int16_t var1, uint32_t var2)   /* & */
        {
            return new int16_t(var1.var & var2.var);
        }
        public static int16_t operator |(int16_t var1, uint32_t var2)   /* | */
        {
            return new int16_t((ushort)var1.var | var2.var);
        }
        public static int16_t operator ^(int16_t var1, uint32_t var2)   /* ^ */
        {
            return new int16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, uint32_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, uint32_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, uint32_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, uint32_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, uint32_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, uint32_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        /* Assignment */
        public static implicit operator Int64(int16_t obj)
        {
            return obj.var;
        }

        public static implicit operator int16_t(Int64 var)
        {
            return new int16_t(var);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, int64_t var2)    /* + */
        {
            return new int16_t(var1.var + var2.var);
        }
        public static int16_t operator -(int16_t var1, int64_t var2)    /* - */
        {
            return new int16_t(var1.var - var2.var);
        }
        public static int16_t operator *(int16_t var1, int64_t var2)    /* * */
        {
            return new int16_t(var1.var * var2.var);
        }
        public static int16_t operator /(int16_t var1, int64_t var2)    /* / */
        {
            return new int16_t(var1.var / var2.var);
        }
        public static int16_t operator %(int16_t var1, int64_t var2)    /* % */
        {
            return new int16_t(var1.var % var2.var);
        }
        public static int16_t operator &(int16_t var1, int64_t var2)    /* & */
        {
            return new int16_t(var1.var & var2.var);
        }
        public static int16_t operator |(int16_t var1, int64_t var2)    /* | */
        {
            return new int16_t((ushort)var1.var | var2.var);
        }
        public static int16_t operator ^(int16_t var1, int64_t var2)    /* ^ */
        {
            return new int16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, int64_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, int64_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, int64_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, int64_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, int64_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, int64_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        /* Assignment */
        public static implicit operator UInt64(int16_t obj)
        {
            return (ulong)obj.var;
        }

        public static implicit operator int16_t(UInt64 var)
        {
            return new int16_t(var);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, uint64_t var2)   /* + */
        {
            return new int16_t((ulong)var1.var + var2.var);
        }
        public static int16_t operator -(int16_t var1, uint64_t var2)   /* - */
        {
            return new int16_t((ulong)var1.var - var2.var);
        }
        public static int16_t operator *(int16_t var1, uint64_t var2)   /* * */
        {
            return new int16_t((ulong)var1.var * var2.var);
        }
        public static int16_t operator /(int16_t var1, uint64_t var2)   /* / */
        {
            return new int16_t((ulong)var1.var / var2.var);
        }
        public static int16_t operator %(int16_t var1, uint64_t var2)   /* % */
        {
            return new int16_t((ulong)var1.var % var2.var);
        }
        public static int16_t operator &(int16_t var1, uint64_t var2)   /* & */
        {
            return new int16_t((ulong)var1.var & var2.var);
        }
        public static int16_t operator |(int16_t var1, uint64_t var2)   /* | */
        {
            return new int16_t((ushort)var1.var | var2.var);
        }
        public static int16_t operator ^(int16_t var1, uint64_t var2)   /* ^ */
        {
            return new int16_t((ulong)var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, uint64_t var2)      /* > */
        {
            return (var1.var > (Int64)var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, uint64_t var2)      /* < */
        {
            return (var1.var < (Int64)var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, uint64_t var2)     /* <= */
        {
            return (var1.var <= (Int64)var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, uint64_t var2)     /* >= */
        {
            return (var1.var >= (Int64)var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, uint64_t var2)     /* == */
        {
            return (var1.var == (Int64)var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, uint64_t var2)     /* != */
        {
            return (var1.var != (Int64)var2.var) ? true : false;
        }
        #endregion
        #region int
        /* Math */
        public static int16_t operator +(int16_t var1, int var2)        /* + */
        {
            int16_t result = new int16_t(var1.var + var2);
            return result;
        }
        public static int16_t operator -(int16_t var1, int var2)        /* - */
        {
            int16_t result = new int16_t(var1.var - var2);
            return result;
        }
        public static int16_t operator *(int16_t var1, int var2)        /* * */
        {
            int16_t result = new int16_t(var1.var * var2);
            return result;
        }
        public static int16_t operator /(int16_t var1, int var2)        /* / */
        {
            int16_t result = new int16_t(var1.var / var2);
            return result;
        }
        public static int16_t operator %(int16_t var1, int var2)        /* % */
        {
            int16_t result = new int16_t(var1.var % var2);
            return result;
        }
        public static int16_t operator &(int16_t var1, int var2)        /* & */
        {
            int16_t result = new int16_t(var1.var & var2);
            return result;
        }
        public static int16_t operator |(int16_t var1, int var2)        /* | */
        {
            int16_t result = new int16_t((UInt16)var1.var | var2);
            return result;
        }
        public static int16_t operator ^(int16_t var1, int var2)        /* ^ */
        {
            int16_t result = new int16_t(var1.var ^ var2);
            return result;
        }

        /* Comparison */
        public static bool operator >(int16_t var1, int var2)           /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int16_t var1, int var2)           /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int16_t var1, int var2)          /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int16_t var1, int var2)          /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int16_t var1, int var2)          /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int16_t var1, int var2)          /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Math */
        public static int16_t operator +(int16_t var1, byte var2)       /* + */
        {
            int16_t result = new int16_t(var1.var + var2);
            return result;
        }
        public static int16_t operator -(int16_t var1, byte var2)       /* - */
        {
            int16_t result = new int16_t(var1.var - var2);
            return result;
        }
        public static int16_t operator *(int16_t var1, byte var2)       /* * */
        {
            int16_t result = new int16_t(var1.var * var2);
            return result;
        }
        public static int16_t operator /(int16_t var1, byte var2)       /* / */
        {
            int16_t result = new int16_t(var1.var / var2);
            return result;
        }
        public static int16_t operator %(int16_t var1, byte var2)       /* % */
        {
            int16_t result = new int16_t(var1.var % var2);
            return result;
        }
        public static int16_t operator &(int16_t var1, byte var2)       /* & */
        {
            int16_t result = new int16_t(var1.var & var2);
            return result;
        }
        public static int16_t operator |(int16_t var1, byte var2)       /* | */
        {
            int16_t result = new int16_t((UInt16)var1.var | var2);
            return result;
        }
        public static int16_t operator ^(int16_t var1, byte var2)       /* ^ */
        {
            int16_t result = new int16_t(var1.var ^ var2);
            return result;
        }

        /* Comparison */
        public static bool operator >(int16_t var1, byte var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int16_t var1, byte var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int16_t var1, byte var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int16_t var1, byte var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int16_t var1, byte var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int16_t var1, byte var2)         /* != */
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
        public UInt16 var = 0;

        #region Constructors
        public uint16_t()               { var = 0; }
        public uint16_t(byte value)     { var = (UInt16)value; }
        public uint16_t(SByte value)    { var = (UInt16)value; }
        public uint16_t(Int16 value)    { var = (UInt16)value; }
        public uint16_t(UInt16 value)   { var = value; }
        public uint16_t(int value)      { var = (UInt16)value; }
        public uint16_t(UInt32 value)   { var = (UInt16)value; }
        public uint16_t(Int64 value)    { var = (UInt16)value; }
        public uint16_t(UInt64 value)   { var = (UInt16)value; }
        public uint16_t(int8_t value)   { var = (UInt16)value.var; }
        public uint16_t(uint8_t value)  { var = (UInt16)value.var; }
        public uint16_t(int16_t value)  { var = (UInt16)value.var; }
        public uint16_t(uint16_t value) { var = value.var; }
        public uint16_t(int32_t value)  { var = (UInt16)value.var; }
        public uint16_t(uint32_t value) { var = (UInt16)value.var; }
        public uint16_t(int64_t value)  { var = (UInt16)value.var; }
        public uint16_t(uint64_t value) { var = (UInt16)value.var; }
        #endregion

        #region int8_t
        /* Assignment */
        public static implicit operator sbyte(uint16_t obj)
        {
            return (sbyte)obj.var;
        }

        public static implicit operator uint16_t(sbyte var)
        {
            return new uint16_t(var);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, int8_t var2)   /* + */
        {
            return new uint16_t(var1.var + var2.var);
        }
        public static uint16_t operator -(uint16_t var1, int8_t var2)   /* - */
        {
            return new uint16_t(var1.var - var2.var);
        }
        public static uint16_t operator *(uint16_t var1, int8_t var2)   /* * */
        {
            return new uint16_t(var1.var * var2.var);
        }
        public static uint16_t operator /(uint16_t var1, int8_t var2)   /* / */
        {
            return new uint16_t(var1.var / var2.var);
        }
        public static uint16_t operator %(uint16_t var1, int8_t var2)   /* % */
        {
            return new uint16_t(var1.var % var2.var);
        }
        public static uint16_t operator &(uint16_t var1, int8_t var2)   /* & */
        {
            return new uint16_t(var1.var & var2.var);
        }
        public static uint16_t operator |(uint16_t var1, int8_t var2)   /* | */
        {
            return new uint16_t(var1.var | (byte)var2.var);
        }
        public static uint16_t operator ^(uint16_t var1, int8_t var2)   /* ^ */
        {
            return new uint16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, int8_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, int8_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, int8_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, int8_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, int8_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, int8_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Assignment */
        public static implicit operator byte(uint16_t obj)
        {
            return (byte)obj.var;
        }

        public static implicit operator uint16_t(byte var)
        {
            return new uint16_t(var);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, uint8_t var2)  /* + */
        {
            return new uint16_t(var1.var + var2.var);
        }
        public static uint16_t operator -(uint16_t var1, uint8_t var2)  /* - */
        {
            return new uint16_t(var1.var - var2.var);
        }
        public static uint16_t operator *(uint16_t var1, uint8_t var2)  /* * */
        {
            return new uint16_t(var1.var * var2.var);
        }
        public static uint16_t operator /(uint16_t var1, uint8_t var2)  /* / */
        {
            return new uint16_t(var1.var / var2.var);
        }
        public static uint16_t operator %(uint16_t var1, uint8_t var2)  /* % */
        {
            return new uint16_t(var1.var % var2.var);
        }
        public static uint16_t operator &(uint16_t var1, uint8_t var2)  /* & */
        {
            return new uint16_t(var1.var & var2.var);
        }
        public static uint16_t operator |(uint16_t var1, uint8_t var2)  /* | */
        {
            return new uint16_t(var1.var | var2.var);
        }
        public static uint16_t operator ^(uint16_t var1, uint8_t var2)  /* ^ */
        {
            return new uint16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, uint8_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, uint8_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, uint8_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, uint8_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, uint8_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, uint8_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        /* Assignment */
        public static implicit operator Int16(uint16_t obj)
        {
            return (Int16)obj.var;
        }

        public static implicit operator uint16_t(Int16 var)
        {
            return new uint16_t(var);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, int16_t var2)  /* + */
        {
            return new uint16_t(var1.var + var2.var);
        }
        public static uint16_t operator -(uint16_t var1, int16_t var2)  /* - */
        {
            return new uint16_t(var1.var - var2.var);
        }
        public static uint16_t operator *(uint16_t var1, int16_t var2)  /* * */
        {
            return new uint16_t(var1.var * var2.var);
        }
        public static uint16_t operator /(uint16_t var1, int16_t var2)  /* / */
        {
            return new uint16_t(var1.var / var2.var);
        }
        public static uint16_t operator %(uint16_t var1, int16_t var2)  /* % */
        {
            return new uint16_t(var1.var % var2.var);
        }
        public static uint16_t operator &(uint16_t var1, int16_t var2)  /* & */
        {
            return new uint16_t(var1.var & var2.var);
        }
        public static uint16_t operator |(uint16_t var1, int16_t var2)  /* | */
        {
            return new uint16_t(var1.var | (ushort)var2.var);
        }
        public static uint16_t operator ^(uint16_t var1, int16_t var2)  /* ^ */
        {
            return new uint16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, int16_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, int16_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, int16_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, int16_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, int16_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, int16_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        /* Assignment */
        public static implicit operator UInt16(uint16_t obj)
        {
            return (UInt16)obj.var;
        }

        public static implicit operator uint16_t(UInt16 var)
        {
            return new uint16_t(var);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, uint16_t var2) /* + */
        {
            return new uint16_t(var1.var + var2.var);
        }
        public static uint16_t operator ++(uint16_t obj)
        {
            return (obj.var++);
        }
        public static uint16_t operator -(uint16_t var1, uint16_t var2) /* - */
        {
            return new uint16_t(var1.var - var2.var);
        }
        public static uint16_t operator --(uint16_t obj)
        {
            return (obj.var--);
        }
        public static uint16_t operator *(uint16_t var1, uint16_t var2) /* * */
        {
            return new uint16_t(var1.var * var2.var);
        }
        public static uint16_t operator /(uint16_t var1, uint16_t var2) /* / */
        {
            return new uint16_t(var1.var / var2.var);
        }
        public static uint16_t operator %(uint16_t var1, uint16_t var2) /* % */
        {
            return new uint16_t(var1.var % var2.var);
        }
        public static uint16_t operator &(uint16_t var1, uint16_t var2) /* & */
        {
            return new uint16_t(var1.var & var2.var);
        }
        public static uint16_t operator |(uint16_t var1, uint16_t var2) /* | */
        {
            return new uint16_t(var1.var | var2.var);
        }
        public static uint16_t operator ^(uint16_t var1, uint16_t var2) /* ^ */
        {
            return new uint16_t(var1.var ^ var2.var);
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
        public static bool operator !=(uint16_t var1, uint16_t var2)    /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        /* Assignment */
        public static implicit operator Int32(uint16_t obj)
        {
            return (Int32)obj.var;
        }

        public static implicit operator uint16_t(Int32 var)
        {
            return new uint16_t(var);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, int32_t var2)  /* + */
        {
            return new uint16_t(var1.var + var2.var);
        }
        public static uint16_t operator -(uint16_t var1, int32_t var2)  /* - */
        {
            return new uint16_t(var1.var - var2.var);
        }
        public static uint16_t operator *(uint16_t var1, int32_t var2)  /* * */
        {
            return new uint16_t(var1.var * var2.var);
        }
        public static uint16_t operator /(uint16_t var1, int32_t var2)  /* / */
        {
            return new uint16_t(var1.var / var2.var);
        }
        public static uint16_t operator %(uint16_t var1, int32_t var2)  /* % */
        {
            return new uint16_t(var1.var % var2.var);
        }
        public static uint16_t operator &(uint16_t var1, int32_t var2)  /* & */
        {
            return new uint16_t(var1.var & var2.var);
        }
        public static uint16_t operator |(uint16_t var1, int32_t var2)  /* | */
        {
            return new uint16_t(var1.var | var2.var);
        }
        public static uint16_t operator ^(uint16_t var1, int32_t var2)  /* ^ */
        {
            return new uint16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, int32_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, int32_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, int32_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, int32_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, int32_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, int32_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Assignment */
        public static implicit operator UInt32(uint16_t obj)
        {
            return (UInt32)obj.var;
        }

        public static implicit operator uint16_t(UInt32 var)
        {
            return new uint16_t(var);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, uint32_t var2) /* + */
        {
            return new uint16_t(var1.var + var2.var);
        }
        public static uint16_t operator -(uint16_t var1, uint32_t var2) /* - */
        {
            return new uint16_t(var1.var - var2.var);
        }
        public static uint16_t operator *(uint16_t var1, uint32_t var2) /* * */
        {
            return new uint16_t(var1.var * var2.var);
        }
        public static uint16_t operator /(uint16_t var1, uint32_t var2) /* / */
        {
            return new uint16_t(var1.var / var2.var);
        }
        public static uint16_t operator %(uint16_t var1, uint32_t var2) /* % */
        {
            return new uint16_t(var1.var % var2.var);
        }
        public static uint16_t operator &(uint16_t var1, uint32_t var2) /* & */
        {
            return new uint16_t(var1.var & var2.var);
        }
        public static uint16_t operator |(uint16_t var1, uint32_t var2) /* | */
        {
            return new uint16_t(var1.var | var2.var);
        }
        public static uint16_t operator ^(uint16_t var1, uint32_t var2) /* ^ */
        {
            return new uint16_t(var1.var ^ var2.var);
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
        public static bool operator !=(uint16_t var1, uint32_t var2)    /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        /* Assignment */
        public static implicit operator Int64(uint16_t obj)
        {
            return (Int64)obj.var;
        }

        public static implicit operator uint16_t(Int64 var)
        {
            return new uint16_t(var);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, int64_t var2)  /* + */
        {
            return new uint16_t(var1.var + var2.var);
        }
        public static uint16_t operator -(uint16_t var1, int64_t var2)  /* - */
        {
            return new uint16_t(var1.var - var2.var);
        }
        public static uint16_t operator *(uint16_t var1, int64_t var2)  /* * */
        {
            return new uint16_t(var1.var * var2.var);
        }
        public static uint16_t operator /(uint16_t var1, int64_t var2)  /* / */
        {
            return new uint16_t(var1.var / var2.var);
        }
        public static uint16_t operator %(uint16_t var1, int64_t var2)  /* % */
        {
            return new uint16_t(var1.var % var2.var);
        }
        public static uint16_t operator &(uint16_t var1, int64_t var2)  /* & */
        {
            return new uint16_t(var1.var & var2.var);
        }
        public static uint16_t operator |(uint16_t var1, int64_t var2)  /* | */
        {
            return new uint16_t(var1.var | var2.var);
        }
        public static uint16_t operator ^(uint16_t var1, int64_t var2)  /* ^ */
        {
            return new uint16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, int64_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, int64_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, int64_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, int64_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, int64_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, int64_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        /* Assignment */
        public static implicit operator UInt64(uint16_t obj)
        {
            return (UInt64)obj.var;
        }

        public static implicit operator uint16_t(UInt64 var)
        {
            return new uint16_t(var);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, uint64_t var2) /* + */
        {
            return new uint16_t(var1.var + var2.var);
        }
        public static uint16_t operator -(uint16_t var1, uint64_t var2) /* - */
        {
            return new uint16_t(var1.var - var2.var);
        }
        public static uint16_t operator *(uint16_t var1, uint64_t var2) /* * */
        {
            return new uint16_t(var1.var * var2.var);
        }
        public static uint16_t operator /(uint16_t var1, uint64_t var2) /* / */
        {
            return new uint16_t(var1.var / var2.var);
        }
        public static uint16_t operator %(uint16_t var1, uint64_t var2) /* % */
        {
            return new uint16_t(var1.var % var2.var);
        }
        public static uint16_t operator &(uint16_t var1, uint64_t var2) /* & */
        {
            return new uint16_t(var1.var & var2.var);
        }
        public static uint16_t operator |(uint16_t var1, uint64_t var2) /* | */
        {
            return new uint16_t(var1.var | var2.var);
        }
        public static uint16_t operator ^(uint16_t var1, uint64_t var2) /* ^ */
        {
            return new uint16_t(var1.var ^ var2.var);
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
        public static bool operator !=(uint16_t var1, uint64_t var2)    /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int
        /* Math */
        public static uint16_t operator +(uint16_t var1, int var2)      /* + */
        {
            return new uint16_t(var1.var + var2);
        }
        public static uint16_t operator -(uint16_t var1, int var2)      /* - */
        {
            return new uint16_t(var1.var - var2);
        }
        public static uint16_t operator *(uint16_t var1, int var2)      /* * */
        {
            return new uint16_t(var1.var * var2);
        }
        public static uint16_t operator /(uint16_t var1, int var2)      /* / */
        {
            return new uint16_t(var1.var / var2);
        }
        public static uint16_t operator %(uint16_t var1, int var2)      /* % */
        {
            return new uint16_t(var1.var % var2);
        }
        public static uint16_t operator &(uint16_t var1, int var2)      /* & */
        {
            return new uint16_t(var1.var & var2);
        }
        public static uint16_t operator |(uint16_t var1, int var2)      /* | */
        {
            return new uint16_t(var1.var | var2);
        }
        public static uint16_t operator ^(uint16_t var1, int var2)      /* ^ */
        {
            return new uint16_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, int var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint16_t var1, int var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint16_t var1, int var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint16_t var1, int var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint16_t var1, int var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint16_t var1, int var2)         /* !=*/
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Math */
        public static uint16_t operator +(uint16_t var1, byte var2)     /* + */
        {
            return new uint16_t(var1.var + var2);
        }
        public static uint16_t operator -(uint16_t var1, byte var2)     /* - */
        {
            return new uint16_t(var1.var - var2);
        }
        public static uint16_t operator *(uint16_t var1, byte var2)     /* * */
        {
            return new uint16_t(var1.var * var2);
        }
        public static uint16_t operator /(uint16_t var1, byte var2)     /* / */
        {
            return new uint16_t(var1.var / var2);
        }
        public static uint16_t operator %(uint16_t var1, byte var2)     /* % */
        {
            return new uint16_t(var1.var % var2);
        }
        public static uint16_t operator &(uint16_t var1, byte var2)     /* & */
        {
            return new uint16_t(var1.var & var2);
        }
        public static uint16_t operator |(uint16_t var1, byte var2)     /* | */
        {
            return new uint16_t(var1.var | var2);
        }
        public static uint16_t operator ^(uint16_t var1, byte var2)     /* ^ */
        {
            return new uint16_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, byte var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint16_t var1, byte var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint16_t var1, byte var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint16_t var1, byte var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint16_t var1, byte var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint16_t var1, byte var2)        /* != */
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
        public Int32 var = 0;

        #region Constructors
        public int32_t()                { var = 0; }
        public int32_t(byte value)      { var = (Int32)value; }
        public int32_t(SByte value)     { var = (Int32)value; }
        public int32_t(Int16 value)     { var = (Int32)value; }
        public int32_t(UInt16 value)    { var = (Int32)value; }
        public int32_t(int value)       { var = value; }
        public int32_t(UInt32 value)    { var = (Int32)value; }
        public int32_t(Int64 value)     { var = (Int32)value; }
        public int32_t(UInt64 value)    { var = (Int32)value; }
        public int32_t(int8_t value)    { var = (Int32)value.var; }
        public int32_t(uint8_t value)   { var = (Int32)value.var; }
        public int32_t(int16_t value)   { var = (Int32)value.var; }
        public int32_t(uint16_t value)  { var = (Int32)value.var; }
        public int32_t(int32_t value)   { var = value.var; }
        public int32_t(uint32_t value)  { var = (Int32)value.var; }
        public int32_t(int64_t value)   { var = (Int32)value.var; }
        public int32_t(uint64_t value)  { var = (Int32)value.var; }
        #endregion

        #region int8_t
        /* Assignment */
        public static implicit operator sbyte(int32_t obj)
        {
            return (sbyte)obj.var;
        }

        public static implicit operator int32_t(sbyte var)
        {
            return new int32_t(var);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, int8_t var2)     /* + */
        {
            return new int32_t(var1.var + var2.var);
        }
        public static int32_t operator -(int32_t var1, int8_t var2)     /* - */
        {
            return new int32_t(var1.var - var2.var);
        }
        public static int32_t operator *(int32_t var1, int8_t var2)     /* * */
        {
            return new int32_t(var1.var * var2.var);
        }
        public static int32_t operator /(int32_t var1, int8_t var2)     /* / */
        {
            return new int32_t(var1.var / var2.var);
        }
        public static int32_t operator %(int32_t var1, int8_t var2)     /* % */
        {
            return new int32_t(var1.var % var2.var);
        }
        public static int32_t operator &(int32_t var1, int8_t var2)     /* & */
        {
            return new int32_t(var1.var & var2.var);
        }
        public static int32_t operator |(int32_t var1, int8_t var2)     /* | */
        {
            return new int32_t(var1.var | (byte)var2.var);
        }
        public static int32_t operator ^(int32_t var1, int8_t var2)     /* ^ */
        {
            return new int32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, int8_t var2)        /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, int8_t var2)        /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, int8_t var2)       /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, int8_t var2)       /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, int8_t var2)       /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, int8_t var2)       /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Assignment */
        public static implicit operator byte(int32_t obj)
        {
            return (byte)obj.var;
        }

        public static implicit operator int32_t(byte var)
        {
            return new int32_t(var);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, uint8_t var2)    /* + */
        {
            return new int32_t(var1.var + var2.var);
        }
        public static int32_t operator -(int32_t var1, uint8_t var2)    /* - */
        {
            return new int32_t(var1.var - var2.var);
        }
        public static int32_t operator *(int32_t var1, uint8_t var2)    /* * */
        {
            return new int32_t(var1.var * var2.var);
        }
        public static int32_t operator /(int32_t var1, uint8_t var2)    /* / */
        {
            return new int32_t(var1.var / var2.var);
        }
        public static int32_t operator %(int32_t var1, uint8_t var2)    /* % */
        {
            return new int32_t(var1.var % var2.var);
        }
        public static int32_t operator &(int32_t var1, uint8_t var2)    /* & */
        {
            return new int32_t(var1.var & var2.var);
        }
        public static int32_t operator |(int32_t var1, uint8_t var2)    /* | */
        {
            return new int32_t(var1.var | var2.var);
        }
        public static int32_t operator ^(int32_t var1, uint8_t var2)    /* ^ */
        {
            return new int32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, uint8_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, uint8_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, uint8_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, uint8_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, uint8_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, uint8_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        /* Assignment */
        public static implicit operator Int16(int32_t obj)
        {
            return (Int16)obj.var;
        }

        public static implicit operator int32_t(Int16 var)
        {
            return new int32_t(var);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, int16_t var2)    /* + */
        {
            return new int32_t(var1.var + var2.var);
        }
        public static int32_t operator -(int32_t var1, int16_t var2)    /* - */
        {
            return new int32_t(var1.var - var2.var);
        }
        public static int32_t operator *(int32_t var1, int16_t var2)    /* * */
        {
            return new int32_t(var1.var * var2.var);
        }
        public static int32_t operator /(int32_t var1, int16_t var2)    /* / */
        {
            return new int32_t(var1.var / var2.var);
        }
        public static int32_t operator %(int32_t var1, int16_t var2)    /* % */
        {
            return new int32_t(var1.var % var2.var);
        }
        public static int32_t operator &(int32_t var1, int16_t var2)    /* & */
        {
            return new int32_t(var1.var & var2.var);
        }
        public static int32_t operator |(int32_t var1, int16_t var2)    /* | */
        {
            return new int32_t(var1.var | (ushort)var2.var);
        }
        public static int32_t operator ^(int32_t var1, int16_t var2)    /* ^ */
        {
            return new int32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, int16_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, int16_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, int16_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, int16_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, int16_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, int16_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        /* Assignment */
        public static implicit operator UInt16(int32_t obj)
        {
            return (UInt16)obj.var;
        }

        public static implicit operator int32_t(UInt16 var)
        {
            return new int32_t(var);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, uint16_t var2)   /* + */
        {
            return new int32_t(var1.var + var2.var);
        }
        public static int32_t operator -(int32_t var1, uint16_t var2)   /* - */
        {
            return new int32_t(var1.var - var2.var);
        }
        public static int32_t operator *(int32_t var1, uint16_t var2)   /* * */
        {
            return new int32_t(var1.var * var2.var);
        }
        public static int32_t operator /(int32_t var1, uint16_t var2)   /* / */
        {
            return new int32_t(var1.var / var2.var);
        }
        public static int32_t operator %(int32_t var1, uint16_t var2)   /* % */
        {
            return new int32_t(var1.var % var2.var);
        }
        public static int32_t operator &(int32_t var1, uint16_t var2)   /* & */
        {
            return new int32_t(var1.var & var2.var);
        }
        public static int32_t operator |(int32_t var1, uint16_t var2)   /* | */
        {
            return new int32_t(var1.var | var2.var);
        }
        public static int32_t operator ^(int32_t var1, uint16_t var2)   /* ^ */
        {
            return new int32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, uint16_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, uint16_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, uint16_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, uint16_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, uint16_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, uint16_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        /* Assignment */
        public static implicit operator Int32(int32_t obj)
        {
            return obj.var;
        }

        public static implicit operator int32_t(Int32 var)
        {
            return new int32_t(var);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, int32_t var2)    /* + */
        {
            return new int32_t(var1.var + var2.var);
        }
        public static int32_t operator ++(int32_t obj)
        {
            return (obj.var++);
        }
        public static int32_t operator -(int32_t var1, int32_t var2)    /* - */
        {
            return new int32_t(var1.var - var2.var);
        }
        public static int32_t operator --(int32_t obj)
        {
            return (obj.var--);
        }
        public static int32_t operator *(int32_t var1, int32_t var2)    /* * */
        {
            return new int32_t(var1.var * var2.var);
        }
        public static int32_t operator /(int32_t var1, int32_t var2)    /* / */
        {
            return new int32_t(var1.var / var2.var);
        }
        public static int32_t operator %(int32_t var1, int32_t var2)    /* % */
        {
            return new int32_t(var1.var % var2.var);
        }
        public static int32_t operator &(int32_t var1, int32_t var2)    /* & */
        {
            return new int32_t(var1.var & var2.var);
        }
        public static int32_t operator |(int32_t var1, int32_t var2)    /* | */
        {
            return new int32_t(var1.var | var2.var);
        }
        public static int32_t operator ^(int32_t var1, int32_t var2)    /* ^ */
        {
            return new int32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, int32_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, int32_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, int32_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, int32_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, int32_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, int32_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Assignment */
        public static implicit operator UInt32(int32_t obj)
        {
            return (UInt32)obj.var;
        }

        public static implicit operator int32_t(UInt32 var)
        {
            return new int32_t(var);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, uint32_t var2)    /* + */
        {
            return new int32_t(var1.var + var2.var);
        }
        public static int32_t operator -(int32_t var1, uint32_t var2)   /* - */
        {
            return new int32_t(var1.var - var2.var);
        }
        public static int32_t operator *(int32_t var1, uint32_t var2)   /* * */
        {
            return new int32_t(var1.var * var2.var);
        }
        public static int32_t operator /(int32_t var1, uint32_t var2)   /* / */
        {
            return new int32_t(var1.var / var2.var);
        }
        public static int32_t operator %(int32_t var1, uint32_t var2)   /* % */
        {
            return new int32_t(var1.var % var2.var);
        }
        public static int32_t operator &(int32_t var1, uint32_t var2)   /* & */
        {
            return new int32_t(var1.var & var2.var);
        }
        public static int32_t operator |(int32_t var1, uint32_t var2)   /* | */
        {
            return new int32_t((uint)var1.var | var2.var);
        }
        public static int32_t operator ^(int32_t var1, uint32_t var2)   /* ^ */
        {
            return new int32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, uint32_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, uint32_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, uint32_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, uint32_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, uint32_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, uint32_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        /* Assignment */
        public static implicit operator Int64(int32_t obj)
        {
            return obj.var;
        }

        public static implicit operator int32_t(Int64 var)
        {
            return new int32_t(var);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, int64_t var2)    /* + */
        {
            return new int32_t(var1.var + var2.var);
        }
        public static int32_t operator -(int32_t var1, int64_t var2)    /* - */
        {
            return new int32_t(var1.var - var2.var);
        }
        public static int32_t operator *(int32_t var1, int64_t var2)    /* * */
        {
            return new int32_t(var1.var * var2.var);
        }
        public static int32_t operator /(int32_t var1, int64_t var2)    /* / */
        {
            return new int32_t(var1.var / var2.var);
        }
        public static int32_t operator %(int32_t var1, int64_t var2)    /* % */
        {
            return new int32_t(var1.var % var2.var);
        }
        public static int32_t operator &(int32_t var1, int64_t var2)    /* & */
        {
            return new int32_t(var1.var & var2.var);
        }
        public static int32_t operator |(int32_t var1, int64_t var2)    /* | */
        {
            return new int32_t((uint)var1.var | var2.var);
        }
        public static int32_t operator ^(int32_t var1, int64_t var2)    /* ^ */
        {
            return new int32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, int64_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, int64_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, int64_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, int64_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, int64_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, int64_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        /* Assignment */
        public static implicit operator UInt64(int32_t obj)
        {
            return (UInt64)obj.var;
        }

        public static implicit operator int32_t(UInt64 var)
        {
            return new int32_t(var);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, uint64_t var2)   /* + */
        {
            return new int32_t((ulong)var1.var + var2.var);
        }
        public static int32_t operator -(int32_t var1, uint64_t var2)   /* - */
        {
            return new int32_t((ulong)var1.var - var2.var);
        }
        public static int32_t operator *(int32_t var1, uint64_t var2)   /* * */
        {
            return new int32_t((ulong)var1.var * var2.var);
        }
        public static int32_t operator /(int32_t var1, uint64_t var2)   /* / */
        {
            return new int32_t((ulong)var1.var / var2.var);
        }
        public static int32_t operator %(int32_t var1, uint64_t var2)   /* % */
        {
            return new int32_t((ulong)var1.var % var2.var);
        }
        public static int32_t operator &(int32_t var1, uint64_t var2)   /* & */
        {
            return new int32_t((ulong)var1.var & var2.var);
        }
        public static int32_t operator |(int32_t var1, uint64_t var2)   /* | */
        {
            return new int32_t((uint)var1.var | var2.var);
        }
        public static int32_t operator ^(int32_t var1, uint64_t var2)   /* ^ */
        {
            return new int32_t((ulong)var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, uint64_t var2)      /* > */
        {
            return (var1.var > (Int64)var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, uint64_t var2)      /* < */
        {
            return (var1.var < (Int64)var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, uint64_t var2)     /* <= */
        {
            return (var1.var <= (Int64)var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, uint64_t var2)     /* >= */
        {
            return (var1.var >= (Int64)var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, uint64_t var2)     /* == */
        {
            return (var1.var == (Int64)var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, uint64_t var2)     /* != */
        {
            return (var1.var != (Int64)var2.var) ? true : false;
        }
        #endregion
        #region int
        /* Math */
        public static int32_t operator +(int32_t var1, int var2)        /* + */
        {
            return new int32_t(var1.var + var2);
        }
        public static int32_t operator -(int32_t var1, int var2)        /* - */
        {
            return new int32_t(var1.var - var2);
        }
        public static int32_t operator *(int32_t var1, int var2)        /* * */
        {
            return new int32_t(var1.var * var2);
        }
        public static int32_t operator /(int32_t var1, int var2)        /* / */
        {
            return new int32_t(var1.var / var2);
        }
        public static int32_t operator %(int32_t var1, int var2)        /* % */
        {
            return new int32_t(var1.var % var2);
        }
        public static int32_t operator &(int32_t var1, int var2)        /* & */
        {
            return new int32_t(var1.var & var2);
        }
        public static int32_t operator |(int32_t var1, int var2)        /* | */
        {
            return new int32_t(var1.var | var2);
        }
        public static int32_t operator ^(int32_t var1, int var2)        /* ^ */
        {
            return new int32_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, int var2)           /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int32_t var1, int var2)           /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int32_t var1, int var2)          /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int32_t var1, int var2)          /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int32_t var1, int var2)          /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int32_t var1, int var2)          /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Math */
        public static int32_t operator +(int32_t var1, byte var2)       /* + */
        {
            return new int32_t(var1.var + var2);
        }
        public static int32_t operator -(int32_t var1, byte var2)       /* - */
        {
            return new int32_t(var1.var - var2);
        }
        public static int32_t operator *(int32_t var1, byte var2)       /* * */
        {
            return new int32_t(var1.var * var2);
        }
        public static int32_t operator /(int32_t var1, byte var2)       /* / */
        {
            return new int32_t(var1.var * var2);
        }
        public static int32_t operator %(int32_t var1, byte var2)       /* % */
        {
            return new int32_t(var1.var % var2);
        }
        public static int32_t operator &(int32_t var1, byte var2)       /* & */
        {
            return new int32_t(var1.var & var2);
        }
        public static int32_t operator |(int32_t var1, byte var2)       /* | */
        {
            return new int32_t(var1.var | var2);
        }
        public static int32_t operator ^(int32_t var1, byte var2)       /* ^ */
        {
            return new int32_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, byte var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int32_t var1, byte var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int32_t var1, byte var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int32_t var1, byte var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int32_t var1, byte var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int32_t var1, byte var2)         /* != */
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
        public UInt32 var = 0;

        #region Constructors
        public uint32_t()               { var = 0; }
        public uint32_t(byte value)     { var = (UInt32)value; }
        public uint32_t(SByte value)    { var = (UInt32)value; }
        public uint32_t(Int16 value)    { var = (UInt32)value; }
        public uint32_t(UInt16 value)   { var = (UInt32)value; }
        public uint32_t(int value)      { var = (UInt32)value; }
        public uint32_t(UInt32 value)   { var = value; }
        public uint32_t(Int64 value)    { var = (UInt32)value; }
        public uint32_t(UInt64 value)   { var = (UInt32)value; }
        public uint32_t(int8_t value)   { var = (UInt32)value.var; }
        public uint32_t(uint8_t value)  { var = (UInt32)value.var; }
        public uint32_t(int16_t value)  { var = (UInt32)value.var; }
        public uint32_t(uint16_t value) { var = (UInt32)value.var; }
        public uint32_t(int32_t value)  { var = (UInt32)value.var; }
        public uint32_t(uint32_t value) { var = value.var; }
        public uint32_t(int64_t value)  { var = (UInt32)value.var; }
        public uint32_t(uint64_t value) { var = (UInt32)value.var; }
        #endregion

        #region int8_t
        /* Assignment */
        public static implicit operator sbyte(uint32_t obj)
        {
            return (sbyte)obj.var;
        }

        public static implicit operator uint32_t(sbyte var)
        {
            return new uint32_t(var);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, int8_t var2)   /* + */
        {
            return new uint32_t(var1.var + var2.var);
        }
        public static uint32_t operator -(uint32_t var1, int8_t var2)   /* - */
        {
            return new uint32_t(var1.var - var2.var);
        }
        public static uint32_t operator *(uint32_t var1, int8_t var2)   /* * */
        {
            return new uint32_t(var1.var * var2.var);
        }
        public static uint32_t operator /(uint32_t var1, int8_t var2)   /* / */
        {
            return new uint32_t(var1.var / var2.var);
        }
        public static uint32_t operator %(uint32_t var1, int8_t var2)   /* % */
        {
            return new uint32_t(var1.var % var2.var);
        }
        public static uint32_t operator &(uint32_t var1, int8_t var2)   /* & */
        {
            return new uint32_t(var1.var & var2.var);
        }
        public static uint32_t operator |(uint32_t var1, int8_t var2)   /* | */
        {
            return new uint32_t(var1.var | (byte)var2.var);
        }
        public static uint32_t operator ^(uint32_t var1, int8_t var2)   /* ^ */
        {
            return new uint32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, int8_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, int8_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, int8_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, int8_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, int8_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, int8_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Assignment */
        public static implicit operator byte(uint32_t obj)
        {
            return (byte)obj.var;
        }

        public static implicit operator uint32_t(byte var)
        {
            return new uint32_t(var);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, uint8_t var2)  /* + */
        {
            return new uint32_t(var1.var + var2.var);
        }
        public static uint32_t operator -(uint32_t var1, uint8_t var2)  /* - */
        {
            return new uint32_t(var1.var - var2.var);
        }
        public static uint32_t operator *(uint32_t var1, uint8_t var2)  /* * */
        {
            return new uint32_t(var1.var * var2.var);
        }
        public static uint32_t operator /(uint32_t var1, uint8_t var2)  /* / */
        {
            return new uint32_t(var1.var / var2.var);
        }
        public static uint32_t operator %(uint32_t var1, uint8_t var2)  /* % */
        {
            return new uint32_t(var1.var % var2.var);
        }
        public static uint32_t operator &(uint32_t var1, uint8_t var2)  /* & */
        {
            return new uint32_t(var1.var & var2.var);
        }
        public static uint32_t operator |(uint32_t var1, uint8_t var2)  /* | */
        {
            return new uint32_t(var1.var | var2.var);
        }
        public static uint32_t operator ^(uint32_t var1, uint8_t var2)  /* ^ */
        {
            return new uint32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, uint8_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, uint8_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, uint8_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, uint8_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, uint8_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, uint8_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        /* Assignment */
        public static implicit operator Int16(uint32_t obj)
        {
            return (Int16)obj.var;
        }

        public static implicit operator uint32_t(Int16 var)
        {
            return new uint32_t(var);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, int16_t var2)  /* + */
        {
            return new uint32_t(var1.var + var2.var);
        }
        public static uint32_t operator -(uint32_t var1, int16_t var2)  /* - */
        {
            return new uint32_t(var1.var - var2.var);
        }
        public static uint32_t operator *(uint32_t var1, int16_t var2)  /* * */
        {
            return new uint32_t(var1.var * var2.var);
        }
        public static uint32_t operator /(uint32_t var1, int16_t var2)  /* / */
        {
            return new uint32_t(var1.var / var2.var);
        }
        public static uint32_t operator %(uint32_t var1, int16_t var2)  /* % */
        {
            return new uint32_t(var1.var % var2.var);
        }
        public static uint32_t operator &(uint32_t var1, int16_t var2)  /* & */
        {
            return new uint32_t(var1.var & var2.var);
        }
        public static uint32_t operator |(uint32_t var1, int16_t var2)  /* | */
        {
            return new uint32_t(var1.var | (ushort)var2.var);
        }
        public static uint32_t operator ^(uint32_t var1, int16_t var2)  /* ^ */
        {
            return new uint32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, int16_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, int16_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, int16_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, int16_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, int16_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, int16_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        /* Assignment */
        public static implicit operator UInt16(uint32_t obj)
        {
            return (UInt16)obj.var;
        }

        public static implicit operator uint32_t(UInt16 var)
        {
            return new uint32_t(var);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, uint16_t var2) /* + */
        {
            return new uint32_t(var1.var + var2.var);
        }
        public static uint32_t operator -(uint32_t var1, uint16_t var2) /* - */
        {
            return new uint32_t(var1.var - var2.var);
        }
        public static uint32_t operator *(uint32_t var1, uint16_t var2) /* * */
        {
            return new uint32_t(var1.var * var2.var);
        }
        public static uint32_t operator /(uint32_t var1, uint16_t var2) /* / */
        {
            return new uint32_t(var1.var / var2.var);
        }
        public static uint32_t operator %(uint32_t var1, uint16_t var2) /* % */
        {
            return new uint32_t(var1.var % var2.var);
        }
        public static uint32_t operator &(uint32_t var1, uint16_t var2) /* & */
        {
            return new uint32_t(var1.var & var2.var);
        }
        public static uint32_t operator |(uint32_t var1, uint16_t var2) /* | */
        {
            return new uint32_t(var1.var | var2.var);
        }
        public static uint32_t operator ^(uint32_t var1, uint16_t var2) /* ^ */
        {
            return new uint32_t(var1.var ^ var2.var);
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
        public static bool operator !=(uint32_t var1, uint16_t var2)    /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        /* Assignment */
        public static implicit operator Int32(uint32_t obj)
        {
            return (Int32)obj.var;
        }

        public static implicit operator uint32_t(Int32 var)
        {
            return new uint32_t(var);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, int32_t var2)  /* + */
        {
            return new uint32_t(var1.var + var2.var);
        }
        public static uint32_t operator -(uint32_t var1, int32_t var2)  /* - */
        {
            return new uint32_t(var1.var - var2.var);
        }
        public static uint32_t operator *(uint32_t var1, int32_t var2)  /* * */
        {
            return new uint32_t(var1.var * var2.var);
        }
        public static uint32_t operator /(uint32_t var1, int32_t var2)  /* / */
        {
            return new uint32_t(var1.var / var2.var);
        }
        public static uint32_t operator %(uint32_t var1, int32_t var2)  /* % */
        {
            return new uint32_t(var1.var % var2.var);
        }
        public static uint32_t operator &(uint32_t var1, int32_t var2)  /* & */
        {
            return new uint32_t(var1.var & var2.var);
        }
        public static uint32_t operator |(uint32_t var1, int32_t var2)  /* | */
        {
            return new uint32_t(var1.var | (uint)var2.var);
        }
        public static uint32_t operator ^(uint32_t var1, int32_t var2)  /* ^ */
        {
            return new uint32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, int32_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, int32_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, int32_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, int32_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, int32_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, int32_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Assignment */
        public static implicit operator UInt32(uint32_t obj)
        {
            return obj.var;
        }

        public static implicit operator uint32_t(UInt32 var)
        {
            return new uint32_t(var);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, uint32_t var2) /* + */
        {
            return new uint32_t(var1.var + var2.var);
        }
        public static uint32_t operator ++(uint32_t obj)                /* ++ */
        {
            return (obj.var++);
        }
        public static uint32_t operator -(uint32_t var1, uint32_t var2) /* - */
        {
            return new uint32_t(var1.var - var2.var);
        }
        public static uint32_t operator --(uint32_t obj)                /* -- */
        {
            return (obj.var--);
        }
        public static uint32_t operator *(uint32_t var1, uint32_t var2) /* * */
        {
            return new uint32_t(var1.var * var2.var);
        }
        public static uint32_t operator /(uint32_t var1, uint32_t var2) /* / */
        {
            return new uint32_t(var1.var / var2.var);
        }
        public static uint32_t operator %(uint32_t var1, uint32_t var2) /* % */
        {
            return new uint32_t(var1.var % var2.var);
        }
        public static uint32_t operator &(uint32_t var1, uint32_t var2) /* & */
        {
            return new uint32_t(var1.var & var2.var);
        }
        public static uint32_t operator |(uint32_t var1, uint32_t var2) /* | */
        {
            return new uint32_t(var1.var | var2.var);
        }
        public static uint32_t operator ^(uint32_t var1, uint32_t var2) /* ^ */
        {
            return new uint32_t(var1.var ^ var2.var);
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
        public static bool operator !=(uint32_t var1, uint32_t var2)    /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        /* Assignment */
        public static implicit operator Int64(uint32_t obj)
        {
            return (Int64)obj.var;
        }

        public static implicit operator uint32_t(Int64 var)
        {
            return new uint32_t(var);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, int64_t var2)  /* + */
        {
            return new uint32_t(var1.var + var2.var);
        }
        public static uint32_t operator -(uint32_t var1, int64_t var2)  /* - */
        {
            return new uint32_t(var1.var - var2.var);
        }
        public static uint32_t operator *(uint32_t var1, int64_t var2)  /* * */
        {
            return new uint32_t(var1.var * var2.var);
        }
        public static uint32_t operator /(uint32_t var1, int64_t var2)  /* / */
        {
            return new uint32_t(var1.var / var2.var);
        }
        public static uint32_t operator %(uint32_t var1, int64_t var2)  /* % */
        {
            return new uint32_t(var1.var % var2.var);
        }
        public static uint32_t operator &(uint32_t var1, int64_t var2)  /* & */
        {
            return new uint32_t(var1.var & var2.var);
        }
        public static uint32_t operator |(uint32_t var1, int64_t var2)  /* | */
        {
            return new uint32_t(var1.var | var2.var);
        }
        public static uint32_t operator ^(uint32_t var1, int64_t var2)  /* ^ */
        {
            return new uint32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, int64_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, int64_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, int64_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, int64_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, int64_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, int64_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        /* Assignment */
        public static implicit operator UInt64(uint32_t obj)
        {
            return (UInt64)obj.var;
        }

        public static implicit operator uint32_t(UInt64 var)
        {
            return new uint32_t(var);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, uint64_t var2) /* + */
        {
            return new uint32_t(var1.var + var2.var);
        }
        public static uint32_t operator -(uint32_t var1, uint64_t var2) /* - */
        {
            return new uint32_t(var1.var - var2.var);
        }
        public static uint32_t operator *(uint32_t var1, uint64_t var2) /* * */
        {
            return new uint32_t(var1.var * var2.var);
        }
        public static uint32_t operator /(uint32_t var1, uint64_t var2) /* / */
        {
            return new uint32_t(var1.var / var2.var);
        }
        public static uint32_t operator %(uint32_t var1, uint64_t var2) /* % */
        {
            return new uint32_t(var1.var % var2.var);
        }
        public static uint32_t operator &(uint32_t var1, uint64_t var2) /* & */
        {
            return new uint32_t(var1.var & var2.var);
        }
        public static uint32_t operator |(uint32_t var1, uint64_t var2) /* | */
        {
            return new uint32_t(var1.var | var2.var);
        }
        public static uint32_t operator ^(uint32_t var1, uint64_t var2) /* ^ */
        {
            return new uint32_t(var1.var ^ var2.var);
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
        public static bool operator !=(uint32_t var1, uint64_t var2)    /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int
        /* Math */
        public static uint32_t operator +(uint32_t var1, int var2)      /* + */
        {
            return new uint32_t(var1.var + var2);
        }
        public static uint32_t operator -(uint32_t var1, int var2)      /* - */
        {
            return new uint32_t(var1.var - var2);
        }
        public static uint32_t operator *(uint32_t var1, int var2)      /* * */
        {
            return new uint32_t(var1.var * var2);
        }
        public static uint32_t operator /(uint32_t var1, int var2)      /* / */
        {
            return new uint32_t(var1.var / var2);
        }
        public static uint32_t operator %(uint32_t var1, int var2)      /* % */
        {
            return new uint32_t(var1.var % var2);
        }
        public static uint32_t operator &(uint32_t var1, int var2)      /* & */
        {
            return new uint32_t(var1.var & var2);
        }
        public static uint32_t operator |(uint32_t var1, int var2)      /* | */
        {
            return new uint32_t(var1.var | (uint)var2);
        }
        public static uint32_t operator ^(uint32_t var1, int var2)      /* ^ */
        {
            return new uint32_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, int var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint32_t var1, int var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint32_t var1, int var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint32_t var1, int var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint32_t var1, int var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint32_t var1, int var2)         /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Math */
        public static uint32_t operator +(uint32_t var1, byte var2)     /* + */
        {
            return new uint32_t(var1.var + var2);
        }
        public static uint32_t operator -(uint32_t var1, byte var2)     /* - */
        {
            return new uint32_t(var1.var - var2);
        }
        public static uint32_t operator *(uint32_t var1, byte var2)     /* * */
        {
            return new uint32_t(var1.var * var2);
        }
        public static uint32_t operator /(uint32_t var1, byte var2)     /* / */
        {
            return new uint32_t(var1.var / var2);
        }
        public static uint32_t operator %(uint32_t var1, byte var2)     /* % */
        {
            return new uint32_t(var1.var % var2);
        }
        public static uint32_t operator &(uint32_t var1, byte var2)     /* & */
        {
            return new uint32_t(var1.var & var2);
        }
        public static uint32_t operator |(uint32_t var1, byte var2)     /* | */
        {
            return new uint32_t(var1.var | var2);
        }
        public static uint32_t operator ^(uint32_t var1, byte var2)     /* ^ */
        {
            return new uint32_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, byte var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint32_t var1, byte var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint32_t var1, byte var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint32_t var1, byte var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint32_t var1, byte var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint32_t var1, byte var2)        /* != */
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
        public Int64 var = 0;

        #region Constructors
        public int64_t()                { var = 0; }
        public int64_t(byte value)      { var = (Int64)value; }
        public int64_t(SByte value)     { var = (Int64)value; }
        public int64_t(Int16 value)     { var = (Int64)value; }
        public int64_t(UInt16 value)    { var = (Int64)value; }
        public int64_t(int value)       { var = (Int64)value; }
        public int64_t(UInt32 value)    { var = (Int64)value; }
        public int64_t(Int64 value)     { var = value; }
        public int64_t(UInt64 value)    { var = (Int64)value; }
        public int64_t(int8_t value)    { var = (Int64)value.var; }
        public int64_t(uint8_t value)   { var = (Int64)value.var; }
        public int64_t(int16_t value)   { var = (Int64)value.var; }
        public int64_t(uint16_t value)  { var = (Int64)value.var; }
        public int64_t(int32_t value)   { var = (Int64)value.var; }
        public int64_t(uint32_t value)  { var = (Int64)value.var; }
        public int64_t(int64_t value)   { var = value.var; }
        public int64_t(uint64_t value)  { var = (Int64)value.var; }
        #endregion

        #region int8_t
        /* Assignment */
        public static implicit operator sbyte(int64_t obj)
        {
            return (sbyte)obj.var;
        }

        public static implicit operator int64_t(sbyte var)
        {
            return new int64_t(var);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, int8_t var2)     /* + */
        {                                                               
            return new int64_t(var1.var + var2.var);                    
        }                                                               
        public static int64_t operator -(int64_t var1, int8_t var2)     /* - */
        {                                                               
            return new int64_t(var1.var - var2.var);                    
        }                                                               
        public static int64_t operator *(int64_t var1, int8_t var2)     /* * */
        {                                                               
            return new int64_t(var1.var * var2.var);                    
        }                                                               
        public static int64_t operator /(int64_t var1, int8_t var2)     /* / */
        {                                                               
            return new int64_t(var1.var / var2.var);                    
        }                                                               
        public static int64_t operator %(int64_t var1, int8_t var2)     /* % */
        {                                                               
            return new int64_t(var1.var % var2.var);                    
        }                                                               
        public static int64_t operator &(int64_t var1, int8_t var2)     /* & */
        {                                                               
            return new int64_t(var1.var & var2.var);                    
        }                                                               
        public static int64_t operator |(int64_t var1, int8_t var2)     /* | */
        {                                                               
            return new int64_t(var1.var | (byte)var2.var);                    
        }                                                               
        public static int64_t operator ^(int64_t var1, int8_t var2)     /* ^ */
        {
            return new int64_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, int8_t var2)        /* > */
        {                                                               
            return (var1.var > var2.var) ? true : false;                
        }                                                               
        public static bool operator <(int64_t var1, int8_t var2)        /* < */
        {                                                               
            return (var1.var < var2.var) ? true : false;                
        }                                                               
        public static bool operator <=(int64_t var1, int8_t var2)       /* <= */
        {                                                               
            return (var1.var <= var2.var) ? true : false;               
        }                                                               
        public static bool operator >=(int64_t var1, int8_t var2)       /* >= */
        {                                                               
            return (var1.var >= var2.var) ? true : false;               
        }                                                               
        public static bool operator ==(int64_t var1, int8_t var2)       /* == */
        {                                                               
            return (var1.var == var2.var) ? true : false;               
        }                                                               
        public static bool operator !=(int64_t var1, int8_t var2)       /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Assignment */
        public static implicit operator byte(int64_t obj)
        {
            return (byte)obj.var;
        }

        public static implicit operator int64_t(byte var)
        {
            return new int64_t(var);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, uint8_t var2)    /* + */
        {
            return new int64_t(var1.var + var2.var);
        }
        public static int64_t operator -(int64_t var1, uint8_t var2)    /* - */
        {
            return new int64_t(var1.var - var2.var);
        }
        public static int64_t operator *(int64_t var1, uint8_t var2)    /* * */
        {
            return new int64_t(var1.var * var2.var);
        }
        public static int64_t operator /(int64_t var1, uint8_t var2)    /* / */
        {
            return new int64_t(var1.var / var2.var);
        }
        public static int64_t operator %(int64_t var1, uint8_t var2)    /* % */
        {
            return new int64_t(var1.var % var2.var);
        }
        public static int64_t operator &(int64_t var1, uint8_t var2)    /* & */
        {
            return new int64_t(var1.var & var2.var);
        }
        public static int64_t operator |(int64_t var1, uint8_t var2)    /* | */
        {
            return new int64_t(var1.var | var2.var);
        }
        public static int64_t operator ^(int64_t var1, uint8_t var2)    /* ^ */
        {
            return new int64_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, uint8_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int64_t var1, uint8_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int64_t var1, uint8_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int64_t var1, uint8_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int64_t var1, uint8_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int64_t var1, uint8_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        /* Assignment */
        public static implicit operator Int16(int64_t obj)
        {
            return (Int16)obj.var;
        }

        public static implicit operator int64_t(Int16 var)
        {
            return new int64_t(var);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, int16_t var2)    /* + */
        {
            return new int64_t(var1.var + var2.var);
        }
        public static int64_t operator -(int64_t var1, int16_t var2)    /* - */
        {
            return new int64_t(var1.var - var2.var);
        }
        public static int64_t operator *(int64_t var1, int16_t var2)    /* * */
        {
            return new int64_t(var1.var * var2.var);
        }
        public static int64_t operator /(int64_t var1, int16_t var2)    /* / */
        {
            return new int64_t(var1.var / var2.var);
        }
        public static int64_t operator %(int64_t var1, int16_t var2)    /* % */
        {
            return new int64_t(var1.var % var2.var);
        }
        public static int64_t operator &(int64_t var1, int16_t var2)    /* & */
        {
            return new int64_t(var1.var & var2.var);
        }
        public static int64_t operator |(int64_t var1, int16_t var2)    /* | */
        {
            return new int64_t(var1.var | (ushort)var2.var);
        }
        public static int64_t operator ^(int64_t var1, int16_t var2)    /* ^ */
        {
            return new int64_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, int16_t var2)       /* > */
        {                                                               
            return (var1.var > var2.var) ? true : false;                
        }                                                               
        public static bool operator <(int64_t var1, int16_t var2)       /* < */
        {                                                               
            return (var1.var < var2.var) ? true : false;                
        }                                                               
        public static bool operator <=(int64_t var1, int16_t var2)      /* <= */
        {                                                               
            return (var1.var <= var2.var) ? true : false;               
        }                                                               
        public static bool operator >=(int64_t var1, int16_t var2)      /* >= */
        {                                                               
            return (var1.var >= var2.var) ? true : false;               
        }                                                               
        public static bool operator ==(int64_t var1, int16_t var2)      /* == */
        {                                                               
            return (var1.var == var2.var) ? true : false;               
        }                                                               
        public static bool operator !=(int64_t var1, int16_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        /* Assignment */
        public static implicit operator UInt16(int64_t obj)
        {
            return (UInt16)obj.var;
        }

        public static implicit operator int64_t(UInt16 var)
        {
            return new int64_t(var);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, uint16_t var2)   /* + */
        {
            return new int64_t(var1.var + var2.var);
        }
        public static int64_t operator -(int64_t var1, uint16_t var2)   /* - */
        {
            return new int64_t(var1.var - var2.var);
        }
        public static int64_t operator *(int64_t var1, uint16_t var2)   /* * */
        {
            return new int64_t(var1.var * var2.var);
        }
        public static int64_t operator /(int64_t var1, uint16_t var2)   /* / */
        {
            return new int64_t(var1.var / var2.var);
        }
        public static int64_t operator %(int64_t var1, uint16_t var2)   /* % */
        {
            return new int64_t(var1.var % var2.var);
        }
        public static int64_t operator &(int64_t var1, uint16_t var2)   /* & */
        {
            return new int64_t(var1.var & var2.var);
        }
        public static int64_t operator |(int64_t var1, uint16_t var2)   /* | */
        {
            return new int64_t(var1.var | var2.var);
        }
        public static int64_t operator ^(int64_t var1, uint16_t var2)   /* ^ */
        {
            return new int64_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, uint16_t var2)      /* > */
        {                                                               
            return (var1.var > var2.var) ? true : false;                
        }                                                               
        public static bool operator <(int64_t var1, uint16_t var2)      /* < */
        {                                                               
            return (var1.var < var2.var) ? true : false;                
        }                                                               
        public static bool operator <=(int64_t var1, uint16_t var2)     /* <= */
        {                                                               
            return (var1.var <= var2.var) ? true : false;               
        }                                                               
        public static bool operator >=(int64_t var1, uint16_t var2)     /* >= */
        {                                                               
            return (var1.var >= var2.var) ? true : false;               
        }                                                               
        public static bool operator ==(int64_t var1, uint16_t var2)     /* == */
        {                                                               
            return (var1.var == var2.var) ? true : false;               
        }                                                               
        public static bool operator !=(int64_t var1, uint16_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        /* Assignment */
        public static implicit operator Int32(int64_t obj)
        {
            return (Int32)obj.var;
        }

        public static implicit operator int64_t(Int32 var)
        {
            return new int64_t(var);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, int32_t var2)    /* + */
        {
            return new int64_t(var1.var + var2.var);
        }
        public static int64_t operator -(int64_t var1, int32_t var2)    /* - */
        {
            return new int64_t(var1.var - var2.var);
        }
        public static int64_t operator *(int64_t var1, int32_t var2)    /* * */
        {
            return new int64_t(var1.var * var2.var);
        }
        public static int64_t operator /(int64_t var1, int32_t var2)    /* / */
        {
            return new int64_t(var1.var / var2.var);
        }
        public static int64_t operator %(int64_t var1, int32_t var2)    /* % */
        {
            return new int64_t(var1.var % var2.var);
        }
        public static int64_t operator &(int64_t var1, int32_t var2)    /* & */
        {
            return new int64_t(var1.var & var2.var);
        }
        public static int64_t operator |(int64_t var1, int32_t var2)    /* | */
        {
            return new int64_t(var1.var | (uint)var2.var);
        }
        public static int64_t operator ^(int64_t var1, int32_t var2)    /* ^ */
        {
            return new int64_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, int32_t var2)       /* > */
        {                                                               
            return (var1.var > var2.var) ? true : false;                
        }                                                               
        public static bool operator <(int64_t var1, int32_t var2)       /* < */
        {                                                               
            return (var1.var < var2.var) ? true : false;                
        }                                                               
        public static bool operator <=(int64_t var1, int32_t var2)      /* <= */
        {                                                               
            return (var1.var <= var2.var) ? true : false;               
        }                                                               
        public static bool operator >=(int64_t var1, int32_t var2)      /* >= */
        {                                                               
            return (var1.var >= var2.var) ? true : false;               
        }                                                               
        public static bool operator ==(int64_t var1, int32_t var2)      /* == */
        {                                                               
            return (var1.var == var2.var) ? true : false;               
        }                                                               
        public static bool operator !=(int64_t var1, int32_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Assignment */
        public static implicit operator UInt32(int64_t obj)
        {
            return (UInt32)obj.var;
        }

        public static implicit operator int64_t(UInt32 var)
        {
            return new int64_t(var);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, uint32_t var2)   /* + */
        {
            return new int64_t(var1.var + var2.var);
        }
        public static int64_t operator -(int64_t var1, uint32_t var2)   /* - */
        {
            return new int64_t(var1.var - var2.var);
        }
        public static int64_t operator *(int64_t var1, uint32_t var2)   /* * */
        {
            return new int64_t(var1.var * var2.var);
        }
        public static int64_t operator /(int64_t var1, uint32_t var2)   /* / */
        {
            return new int64_t(var1.var / var2.var);
        }
        public static int64_t operator %(int64_t var1, uint32_t var2)   /* % */
        {
            return new int64_t(var1.var % var2.var);
        }
        public static int64_t operator &(int64_t var1, uint32_t var2)   /* & */
        {
            return new int64_t(var1.var & var2.var);
        }
        public static int64_t operator |(int64_t var1, uint32_t var2)   /* | */
        {
            return new int64_t(var1.var | var2.var);
        }
        public static int64_t operator ^(int64_t var1, uint32_t var2)   /* ^ */
        {
            return new int64_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, uint32_t var2)      /* > */
        {                                                               
            return (var1.var > var2.var) ? true : false;                
        }                                                               
        public static bool operator <(int64_t var1, uint32_t var2)      /* < */
        {                                                               
            return (var1.var < var2.var) ? true : false;                
        }                                                               
        public static bool operator <=(int64_t var1, uint32_t var2)     /* <= */
        {                                                               
            return (var1.var <= var2.var) ? true : false;               
        }                                                               
        public static bool operator >=(int64_t var1, uint32_t var2)     /* >= */
        {                                                               
            return (var1.var >= var2.var) ? true : false;               
        }                                                               
        public static bool operator ==(int64_t var1, uint32_t var2)     /* == */
        {                                                               
            return (var1.var == var2.var) ? true : false;               
        }                                                               
        public static bool operator !=(int64_t var1, uint32_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        /* Assignment */
        public static implicit operator Int64(int64_t obj)
        {
            return obj.var;
        }

        public static implicit operator int64_t(Int64 var)
        {
            return new int64_t(var);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, int64_t var2)    /* + */
        {
            return new int64_t(var1.var + var2.var);
        }
        public static int64_t operator ++(int64_t obj)                  /* ++ */
        {
            return (obj.var++);
        }
        public static int64_t operator -(int64_t var1, int64_t var2)    /* - */
        {
            return new int64_t(var1.var - var2.var);
        }
        public static int64_t operator --(int64_t obj)                  /* -- */
        {
            return (obj.var--);
        }
        public static int64_t operator *(int64_t var1, int64_t var2)    /* * */
        {
            return new int64_t(var1.var * var2.var);
        }
        public static int64_t operator /(int64_t var1, int64_t var2)    /* / */
        {
            return new int64_t(var1.var / var2.var);
        }
        public static int64_t operator %(int64_t var1, int64_t var2)    /* % */
        {
            return new int64_t(var1.var % var2.var);
        }
        public static int64_t operator &(int64_t var1, int64_t var2)    /* & */
        {
            return new int64_t(var1.var & var2.var);
        }
        public static int64_t operator |(int64_t var1, int64_t var2)    /* | */
        {
            return new int64_t(var1.var | var2.var);
        }
        public static int64_t operator ^(int64_t var1, int64_t var2)    /* ^ */
        {
            return new int64_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, int64_t var2)       /* > */
        {                                                               
            return (var1.var > var2.var) ? true : false;                
        }                                                               
        public static bool operator <(int64_t var1, int64_t var2)       /* < */
        {                                                               
            return (var1.var < var2.var) ? true : false;                
        }                                                               
        public static bool operator <=(int64_t var1, int64_t var2)      /* <= */
        {                                                               
            return (var1.var <= var2.var) ? true : false;               
        }                                                               
        public static bool operator >=(int64_t var1, int64_t var2)      /* >= */
        {                                                               
            return (var1.var >= var2.var) ? true : false;               
        }                                                               
        public static bool operator ==(int64_t var1, int64_t var2)      /* == */
        {                                                               
            return (var1.var == var2.var) ? true : false;               
        }                                                               
        public static bool operator !=(int64_t var1, int64_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        /* Assignment */
        public static implicit operator UInt64(int64_t obj)
        {
            return (UInt64)obj.var;
        }

        public static implicit operator int64_t(UInt64 var)
        {
            return new int64_t(var);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, uint64_t var2)   /* + */
        {
            return new int64_t((ulong)var1.var + var2.var);
        }
        public static int64_t operator -(int64_t var1, uint64_t var2)   /* - */
        {
            return new int64_t((ulong)var1.var - var2.var);
        }
        public static int64_t operator *(int64_t var1, uint64_t var2)   /* * */
        {
            return new int64_t((ulong)var1.var * var2.var);
        }
        public static int64_t operator /(int64_t var1, uint64_t var2)   /* / */
        {
            return new int64_t((ulong)var1.var / var2.var);
        }
        public static int64_t operator %(int64_t var1, uint64_t var2)   /* % */
        {
            return new int64_t((ulong)var1.var % var2.var);
        }
        public static int64_t operator &(int64_t var1, uint64_t var2)   /* & */
        {
            return new int64_t((ulong)var1.var & var2.var);
        }
        public static int64_t operator |(int64_t var1, uint64_t var2)   /* | */
        {
            return new int64_t((ulong)var1.var | var2.var);
        }
        public static int64_t operator ^(int64_t var1, uint64_t var2)   /* ^ */
        {
            return new int64_t((ulong)var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, uint64_t var2)      /* > */
        {                                                               
            return (var1.var > (Int64)var2.var) ? true : false;         
        }                                                               
        public static bool operator <(int64_t var1, uint64_t var2)      /* < */
        {                                                               
            return (var1.var < (Int64)var2.var) ? true : false;         
        }                                                               
        public static bool operator <=(int64_t var1, uint64_t var2)     /* <= */
        {                                                               
            return (var1.var <= (Int64)var2.var) ? true : false;        
        }                                                               
        public static bool operator >=(int64_t var1, uint64_t var2)     /* >= */
        {                                                               
            return (var1.var >= (Int64)var2.var) ? true : false;        
        }                                                               
        public static bool operator ==(int64_t var1, uint64_t var2)     /* == */
        {                                                               
            return (var1.var == (Int64)var2.var) ? true : false;        
        }                                                               
        public static bool operator !=(int64_t var1, uint64_t var2)     /* != */
        {
            return (var1.var != (Int64)var2.var) ? true : false;
        }
        #endregion
        #region int
        /* Math */
        public static int64_t operator +(int64_t var1, int var2)        /* + */
        {                                                               
            return new int64_t(var1.var + var2);                        
        }                                                               
        public static int64_t operator -(int64_t var1, int var2)        /* - */
        {                                                               
            return new int64_t(var1.var - var2);                        
        }                                                               
        public static int64_t operator *(int64_t var1, int var2)        /* * */
        {                                                               
            return new int64_t(var1.var * var2);                        
        }                                                               
        public static int64_t operator /(int64_t var1, int var2)        /* / */
        {                                                               
            return new int64_t(var1.var / var2);                        
        }                                                               
        public static int64_t operator %(int64_t var1, int var2)        /* % */
        {                                                               
            return new int64_t(var1.var % var2);                        
        }                                                               
        public static int64_t operator &(int64_t var1, int var2)        /* & */
        {                                                               
            return new int64_t(var1.var & var2);                        
        }                                                               
        public static int64_t operator |(int64_t var1, int var2)        /* | */
        {                                                               
            return new int64_t(var1.var | (uint)var2);                  
        }                                                               
        public static int64_t operator ^(int64_t var1, int var2)        /* ^ */
        {
            return new int64_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, int var2)           /* > */
        {                                                               
            return (var1.var > var2) ? true : false;                    
        }                                                               
        public static bool operator <(int64_t var1, int var2)           /* < */
        {                                                               
            return (var1.var < var2) ? true : false;                    
        }                                                               
        public static bool operator <=(int64_t var1, int var2)          /* <= */
        {                                                               
            return (var1.var <= var2) ? true : false;                   
        }                                                               
        public static bool operator >=(int64_t var1, int var2)          /* >= */
        {                                                               
            return (var1.var >= var2) ? true : false;                   
        }                                                               
        public static bool operator ==(int64_t var1, int var2)          /* == */
        {                                                               
            return (var1.var == var2) ? true : false;                   
        }                                                               
        public static bool operator !=(int64_t var1, int var2)          /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Math */
        public static int64_t operator +(int64_t var1, byte var2)       /* + */
        {
            return new int64_t(var1.var + var2);
        }
        public static int64_t operator -(int64_t var1, byte var2)       /* - */
        {
            return new int64_t(var1.var - var2);
        }
        public static int64_t operator *(int64_t var1, byte var2)       /* * */
        {
            return new int64_t(var1.var * var2);
        }
        public static int64_t operator /(int64_t var1, byte var2)       /* / */
        {
            return new int64_t(var1.var / var2);
        }
        public static int64_t operator %(int64_t var1, byte var2)       /* % */
        {
            return new int64_t(var1.var % var2);
        }
        public static int64_t operator &(int64_t var1, byte var2)       /* & */
        {
            return new int64_t(var1.var & var2);
        }
        public static int64_t operator |(int64_t var1, byte var2)       /* | */
        {
            return new int64_t(var1.var | var2);
        }
        public static int64_t operator ^(int64_t var1, byte var2)       /* ^ */
        {
            return new int64_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, byte var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int64_t var1, byte var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int64_t var1, byte var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int64_t var1, byte var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int64_t var1, byte var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int64_t var1, byte var2)         /* != */
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
        public UInt64 var = 0;

        #region Constructors
        public uint64_t()               { var = 0; }
        public uint64_t(byte value)     { var = (UInt64)value; }
        public uint64_t(SByte value)    { var = (UInt64)value; }
        public uint64_t(Int16 value)    { var = (UInt64)value; }
        public uint64_t(UInt16 value)   { var = (UInt64)value; }
        public uint64_t(int value)      { var = (UInt64)value; }
        public uint64_t(UInt32 value)   { var = (UInt64)value; }
        public uint64_t(Int64 value)    { var = (UInt64)value; }
        public uint64_t(UInt64 value)   { var = value; }
        public uint64_t(int8_t value)   { var = (UInt64)value.var; }
        public uint64_t(uint8_t value)  { var = (UInt64)value.var; }
        public uint64_t(int16_t value)  { var = (UInt64)value.var; }
        public uint64_t(uint16_t value) { var = (UInt64)value.var; }
        public uint64_t(int32_t value)  { var = (UInt64)value.var; }
        public uint64_t(uint32_t value) { var = (UInt64)value.var; }
        public uint64_t(int64_t value)  { var = (UInt64)value.var; }
        public uint64_t(uint64_t value) { var = value.var; }
        #endregion

        #region int8_t
        /* Assignment */
        public static implicit operator sbyte(uint64_t obj)
        {
            return (sbyte)obj.var;
        }

        public static implicit operator uint64_t(sbyte var)
        {
            return new uint64_t(var);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, int8_t var2)   /* + */
        {                                                               
            return new uint64_t(var1.var + (byte)var2.var);                   
        }                                                               
        public static uint64_t operator -(uint64_t var1, int8_t var2)   /* - */
        {                                                               
            return new uint64_t(var1.var - (byte)var2.var);                   
        }                                                               
        public static uint64_t operator *(uint64_t var1, int8_t var2)   /* * */
        {                                                               
            return new uint64_t(var1.var * (byte)var2.var);                   
        }                                                               
        public static uint64_t operator /(uint64_t var1, int8_t var2)   /* / */
        {                                                               
            return new uint64_t(var1.var / (byte)var2.var);                   
        }                                                               
        public static uint64_t operator %(uint64_t var1, int8_t var2)   /* % */
        {                                                               
            return new uint64_t(var1.var % (byte)var2.var);                   
        }                                                               
        public static uint64_t operator &(uint64_t var1, int8_t var2)   /* & */
        {                                                               
            return new uint64_t(var1.var & (byte)var2.var);                   
        }                                                               
        public static uint64_t operator |(uint64_t var1, int8_t var2)   /* | */
        {                                                               
            return new uint64_t(var1.var | (byte)var2.var);                   
        }                                                               
        public static uint64_t operator ^(uint64_t var1, int8_t var2)   /* ^ */
        {
            return new uint64_t(var1.var ^ (byte)var2.var);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, int8_t var2)       /* > */
        {                                                               
            return (var1.var > (byte)var2.var) ? true : false;          
        }                                                               
        public static bool operator <(uint64_t var1, int8_t var2)       /* < */
        {                                                               
            return (var1.var < (byte)var2.var) ? true : false;          
        }                                                               
        public static bool operator <=(uint64_t var1, int8_t var2)      /* <= */
        {                                                               
            return (var1.var <= (byte)var2.var) ? true : false;         
        }                                                               
        public static bool operator >=(uint64_t var1, int8_t var2)      /* >= */
        {                                                               
            return (var1.var >= (byte)var2.var) ? true : false;         
        }                                                               
        public static bool operator ==(uint64_t var1, int8_t var2)      /* == */
        {                                                               
            return (var1.var == (byte)var2.var) ? true : false;         
        }                                                               
        public static bool operator !=(uint64_t var1, int8_t var2)      /* != */
        {
            return (var1.var != (byte)var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Assignment */
        public static implicit operator byte(uint64_t obj)
        {
            return (byte)obj.var;
        }

        public static implicit operator uint64_t(byte var)
        {
            return new uint64_t(var);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, uint8_t var2)  /* + */
        {
            return new uint64_t(var1.var + var2.var);
        }
        public static uint64_t operator -(uint64_t var1, uint8_t var2)  /* - */
        {
            return new uint64_t(var1.var - var2.var);
        }
        public static uint64_t operator *(uint64_t var1, uint8_t var2)  /* * */
        {
            return new uint64_t(var1.var * var2.var);
        }
        public static uint64_t operator /(uint64_t var1, uint8_t var2)  /* / */
        {
            return new uint64_t(var1.var / var2.var);
        }
        public static uint64_t operator %(uint64_t var1, uint8_t var2)  /* % */
        {
            return new uint64_t(var1.var % var2.var);
        }
        public static uint64_t operator &(uint64_t var1, uint8_t var2)  /* & */
        {
            return new uint64_t(var1.var & var2.var);
        }
        public static uint64_t operator |(uint64_t var1, uint8_t var2)  /* | */
        {
            return new uint64_t(var1.var | var2.var);
        }
        public static uint64_t operator ^(uint64_t var1, uint8_t var2)  /* ^ */
        {
            return new uint64_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, uint8_t var2)      /* > */
        {                                                               
            return (var1.var > var2.var) ? true : false;                
        }                                                               
        public static bool operator <(uint64_t var1, uint8_t var2)      /* < */
        {                                                               
            return (var1.var < var2.var) ? true : false;                
        }                                                               
        public static bool operator <=(uint64_t var1, uint8_t var2)     /* <= */
        {                                                               
            return (var1.var <= var2.var) ? true : false;               
        }                                                               
        public static bool operator >=(uint64_t var1, uint8_t var2)     /* >= */
        {                                                               
            return (var1.var >= var2.var) ? true : false;               
        }                                                               
        public static bool operator ==(uint64_t var1, uint8_t var2)     /* == */
        {                                                               
            return (var1.var == var2.var) ? true : false;               
        }                                                               
        public static bool operator !=(uint64_t var1, uint8_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        /* Assignment */
        public static implicit operator Int16(uint64_t obj)
        {
            return (Int16)obj.var;
        }

        public static implicit operator uint64_t(Int16 var)
        {
            return new uint64_t(var);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, int16_t var2)  /* + */
        {
            return new uint64_t(var1.var + (ushort)var2.var);
        }
        public static uint64_t operator -(uint64_t var1, int16_t var2)  /* - */
        {
            return new uint64_t(var1.var - (ushort)var2.var);
        }
        public static uint64_t operator *(uint64_t var1, int16_t var2)  /* * */
        {
            return new uint64_t(var1.var * (ushort)var2.var);
        }
        public static uint64_t operator /(uint64_t var1, int16_t var2)  /* / */
        {
            return new uint64_t(var1.var / (ushort)var2.var);
        }
        public static uint64_t operator %(uint64_t var1, int16_t var2)  /* % */
        {
            return new uint64_t(var1.var % (ushort)var2.var);
        }
        public static uint64_t operator &(uint64_t var1, int16_t var2)  /* & */
        {
            return new uint64_t(var1.var & (ushort)var2.var);
        }
        public static uint64_t operator |(uint64_t var1, int16_t var2)  /* | */
        {
            return new uint64_t(var1.var | (ushort)var2.var);
        }
        public static uint64_t operator ^(uint64_t var1, int16_t var2)  /* ^ */
        {
            return new uint64_t(var1.var ^ (ushort)var2.var);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, int16_t var2)      /* > */
        {                                                               
            return (var1.var > (UInt16)var2.var) ? true : false;        
        }                                                               
        public static bool operator <(uint64_t var1, int16_t var2)      /* < */
        {                                                               
            return (var1.var < (UInt16)var2.var) ? true : false;        
        }                                                               
        public static bool operator <=(uint64_t var1, int16_t var2)     /* <= */
        {                                                               
            return (var1.var <= (UInt16)var2.var) ? true : false;       
        }                                                               
        public static bool operator >=(uint64_t var1, int16_t var2)     /* >= */
        {                                                               
            return (var1.var >= (UInt16)var2.var) ? true : false;       
        }                                                               
        public static bool operator ==(uint64_t var1, int16_t var2)     /* == */
        {                                                               
            return (var1.var == (UInt16)var2.var) ? true : false;       
        }                                                               
        public static bool operator !=(uint64_t var1, int16_t var2)     /* != */
        {
            return (var1.var != (UInt16)var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        /* Assignment */
        public static implicit operator UInt16(uint64_t obj)
        {
            return (UInt16)obj.var;
        }

        public static implicit operator uint64_t(UInt16 var)
        {
            return new uint64_t(var);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, uint16_t var2) /* + */
        {
            return new uint64_t(var1.var + var2.var);
        }
        public static uint64_t operator -(uint64_t var1, uint16_t var2) /* - */
        {
            return new uint64_t(var1.var - var2.var);
        }
        public static uint64_t operator *(uint64_t var1, uint16_t var2) /* * */
        {
            return new uint64_t(var1.var * var2.var);
        }
        public static uint64_t operator /(uint64_t var1, uint16_t var2) /* / */
        {
            return new uint64_t(var1.var / var2.var);
        }
        public static uint64_t operator %(uint64_t var1, uint16_t var2) /* % */
        {
            return new uint64_t(var1.var % var2.var);
        }
        public static uint64_t operator &(uint64_t var1, uint16_t var2) /* & */
        {
            return new uint64_t(var1.var & var2.var);
        }
        public static uint64_t operator |(uint64_t var1, uint16_t var2) /* | */
        {
            return new uint64_t(var1.var | var2.var);
        }
        public static uint64_t operator ^(uint64_t var1, uint16_t var2) /* ^ */
        {
            return new uint64_t(var1.var ^ var2.var);
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
        public static bool operator !=(uint64_t var1, uint16_t var2)    /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        /* Assignment */
        public static implicit operator Int32(uint64_t obj)
        {
            return (Int32)obj.var;
        }

        public static implicit operator uint64_t(Int32 var)
        {
            return new uint64_t(var);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, int32_t var2)  /* + */
        {
            return new uint64_t(var1.var + (uint)var2.var);
        }
        public static uint64_t operator -(uint64_t var1, int32_t var2)  /* - */
        {
            return new uint64_t(var1.var - (uint)var2.var);
        }
        public static uint64_t operator *(uint64_t var1, int32_t var2)  /* * */
        {
            return new uint64_t(var1.var * (uint)var2.var);
        }
        public static uint64_t operator /(uint64_t var1, int32_t var2)  /* / */
        {
            return new uint64_t(var1.var / (uint)var2.var);
        }
        public static uint64_t operator %(uint64_t var1, int32_t var2)  /* % */
        {
            return new uint64_t(var1.var % (uint)var2.var);
        }
        public static uint64_t operator &(uint64_t var1, int32_t var2)  /* & */
        {
            return new uint64_t(var1.var & (uint)var2.var);
        }
        public static uint64_t operator |(uint64_t var1, int32_t var2)  /* | */
        {
            return new uint64_t(var1.var | (uint)var2.var);
        }
        public static uint64_t operator ^(uint64_t var1, int32_t var2)  /* ^ */
        {
            return new uint64_t(var1.var ^ (uint)var2.var);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, int32_t var2)      /* > */
        {                                                               
            return (var1.var > (UInt32)var2.var) ? true : false;        
        }                                                               
        public static bool operator <(uint64_t var1, int32_t var2)      /* < */
        {                                                               
            return (var1.var < (UInt32)var2.var) ? true : false;        
        }                                                               
        public static bool operator <=(uint64_t var1, int32_t var2)     /* <= */
        {                                                               
            return (var1.var <= (UInt32)var2.var) ? true : false;       
        }                                                               
        public static bool operator >=(uint64_t var1, int32_t var2)     /* >= */
        {                                                               
            return (var1.var >= (UInt32)var2.var) ? true : false;       
        }                                                               
        public static bool operator ==(uint64_t var1, int32_t var2)     /* == */
        {                                                               
            return (var1.var == (UInt32)var2.var) ? true : false;       
        }                                                               
        public static bool operator !=(uint64_t var1, int32_t var2)     /* != */
        {
            return (var1.var != (UInt32)var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Assignment */
        public static implicit operator UInt32(uint64_t obj)
        {
            return (UInt32)obj.var;
        }

        public static implicit operator uint64_t(UInt32 var)
        {
            return new uint64_t(var);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, uint32_t var2) /* + */
        {                                                               
            return new uint64_t(var1.var + var2.var);                   
        }                                                               
        public static uint64_t operator -(uint64_t var1, uint32_t var2) /* - */
        {                                                               
            return new uint64_t(var1.var - var2.var);                   
        }                                                               
        public static uint64_t operator *(uint64_t var1, uint32_t var2) /* * */
        {                                                               
            return new uint64_t(var1.var * var2.var);                   
        }                                                               
        public static uint64_t operator /(uint64_t var1, uint32_t var2) /* / */
        {                                                               
            return new uint64_t(var1.var / var2.var);                   
        }                                                               
        public static uint64_t operator %(uint64_t var1, uint32_t var2) /* % */
        {                                                               
            return new uint64_t(var1.var % var2.var);                   
        }                                                               
        public static uint64_t operator &(uint64_t var1, uint32_t var2) /* & */
        {                                                               
            return new uint64_t(var1.var & var2.var);                   
        }                                                               
        public static uint64_t operator |(uint64_t var1, uint32_t var2) /* | */
        {                                                               
            return new uint64_t(var1.var | var2.var);                   
        }                                                               
        public static uint64_t operator ^(uint64_t var1, uint32_t var2) /* ^ */
        {
            return new uint64_t(var1.var ^ var2.var);
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
        public static bool operator !=(uint64_t var1, uint32_t var2)    /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        /* Assignment */
        public static implicit operator Int64(uint64_t obj)
        {
            return (long)obj.var;
        }

        public static implicit operator uint64_t(Int64 var)
        {
            return new uint64_t(var);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, int64_t var2)  /* + */
        {
            return new uint64_t(var1.var + (ulong)var2.var);
        }
        public static uint64_t operator -(uint64_t var1, int64_t var2)  /* - */
        {
            return new uint64_t(var1.var - (ulong)var2.var);
        }
        public static uint64_t operator *(uint64_t var1, int64_t var2)  /* * */
        {
            return new uint64_t(var1.var * (ulong)var2.var);
        }
        public static uint64_t operator /(uint64_t var1, int64_t var2)  /* / */
        {
            return new uint64_t(var1.var / (ulong)var2.var);
        }
        public static uint64_t operator %(uint64_t var1, int64_t var2)  /* % */
        {
            return new uint64_t(var1.var % (ulong)var2.var);
        }
        public static uint64_t operator &(uint64_t var1, int64_t var2)  /* & */
        {
            return new uint64_t(var1.var & (ulong)var2.var);
        }
        public static uint64_t operator |(uint64_t var1, int64_t var2)  /* | */
        {
            return new uint64_t(var1.var | (ulong)var2.var);
        }
        public static uint64_t operator ^(uint64_t var1, int64_t var2)  /* ^ */
        {
            return new uint64_t(var1.var ^ (ulong)var2.var);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, int64_t var2)      /* > */
        {                                                               
            return (var1.var > (UInt64)var2.var) ? true : false;        
        }                                                               
        public static bool operator <(uint64_t var1, int64_t var2)      /* < */
        {                                                               
            return (var1.var < (UInt64)var2.var) ? true : false;        
        }                                                               
        public static bool operator <=(uint64_t var1, int64_t var2)     /* <= */
        {                                                               
            return (var1.var <= (UInt64)var2.var) ? true : false;       
        }                                                               
        public static bool operator >=(uint64_t var1, int64_t var2)     /* >= */
        {                                                               
            return (var1.var >= (UInt64)var2.var) ? true : false;       
        }                                                               
        public static bool operator ==(uint64_t var1, int64_t var2)     /* == */
        {                                                               
            return (var1.var == (UInt64)var2.var) ? true : false;       
        }                                                               
        public static bool operator !=(uint64_t var1, int64_t var2)     /* != */
        {
            return (var1.var != (UInt64)var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        /* Assignment */
        public static implicit operator UInt64(uint64_t obj)
        {
            return (UInt64)obj.var;
        }

        public static implicit operator uint64_t(UInt64 var)
        {
            return new uint64_t(var);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, uint64_t var2) /* + */
        {
            return new uint64_t(var1.var + var2.var);
        }
        public static uint64_t operator ++(uint64_t obj)                /* ++ */
        {
            return (obj.var++);
        }
        public static uint64_t operator -(uint64_t var1, uint64_t var2) /* - */
        {
            return new uint64_t(var1.var - var2.var);
        }
        public static uint64_t operator --(uint64_t obj)                /* -- */
        {
            return (obj.var--);
        }
        public static uint64_t operator *(uint64_t var1, uint64_t var2) /* * */
        {
            return new uint64_t(var1.var * var2.var);
        }
        public static uint64_t operator /(uint64_t var1, uint64_t var2) /* / */
        {
            return new uint64_t(var1.var / var2.var);
        }
        public static uint64_t operator %(uint64_t var1, uint64_t var2) /* % */
        {
            return new uint64_t(var1.var % var2.var);
        }
        public static uint64_t operator &(uint64_t var1, uint64_t var2) /* & */
        {
            return new uint64_t(var1.var & var2.var);
        }
        public static uint64_t operator |(uint64_t var1, uint64_t var2) /* | */
        {
            return new uint64_t(var1.var | var2.var);
        }
        public static uint64_t operator ^(uint64_t var1, uint64_t var2) /* ^ */
        {
            return new uint64_t(var1.var ^ var2.var);
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
        public static bool operator !=(uint64_t var1, uint64_t var2)    /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int
        /* Math */
        public static uint64_t operator +(uint64_t var1, int var2)      /* + */
        {
            return new uint64_t(var1.var + (uint)var2);
        }
        public static uint64_t operator -(uint64_t var1, int var2)      /* - */
        {
            return new uint64_t(var1.var - (uint)var2);
        }
        public static uint64_t operator *(uint64_t var1, int var2)      /* * */
        {
            return new uint64_t(var1.var * (uint)var2);
        }
        public static uint64_t operator /(uint64_t var1, int var2)      /* / */
        {
            return new uint64_t(var1.var / (uint)var2);
        }
        public static uint64_t operator %(uint64_t var1, int var2)      /* % */
        {
            return new uint64_t(var1.var % (uint)var2);
        }
        public static uint64_t operator &(uint64_t var1, int var2)      /* & */
        {
            return new uint64_t(var1.var & (uint)var2);
        }
        public static uint64_t operator |(uint64_t var1, int var2)      /* | */
        {
            return new uint64_t(var1.var | (uint)var2);
        }
        public static uint64_t operator ^(uint64_t var1, int var2)      /* ^ */
        {
            return new uint64_t(var1.var ^ (uint)var2);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, int var2)          /* > */
        {
            return (var1.var > (UInt32)var2) ? true : false;
        }
        public static bool operator <(uint64_t var1, int var2)          /* < */
        {
            return (var1.var < (UInt32)var2) ? true : false;
        }
        public static bool operator <=(uint64_t var1, int var2)         /* <= */
        {
            return (var1.var <= (UInt32)var2) ? true : false;
        }
        public static bool operator >=(uint64_t var1, int var2)         /* >= */
        {
            return (var1.var >= (UInt32)var2) ? true : false;
        }
        public static bool operator ==(uint64_t var1, int var2)         /* == */
        {
            return (var1.var == (UInt32)var2) ? true : false;
        }
        public static bool operator !=(uint64_t var1, int var2)         /* != */
        {
            return (var1.var != (UInt32)var2) ? true : false;
        }
        #endregion
        #region byte
        /* Math */
        public static uint64_t operator +(uint64_t var1, byte var2)     /* + */
        {
            return new uint64_t(var1.var + var2);
        }
        public static uint64_t operator -(uint64_t var1, byte var2)     /* - */
        {
            return new uint64_t(var1.var - var2);
        }
        public static uint64_t operator *(uint64_t var1, byte var2)     /* * */
        {
            return new uint64_t(var1.var * var2);
        }
        public static uint64_t operator /(uint64_t var1, byte var2)     /* / */
        {
            return new uint64_t(var1.var / var2);
        }
        public static uint64_t operator %(uint64_t var1, byte var2)     /* % */
        {
            return new uint64_t(var1.var % var2);
        }
        public static uint64_t operator &(uint64_t var1, byte var2)     /* & */
        {
            return new uint64_t(var1.var & var2);
        }
        public static uint64_t operator |(uint64_t var1, byte var2)     /* | */
        {
            return new uint64_t(var1.var | var2);
        }
        public static uint64_t operator ^(uint64_t var1, byte var2)     /* ^ */
        {
            return new uint64_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, byte var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint64_t var1, byte var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint64_t var1, byte var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint64_t var1, byte var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint64_t var1, byte var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint64_t var1, byte var2)        /* != */
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