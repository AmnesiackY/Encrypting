using System;
using System.Collections.Generic;

namespace Sharp_Encrypting
{
    class Program
    {
        static void Main(string[] args)
        {
            int saturation_counter = 0;
            Dictionary<int,char> encrpt = new Dictionary<int,char>();
            encrpt.Add(0, 'a');
            encrpt.Add(1, 'b');
            encrpt.Add(2, 'c');
            encrpt.Add(3, 'd');
            encrpt.Add(4, 'e');
            encrpt.Add(5, 'f');
            encrpt.Add(6, 'g');
            encrpt.Add(7, 'h');
            encrpt.Add(8, 'i');
            encrpt.Add(9, 'j');
            encrpt.Add(10, 'k');
            encrpt.Add(11, 'l');
            encrpt.Add(12, 'm');
            encrpt.Add(13, 'n');
            encrpt.Add(14, 'o');
            encrpt.Add(15, 'p');
            encrpt.Add(16, 'q');
            encrpt.Add(17, 'r');
            encrpt.Add(18, 's');
            encrpt.Add(19, 't');
            encrpt.Add(20, 'u');
            encrpt.Add(21, 'v');
            encrpt.Add(22, 'w');
            encrpt.Add(23, 'x');
            encrpt.Add(24, 'y');
            encrpt.Add(25, 'z'); 

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

        }
    }
}
