using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_conditionals_multiple_if
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOn = true;
            bool isHot = false;

            if (isOn)
            {
                Console.WriteLine("The light is on. It is bright.");
            }
            if (isOn == true)
            {
                Console.WriteLine("The light is on.");
            }
            if (isOn && isHot)
            {
                Console.WriteLine("Lights on and it's hot");
            }
            if (isOn || isHot)
            {
                Console.WriteLine("Lights on or it is hot.");
            }
            if (!isHot)
            {
                Console.WriteLine("It is not hot.");
            }

            
        }
    }
}
