namespace Lab01
{
    public class student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }

        public student(int id, string? name, int? age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }

    public class Program
    {
        public static void Main()
        {
            #region 1 task

            //bool trueOrFalse = true;
            //char symbol = 'a';
            //int num = 1;
            //float floatNumber = 5.6F;
            //double doubleNumber = 8.2;
            //string s = "dwa";
            //short shortNum = 412;

            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(symbol);
            //Console.WriteLine(num);
            //Console.WriteLine(floatNumber);
            //Console.WriteLine(s);
            //Console.WriteLine(shortNum);
            //Console.WriteLine(doubleNumber);

            ////неявное преобразование
            //long transformIntToLong = num;//1
            //double transformIntToDouble = num;//2
            //double transformFloatToDouble = floatNumber;//3
            //int transformShortToInt = shortNum;//4
            //double transformShortToDouble = shortNum;//5

            ////явное преобразование
            //short trasformIntToShort = (short)num;//1
            //int trasformFloatToInt = (int)floatNumber;//2
            //float trasformDoubleToFloat = (float)doubleNumber;//3
            //long trasformIntToLong = Convert.ToByte(num);//4
            //string s1 = "s";
            //char trasformStringToChar = Convert.ToChar(s1);//5

            ////boxing unboxing
            //int original = 5;
            //object boxing = original;
            //int unboxing = (int)boxing;
            //unboxing = 6;
            //Console.WriteLine();
            //Console.WriteLine(original);
            //Console.WriteLine(unboxing);

            ////неявно типизированная переменная
            //var varInt1 = 5;
            //var varInt2 = 6;
            //Console.WriteLine();
            //Console.WriteLine(varInt1 + varInt2);
            //string[][] a;
            
            ////Nullable
            //var students = new student[2];
            //students[0] = new student(1, "Vasya", null);
            //students[1] = new student(1, "Vasilisa", 45);

            ////work with var
            //var varIntType = 1214;
            ////varIntType = 213.5;

            #endregion

            #region 2 task

            ////string literals
            //string s1 = "abc";
            //string s2 = "abc";
            //string s3 = "ab";

            //Console.WriteLine(s1 == s2);
            //Console.WriteLine(s1 == s3);

            ////concat
            //string name = "Vasya";
            //string Surname = "Pupkin";
            //string people = string.Concat(name, " ", Surname);

            ////copy
            //string copyName = string.Copy(name);

            ////substring
            //string nameAfterSubstring = people
            //    .Substring(0,
            //        people.IndexOf(' '));

            ////split
            //var text = "dwad aw daw daw daw dawd fe fes ";
            //var words = text.Split(' ');

            ////insert
            //var secondPeople = people.Insert(people.IndexOf(' '), "12");

            ////remote
            //var onlysurname = secondPeople.Remove(0, secondPeople.IndexOf(' ') + 1);

            ////интрополирование
            //Console.WriteLine("{0} {1}", "dwad", "abc");

            ////null and Empty
            //string Empty = string.Empty;
            //string nullString = null;
            //Console.WriteLine();

            //if (string.IsNullOrWhiteSpace(Empty))
            //{
            //    Console.WriteLine("meow");
            //    Empty += "dwa";
            //}

            //if (string.IsNullOrEmpty(nullString))
            //{
            //    Console.WriteLine("meow2");
            //    nullString += "dwa";
            //}

            ////string builder
            //var stringbuilder = new StringBuilder("mes124sage");
            //stringbuilder.Remove(3, 3);
            //stringbuilder.Insert(0, "Vasya send ");
            //stringbuilder.Append(": hello world");
            //string messаge = stringbuilder.ToString();
            //Console.WriteLine(messаge);

            #endregion

            #region 3 task

            //var length = 5;
            //var width = 6;
            //var array = new int[length, width];
            //var strArray = new string?[length, width]; //string

            //for (var i = 0; i < length; i++)
            //{
            //    for (var j = 0; j < width; j++)
            //    {
            //        strArray[i, j] = $"{i + j}";
            //        array[i, j] = i + j;
            //        Console.Write("{0} ", array[i, j]);
            //    }

            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            ////string array
            //Console.Write("posI: ");
            //int posI = Convert.ToInt32(Console.ReadLine());
            //Console.Write("posJ: ");
            //int posJ = Convert.ToInt32(Console.ReadLine());
            //Console.Write("string on {0}x{1}:", posI, posJ);
            //strArray[posI, posJ] = Console.ReadLine();

            //Console.WriteLine("length strArray: {0}", strArray.Length);

            //for (var i = 0; i < length; i++)
            //{
            //    for (var j = 0; j < width; j++)
            //    {
            //        Console.Write("{0} ", strArray[i, j]);
            //    }

            //    Console.WriteLine();
            //}

            //var toothArray = new string[3][];

            //for (var i = 1; i < 4; i++)
            //{
            //    toothArray[i - 1] = new string[i];
            //}

            //for (var i = 0; i < 3; i++)
            //{
            //    for (var j = 0; j < toothArray[i].Length; j++)
            //    {
            //        Console.WriteLine("toothArray[{0}][{1}]: ", i, j);
            //        toothArray[i][j] = Console.ReadLine();
            //    }
            //}

            //Console.WriteLine();
            //for (var i = 0; i < 3; i++)
            //{
            //    for (var j = 0; j < toothArray[i].Length; j++)
            //    {
            //        Console.Write("{0} ", toothArray[i][j]);
            //    }

            //    Console.WriteLine();
            //}

            //var array1 = new object[0];
            //var str = "";
            #endregion

            #region 4 task
            //var tuple = (1, "02", '3', "04", (ulong)5);

            ////all
            //Console.WriteLine(tuple.Item1);
            //Console.WriteLine(tuple.Item2);
            //Console.WriteLine(tuple.Item3);
            //Console.WriteLine(tuple.Item4);
            //Console.WriteLine(tuple.Item5);

            ////1,3,5
            //Console.WriteLine();
            //Console.WriteLine(tuple.Item1);
            //Console.WriteLine(tuple.Item3);
            //Console.WriteLine(tuple.Item5);

            //int int1;
            //string string1, string2;
            //char char1;
            //ulong ulong1;
            //(_, string1, _, _, ulong1) = tuple;
            //(int1 , _, char1, string2, _) = tuple;

            //var tuple1 = (1, 2, 3, "131", '1');
            //var tuple2 = (1, 2, 3, "131", '1');

            //Console.WriteLine(tuple1 == tuple2);
            #endregion

            #region 5 task

            //(int, int, int, char) LocalFunction(int[] numbers, string str)
            //{
            //    var minNum = int.MaxValue;
            //    var maxNum = int.MinValue;
            //    var sumNums = 0;
            //    foreach (var num in numbers)
            //    {
            //        if (num < minNum)
            //        {
            //            minNum = num;
            //        }   

            //        if (num > maxNum)
            //        {
            //            maxNum = num;
            //        }

            //        sumNums += num;
            //    }

            //    return (maxNum, minNum, sumNums, str[0]);

            //}
            //var nums = new[] 
            //    { 34, 124, 12, 4, 24};
            //var str = "ohoh";
            //Console.WriteLine(LocalFunction(nums, str));
            #endregion

            #region 6 task

            //void LocalFunction1()
            //{
            //    unchecked
            //    {
            //        var maxValue = int.MaxValue;
            //        maxValue++;
            //        Console.WriteLine(maxValue);
            //    }
            //}

            //void LocalFunction2()
            //{
            //    checked
            //    {
            //        var maxValue = int.MaxValue;
            //        maxValue++;
            //        Console.WriteLine(maxValue);
            //    }

            //}

            //LocalFunction1();
            //LocalFunction2();
            #endregion
        }
    }
}