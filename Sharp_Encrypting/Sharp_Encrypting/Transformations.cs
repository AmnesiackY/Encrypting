using System;
using System.Collections.Generic;
using System.Text;

namespace Sharp_Encrypting
{
    class Transformations
    {
        public static string Encr_vigener(string input, string key, Dictionary<int, char> lat_alpha)
        {
            string result_encr = "";
            for (int i = 0; i < input.Length; i++)
            {
                int encr_key = 0;
                foreach (KeyValuePair<int, char> keyvalue in lat_alpha)
                {
                    if (input[i] == keyvalue.Value)
                    {
                        encr_key += keyvalue.Key;
                    }
                    if (key[i] == keyvalue.Value)
                    {
                        encr_key += keyvalue.Key;
                    }
                }
                if (encr_key > 25)
                {
                    encr_key -= 26;
                }
                result_encr += lat_alpha[encr_key];
            }
            return result_encr;
        }
        public static string Decr_vigener(string input, string key, Dictionary<int, char> lat_alpha)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                int encoded_key = 0;
                int keyword = 0;
                foreach (KeyValuePair<int, char> keyvalue in lat_alpha)
                {
                    if (input[i] == keyvalue.Value)
                    {
                        encoded_key = keyvalue.Key;
                    }
                    if (key[i] == keyvalue.Value)
                    {
                        keyword = keyvalue.Key;
                    }
                }
                int decrypyt_formulas = (encoded_key - keyword) + 26;
                if (decrypyt_formulas > 25)
                {
                    decrypyt_formulas -= 26;
                }
                result += lat_alpha[decrypyt_formulas];
            }
            return result;
        }
    }
}
