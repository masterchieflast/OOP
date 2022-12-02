using System.Reflection;

namespace lab11
{
    public static class Reflector
    {
        private const string FilePath = "D:\\study\\OOP\\lab11\\file.txt";
        private const string FilePathR = "D:\\study\\OOP\\lab11\\fileR.txt";
        public static StreamWriter file = new(FilePath, false);
        static StreamReader fileR = new(FilePathR);

        public static void OutAssemblyName(string name)
        {
            file.WriteLine("======================================================1");
            var TypeName = "lab11." + name;
            var myType = Type.GetType(TypeName, false, true);
            file.WriteLine($"{TypeName}.Assembly = {myType.Assembly}");
            file.WriteLine("======================================================1\n");
        }

        public static void OutPublicConstructors(string name)
        {
            file.WriteLine("======================================================2");
            var TypeName = "lab11." + name;
            var myType = Type.GetType(TypeName, false, true);

            foreach (var contractor in myType.GetConstructors())
            {
                if (contractor.IsPublic)
                {
                    file.Write(contractor.Name + '(');
                    var parameters = contractor.GetParameters();
                    for (var i = 0; i < parameters.Length; i++)
                    {
                        file.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                        if (i + 1 < parameters.Length) file.Write(", ");
                    }
                    file.WriteLine(");");
                }
            }
            file.WriteLine("======================================================2\n");
        }

        public static void OutPublicMethods(string name)
        {
            file.WriteLine("======================================================3");
            var TypeName = "lab11." + name;
            var myType = Type.GetType(TypeName, false, true);

            foreach (var mi in myType.GetMethods())
            {
                if (mi.IsPublic)
                {
                    file.Write(mi.Name + '(');
                    var parameters = mi.GetParameters();
                    for (var i = 0; i < parameters.Length; i++)
                    {
                        file.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                        if (i + 1 < parameters.Length) file.Write(", ");
                    }
                    file.WriteLine(");");
                }
            }
            file.WriteLine("======================================================3\n");
        }

        public static void MethodForType(string name)
        {
            file.WriteLine("======================================================4");
            var TypeName = "lab11." + name;
            var myType = Type.GetType(TypeName, false, true);

            foreach (var fi in myType.GetFields())
            {
                file.WriteLine(fi.DeclaringType + " " + fi.FieldType + " " + fi.Name);
            }

            foreach (var pi in myType.GetProperties())
            {
                file.WriteLine(pi.DeclaringType + " " + pi.PropertyType + " " + pi.Name);
            }
            file.WriteLine("======================================================4\n");

        }
        public static void OutInterfaces(string name)
        {
            file.WriteLine("======================================================5");
            var TypeName = "lab11." + name;
            var myType = Type.GetType(TypeName, false, true);

            foreach (var i in myType.GetInterfaces())
            {
                file.WriteLine("interface " + i.Name);
            }
            file.WriteLine("======================================================5\n");
        }
        public static void OutMethodsWithParm(string name, string parm)
        {
            file.WriteLine("======================================================6");
            var TypeName = "lab11." + name;
            var myType = Type.GetType(TypeName, false, true);

            foreach (var mi in myType.GetMethods())
            {
                var param = mi.GetParameters();
                if (param.Any(t => parm == t.ParameterType.Name))
                {
                    file.Write(mi.Name + '(');
                    var parameters = mi.GetParameters();
                    for (var i = 0; i < parameters.Length; i++)
                    {
                        file.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                        if (i + 1 < parameters.Length) file.Write(", ");
                    }
                    file.WriteLine(");");
                }
            }
            file.WriteLine("======================================================6\n");
        }
        public static void Voke(string name, string method)
        {
            Console.WriteLine("======================================================7");
            var ls = new List<string>
            {
                fileR.ReadLine(),
                fileR.ReadLine(),
                fileR.ReadLine()
            };
            var parms = new object[] { ls };
            var type = Type.GetType(name);
            var obj = Activator.CreateInstance(type);
            var methodInfo = type.GetMethod(method);
            var result = methodInfo.Invoke(obj, parms);
            Console.WriteLine(result);
            Console.WriteLine("======================================================7\n");
        }

        public static object Create(string name, object[] parm)
        {
            Console.WriteLine("======================================================8");
            var TypeName = "lab11." + name;
            var myType = Type.GetType(TypeName, false, true);
            var obj = Activator.CreateInstance(myType, parm);
            Console.WriteLine(obj.ToString());
            Console.WriteLine("======================================================8\n");
            return obj;
        }
    }
}
