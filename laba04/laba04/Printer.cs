﻿namespace laba04
{
    public class Printer
    {
        public static void IAmPrinting(TransportVehicle element)
        {
            if (element is TransportVehicle)
            {
                Console.WriteLine($"Type object({element.GetType()}): " + element);
            }
            else
            {
                var temp = element as Car;
                if (temp != null)
                    Console.WriteLine($"Type object({temp.GetType()}): " + temp);
            }
        }
    }
}
