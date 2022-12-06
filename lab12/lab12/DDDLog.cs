namespace lab12
{
    public class DDDLog
    {
        public static StreamWriter? Logfile;
        public static void WriteToLog(string action, string fileName = "", string path = "")
        {
            using (Logfile = new StreamWriter(@"D:\study\sem3\OOP\lab12\dddlog.txt", true))
            {
                var time = DateTime.Now;
                Logfile.WriteLine("********************************\n");
                Logfile.WriteLine($"Action: {action}");

                if (fileName.Length != 0)
                    Logfile.WriteLine($"File Name: {fileName}");

                if (path.Length != 0)
                    Logfile.WriteLine($"Path: {path}");

                Logfile.WriteLine($"Date/Time: {time.ToLocalTime()}\n");
            }
        }

        public static void SearchByDate(DateTime date)
        {
            using (var reader = new StringReader(File.ReadAllText(@"D:\study\sem3\OOP\lab12\dddlog.txt")))
            {
                var lines = reader.ReadToEnd().Split("********************************\n");
                foreach (var line in lines)
                {
                    if (line.Contains(date.ToString()))
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
