using System;
using System.Collections.Generic;
using UnityEngine;

namespace StaticDataLib
{
    public class DataFieldParser
    {
        static public uint ParseUint(string content)
        {
            uint val = 0;
            if(uint.TryParse(content, out val))
            {
                return val;
            }

            return 0;
        }
        
        static public int ParseInt(string content)
        {
            int val = 0;
            if (int.TryParse(content, out val))
            {
                return val;
            }

            return 0;
        }

        static public float ParseFloat(string content)
        {
            float val = 0f;
            if (float.TryParse(content, out val))
            {
                return val;
            }

            return 0f;
        }

        static public string[] ParserStringList(string content, char chr)
        {
            return content.Split(chr);
        }

        static public int[] ParseIntList(string content, char chr)
        {
            string[] strList = ParserStringList(content, chr);
            int[] val = new int[strList.Length];
            for(int i=0,len=strList.Length; i<len; ++i)
            {
                val[i] = ParseInt(strList[i]);
            }

            return val;
        }

        static public uint[] ParseUintList(string content, char chr)
        {
            string[] strList = ParserStringList(content, chr);
            uint[] val = new uint[strList.Length];
            for (int i = 0, len = strList.Length; i < len; ++i)
            {
                val[i] = ParseUint(strList[i]);
            }

            return val;
        }

        static public float[] ParseFloatList(string content, char chr)
        {
            string[] strList = ParserStringList(content, chr);
            float[] val = new float[strList.Length];
            for (int i = 0, len = strList.Length; i < len; ++i)
            {
                val[i] = ParseFloat(strList[i]);
            }

            return val;
        }

        static public Vector3 ParseVector3(string content, char chr)
        {
            float[] valList = ParseFloatList(content, chr);
            Vector3 val = Vector3.zero;
            val.x = valList.Length>=1?valList[0]:0f;
            val.y = valList.Length>=2?valList[1]:0f;
            val.z = valList.Length>=3?valList[2]:0f;
            return val;
        }

        static public Vector2 ParseVector2(string content, char chr)
        {
            float[] valList = ParseFloatList(content, chr);
            Vector2 val = Vector2.zero;
            val.x = valList.Length >= 1 ? valList[0] : 0f;
            val.y = valList.Length >= 2 ? valList[1] : 0f;
            return val;
        }
    }
}
