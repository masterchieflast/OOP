using System.Security.Cryptography.X509Certificates;

namespace lab10
{
    public class People
    {
        public string Name;
        public string Profession;

        public People(string name, string profession)
        {
            Name = name;
            Profession = profession;
        }

        public override string ToString()
        {
            return $"name: {Name}\tjob: {Profession}\n";
        }
    }
}
