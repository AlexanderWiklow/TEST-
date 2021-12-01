using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_sats
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 10;
            int value2 = 20;

            if (value1 > value2)
            {
                Console.WriteLine("Värdet: {0} är större än: {1}", value1, value2);
            }
            else 
            {
                Console.WriteLine("Värdet: {0} är större än: {1}", value2, value1);
            }

            value1 = 30;

            if (value1 > value2)
            {
                value2 = value1++;
                Console.WriteLine("\nValue2 får värdet av värde1,");
                Console.WriteLine("och value räknas upp med ett. \n");
                Console.WriteLine("Value1: {0} är större än Value2: {1}", value1, value2);
            }
            else
            {
                value1 = value2;
                Console.WriteLine("Value1 och Value2 är lika");
                Console.WriteLine("Value1: {0} Value2: {1}", value1, value2);
            }

            Console.ReadLine();
        }
    }
}
