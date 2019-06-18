using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machineLearning2
{
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
        public int8_t() {var = 0;}
        public int8_t(byte value) { var = (SByte)value; }
        public int8_t(SByte value) { var = value; }
        public int8_t(int value) { var = (SByte)value; }
        public int8_t(int8_t value) { var = value.var; }
        public int8_t(uint8_t value) { var = (SByte)value.var; }
        public int8_t(int16_t value) { var = (SByte)value.var; }
        public int8_t(uint16_t value) { var = (SByte)value.var; }
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
        public override bool Equals(object obj)
        {
            return (obj is int8_t)? this == (int8_t)obj : false;
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
    }

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
        public uint8_t(int value) { var = (byte)value; }
        public uint8_t(int8_t value) { var = (byte)value.var; }
        public uint8_t(uint8_t value) { var = value.var; }
        public uint8_t(int16_t value) { var = (byte)value.var; }
        public uint8_t(uint16_t value) { var = (byte)value.var; }
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
    }

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
        public int16_t(int value) { var = (Int16)value; }
        public int16_t(int8_t value) { var = (Int16)value.var; }
        public int16_t(uint8_t value) { var = (Int16)value.var; }
        public int16_t(int16_t value) { var = value.var; }
        public int16_t(uint16_t value) { var = (Int16)value.var; }
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
    }

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
        public uint16_t(int value) { var = (UInt16)value; }
        public uint16_t(int8_t value) { var = (UInt16)value.var; }
        public uint16_t(uint8_t value) { var = (UInt16)value.var; }
        public uint16_t(int16_t value) { var = (UInt16)value.var; }
        public uint16_t(uint16_t value) { var = value.var; }
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
    }
}
