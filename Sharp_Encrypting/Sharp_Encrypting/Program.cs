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
            string check_res = Transformations.Encr_vigener(input,key,lat_alpha);
            Console.WriteLine($"\nEncryptet messsage - {check_res}");
            Console.WriteLine($"\nDecryptet message - {Transformations.Decr_vigener(check_res,key,lat_alpha)}");
        }       
    }
}
