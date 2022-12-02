using System.Drawing;

namespace lab11
{
    public class Program
    {
        public static void Main()
        {
            Reflector.OutAssemblyName("Test");
            Reflector.OutPublicConstructors("Test");
            Reflector.OutPublicMethods("Test");
            Reflector.MethodForType("Test");
            Reflector.OutInterfaces("Test");
            Reflector.OutMethodsWithParm("Test", "String");
            Reflector.Voke("lab11.Test", "ToConsole");

            object[] ls = { "masterchieflast" };
            var ts1 = Reflector.Create("Test", ls);

            Reflector.file.Close();
        }
    }
}