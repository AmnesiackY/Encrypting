using System;
using System.Collections.Generic;

namespace Sharp_Encrypting
{
    class Program
    {
        static void Main(string[] args)
        {
            int saturation_counter = 0;
            Dictionary<int, char> lat_alpha = new Dictionary<int, char>
            {
                { 0, 'a' },
                { 1, 'b' },
                { 2, 'c' },
                { 3, 'd' },
                { 4, 'e' },
                { 5, 'f' },
                { 6, 'g' },
                { 7, 'h' },
                { 8, 'i' },
                { 9, 'j' },
                { 10, 'k' },
                { 11, 'l' },
                { 12, 'm' },
                { 13, 'n' },
                { 14, 'o' },
                { 15, 'p' },
                { 16, 'q' },
                { 17, 'r' },
                { 18, 's' },
                { 19, 't' },
                { 20, 'u' },
                { 21, 'v' },
                { 22, 'w' },
                { 23, 'x' },
                { 24, 'y' },
                { 25, 'z' }
            };

            Console.WriteLine("Hello young scrambler!");
            Console.WriteLine("Enter phrase for encrypting: ");
            string input = Inspections.Check_latis(Console.ReadLine());
            Console.WriteLine("Enter your check-key: ");
            string key = Inspections.Check_latis(Console.ReadLine());
            if(key.Length < input.Length)
            {
                for(int i = key.Length; i < input.Length; i++)
                {
                    key += key[saturation_counter];
                    saturation_counter++;
                    if(saturation_counter == key.Length)
                    {
                        saturation_counter = 0;
                    }
                }
            }
            if(key.Length > input.Length)
            {
                key = key.Substring(0, input.Length);
            } 
            string check_res = Encr_vigener(input,key,lat_alpha);
            Console.WriteLine($"Encryptet messsage - {check_res}");
            Console.WriteLine($"Decryptet message - {Decr_vigener(check_res,key,lat_alpha)}");




        }
        static string Encr_vigener(string input,string key, Dictionary<int,char> lat_alpha)
        {
            string result_encr = "";
            int encr_key = 0;

            for(int i = 0; i < input.Length; i++)
            {   
                foreach(KeyValuePair<int,char> keyvalue in lat_alpha)
                {
                    if(input[i] == keyvalue.Value)
                    {
                        encr_key += keyvalue.Key;
                    }
                    if(key[i] == keyvalue.Value)
                    {
                        encr_key += keyvalue.Key;
                    }
                }
                if(encr_key > 25)
                {
                    encr_key -= 26;
                }
                result_encr += lat_alpha[encr_key];
            }
            return result_encr;
        }
        static string Decr_vigener(string input, string key, Dictionary<int, char> lat_alpha)
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
                int decrypyt_formulas = (encoded_key - keyword ) + 26;
                if(decrypyt_formulas > 25)
                {
                    decrypyt_formulas -= 26;
                }
                result += lat_alpha[decrypyt_formulas];
            }
            return result;
        }
    }
}
