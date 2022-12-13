using System.Runtime.Serialization;

namespace lab13
{
    [Serializable]
    public abstract class IntelligentBeing
    {
        [DataMember]
        public string Name;

        protected IntelligentBeing(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }
        [DataMember]
        public readonly DateTime Birthday;
        public TimeSpan Age => DateTime.Now.Subtract(Birthday) / 365;


        public override string ToString()
        {
            return $"this creature:{Name}\t live:{Age} year";
        }
    }
}
