using laba07;
namespace lab07
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                var mySet = new MySet<string>("test");
                Console.WriteLine(mySet[0]);

                var setTransformer = new MySet<Transformer>(
                    new Transformer(123, "Optimus",
                        new DateTime(2022, 10, 3), 432));
                
                var transformer = new Transformer(523, "Bambulbi",
                    new DateTime(2022, 10, 3, 12, 13 , 13), 4412);
                setTransformer.Add(transformer);
                
                Console.WriteLine("\nbefore delete show\n");
                setTransformer.Show();
                Console.WriteLine("\nafter delete show\n");
                setTransformer.Delete(transformer);
                setTransformer.Show();

                MySet<Transformer>.WriteToFile(ref setTransformer);

                Console.WriteLine("from file");
                MySet<Transformer>.ReadFromFile();

                Console.WriteLine(mySet[-1]);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("end try-catch-finally");
            }
        }
    }
}