using System;
using System.Collections.Generic;

namespace Sharp_Encrypting
{
    class Program
    {
        static void Main(string[] args)
        {
            int saturation_counter = 0;
            

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
            string check_res = Transformations.Encr_vigener(input,key);
            Console.WriteLine($"\nEncryptet messsage - {check_res}");
            Console.WriteLine($"\nDecryptet message - {Transformations.Decr_vigener(check_res,key)}");
        }       
    }
}
