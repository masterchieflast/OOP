﻿using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace laba05
{
    class Program
    {
        public static void Main()
        {
            #region task from lab04
            //Console.WriteLine("--------------------1(IT)-------------------");
            //var engine = new Engine("volkswagen", 457);
            //var car = new Car(4, "car", engine, 100, 10);

            //car.SpeedControl();
            //((ITransport)car).SpeedControl();
            //ITransport iTransport = car;
            //iTransport.SpeedControl();

            //var Porsche = new Car(4, "Porsche", engine, 412.4, 23);
            //var superEngine = new Engine("XE-45A", 5812);
            //var transformer = new Transformer(superEngine, "Optimus", new DateTime(2004, 5, 16), 5476);

            //Console.WriteLine("--------------------2(is)-------------------");
            //if (Porsche is CarManagement)
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            //if (Porsche is ITransport)
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            //if (Porsche is Human)
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            //Console.WriteLine("--------------------3(as)-------------------");

            //ITransport iCar = Porsche;
            //if (iCar as Car != null)
            //{
            //    Console.WriteLine($"({iCar}) as car\n");
            //}

            //Console.WriteLine("--------------------4(Print)----------------");

            //var array = new ITransport[] { Porsche, car, transformer };

            //foreach (var e in array)
            //{
            //    Printer.IAmPrinting(e);
            //}

            //Console.WriteLine("--------------------5(car)------------------");
            //Porsche.Drive();
            //Porsche.Launch();
            //Porsche.Drive();
            //Porsche.Shutdown();
            #endregion
            var army = new Army();

            using (var file = new FileStream("note.txt", FileMode.OpenOrCreate))
            {
                var buffer = new byte[file.Length];
                file.Read(buffer, 0, buffer.Length);
                var textFromFile = Encoding.Default.GetString(buffer);
                var ArmyArray = textFromFile.Split("\r\n");

                foreach (var being in ArmyArray)
                {
                    var data = being.Split(" ");
                    
                    switch (data.Length)
                    {
                        case 7:
                            army.Add(new Transformer(Convert.ToInt32(data[0]), data[1], 
                                new DateTime(Convert.ToInt32(data[2]), Convert.ToInt32(data[3]), Convert.ToInt32(data[4])),
                                Convert.ToInt32(data[5]), (EnumTypesOfTransformers)Convert.ToInt32(data[6])));
                            break;
                        case 4:
                            army.Add(new Human(data[0], new DateTime(Convert.ToInt32(data[1]), Convert.ToInt32(data[2]), Convert.ToInt32(data[3]))));
                            break;
                    }
                }
            }

            Console.WriteLine("-----------Print-------------");
            var doctor = new HumanStruct("joo", new DateTime(786, 5, 16), "doctor");
            var doctor1 = new HumanStruct("joo", new DateTime(786, 5, 16), "doctor1");
            doctor.Heal();
            doctor1.Heal();
            Console.WriteLine();

            Console.WriteLine("-----------Print-------------");
            army.Print();
            var armyController = new ArmyController();
            Console.WriteLine();

            Console.WriteLine("-----------ArmyCount-------------");
            armyController.ArmyCount(army);
            Console.WriteLine();

            Console.WriteLine("-----------FoundByDate-------------");
            armyController.FoundByDate(army, new DateTime(786, 5, 16));
            Console.WriteLine();

            Console.WriteLine("-----------FoundTransformerByPower-------------");
            armyController.FoundTransformerByPower(army, 3546);
            Console.WriteLine();
        
            Console.WriteLine("-----------JSON-------------");
            
            var output = JsonConvert.SerializeObject(army);
            Console.WriteLine(output);
            using (var writer = new StreamWriter("JSON.txt", false))
            {
                writer.Write(output);
            }
            
            string input;
            using (var reader = new StreamReader("JSON.txt"))
            {
                input = reader.ReadToEnd();
            }
            

            var deserializedArmy = JsonConvert.DeserializeObject<Army>(input);
            deserializedArmy.Print();
        }
    }
}
