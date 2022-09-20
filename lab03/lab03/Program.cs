namespace lab03
{
    public class Program
    {
        public static void Main()
        {
            var set1 = new MySet("1");
            set1.DeveloperInitialization("Pavel", 43, "IT");

            var set2 = new MySet("a");
            set2.ProductionInitialization(52, "Apple");
            set2 += "b";
            set2 += "c";

            var set3 = new MySet("001");
            set3 += "002";
            set3 += "003";
            set3 += "003";
            set3 += "005";
            set3 += "005";

            var set4 = new MySet("a");
            set4 += "ab";
            set4 += "abcd";
            set4 += "abc";

            Console.WriteLine("-------------Developer and Production---------------");
            Console.WriteLine("Developer( name: {0}, id: {1}, department: {2})",
                set1.developer.Name, set1.developer.Id, set1.developer.Department);
            Console.WriteLine("Production( id: {0}, organization: {1})",
                set2.production.Id, set2.production.Organization);
            Console.WriteLine();

            Console.WriteLine("---------------get and set (indexer)----------------");
            set3.Print();
            Console.WriteLine("index value to print: ");
            var index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(set3[index]);

            Console.WriteLine("index value to refactor: ");
            index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("new value to set3[{0}]: ", index);
            set3[index] = Console.ReadLine();
            set3.Print();
            Console.WriteLine();

            Console.WriteLine("-----------------------AddComma---------------------");
            Console.WriteLine("before update");
            set2.Print();
            set2.AddComma();
            Console.WriteLine("after update");
            set2.Print();
            Console.WriteLine();

            Console.WriteLine("-----------------------Distinct???------------------");
            Console.WriteLine("before update");
            set3.Print();
            set3.Distinct();
            Console.WriteLine("after update");
            set3.Print();
            Console.WriteLine();

            Console.WriteLine("-----------------------max and min(LEN)-------------");
            set4.Print();
            Console.WriteLine("max: {0} --- min: {1}", set4.Max(), set4.Min());
            Console.WriteLine();

            Console.WriteLine("-----------------------difference-------------------");
            set4.Print();
            Console.WriteLine("Difference: {0}", set4.Difference());

            Console.WriteLine("---------------------Count Of Words-----------------");
            var str = "1 2 3 44 5 6 7 8 9";
            Console.WriteLine("Count Of Words: {0}", str.CountOfWords());

            Console.WriteLine("------------------------operators-------------------");
            Console.WriteLine("set2: ");
            set2.Print();
            Console.WriteLine();
            Console.WriteLine("old set3: ");
            set3.Print();
            Console.WriteLine();
            Console.WriteLine("\t\tset + set");
            set3 += set2;

            Console.WriteLine("new set3: ");
            set3.Print();

            Console.WriteLine("\t\tset * set");
            set3 *= set2;
            set3.Print(); 

            Console.WriteLine("\t\t(int)set");
            Console.WriteLine((int)set3);

            Console.WriteLine("\t\ttrue and false");
            Console.WriteLine(set1 ? "true" : "false");
            set3 += "x";
            set3 += "y";
            set3 += "z";
            Console.WriteLine(set3 ? "true" : "false");

        }
    }
}