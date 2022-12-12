using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab13
{
    public static class CustomSerializer
    {
        public static void Serialize(string file, Human car)
        {
            string format = file.Split('.').Last();
            switch (format)
            {
                case "bin":
                    BinaryFormatter bf = new BinaryFormatter();
                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        bf.Serialize(fs, car);
                    }

                    break;

                case "soap":
                    SoapFormatter sf = new SoapFormatter();
                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        sf.Serialize(fs, car);
                    }

                    break;

                case "xml":
                    XmlSerializer xs = new XmlSerializer(typeof(Human));
                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        xs.Serialize(fs, car);
                    }

                    break;

                case "json":
                    DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Human));
                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        js.WriteObject(fs, car);
                    }

                    break;
            }
        }

        public static void Deserialize(string file)
        {
            string format = file.Split('.').Last();
            switch (format)
            {
                case "bin":
                    BinaryFormatter bf = new BinaryFormatter();
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    {
                        Human car = (Human)bf.Deserialize(fs);
                        Console.WriteLine($"Deserialized comp: {car.Brand} {car.Model}");
                    }

                    break;

                case "soap":
                    SoapFormatter sf = new SoapFormatter();
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    {
                        Human car = (Human)sf.Deserialize(fs);
                        Console.WriteLine($"Deserialized comp: {car.Brand} {car.Model}");
                    }

                    break;

                case "xml":
                    XmlSerializer xs = new XmlSerializer(typeof(Human));
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    {
                        Human car = (Human)xs.Deserialize(fs);
                        Console.WriteLine($"Deserialized comp: {car.Brand} {car.Model}");
                    }

                    break;

                case "json":
                    DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Human));
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    {
                        Human car = (Human)js.ReadObject(fs);
                        Console.WriteLine($"Deserialized comp: {car.Brand} {car.Model}");
                    }

                    break;
            }
        }
    }
}
