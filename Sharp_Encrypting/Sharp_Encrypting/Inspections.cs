using System;
using System.Collections.Generic;
using System.Text;

namespace Sharp_Encrypting
{
    class Inspections
    {
        public static string Check_latis(string input)
        {
            int trip_meter;
            do
            {
                trip_meter = 0;
                foreach (char c in input)
                {
                    if (!Char.IsLetter(c))
                    {
                        trip_meter++;
                    }
                }
                if(trip_meter > 0)
                {
                    Console.WriteLine("use letters only from latin alphabet");
                    input = Console.ReadLine();
                }
            }while(trip_meter > 0);
            return input.ToLower();
        }
    }
}
