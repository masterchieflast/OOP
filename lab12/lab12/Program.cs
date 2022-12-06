namespace lab12
{
    public class Program
    {
        public static void Main()
        {
            DDDDiskInfo.GetFreeDrivesSpace();

            DDDFileInfo.GetFileInfo(@"D:\study\sem3\OOP\lab12\dddlog.txt");
            
            DDDDirInfo.GetDirInfo(@"D:\study\sem3\OOP\lab12\");
            
            DDDFileManager.GetAllDirsAndFilesOfDisk(@"D:\");
            
            DDDFileManager.GetAllFilesWithExtension(@"D:\study\sem3\ksis\ksis", ".txt");
            
            DDDFileManager.CreateZip(@"D:\study\sem3\OOP\lab12\DDDInspect\DDDFiles");
            
            DDDLog.SearchByDate(DateTime.Now);
        }
    }
}