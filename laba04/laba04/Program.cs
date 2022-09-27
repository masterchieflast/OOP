namespace laba04
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--------------------1(IT)-------------------");
            var engine = new Engine("volkswagen", 457);
            var car = new Car(4, "car", engine, 100, 10);

            car.SpeedControl();
            ITransport iTransport = car;
            iTransport.SpeedControl();

            var Porsche = new Car(4, "Porsche", engine, 412.4, 23);
            var superEngine = new Engine("XE-45A", 5812);
            var transformer = new Transformer(superEngine, "Optimus", 3408, 5476);

            Console.WriteLine("--------------------2(is)-------------------");
            if (Porsche is CarManagement)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(false);
            }

            if (Porsche is ITransport)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(false);
            }

            if (Porsche is Human)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(false);
            }

            Console.WriteLine("--------------------3(as)-------------------");

            ITransport iCar = Porsche;
            if (iCar as Car != null)
            {
                Console.WriteLine($"({iCar}) as car\n");
            }

            Console.WriteLine("--------------------4(Print)----------------");

            var array = new Car[] { Porsche, car };

            foreach (var e in array)
            {
                Printer.IAmPrinting(e);
            }
        }
    }
}
