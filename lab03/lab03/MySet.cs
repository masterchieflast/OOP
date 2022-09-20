namespace lab03
{
    public class MySet
    {
        public HashSet<string> _set;
        private const int MaxLen = 5;
        public Developer? developer;
        public Production? production;

        public MySet(string value)
        {
            _set = new HashSet<string> { value };
        }

        public void DeveloperInitialization(string name, int id, string department)
        {
            developer = new Developer(name, id, department);
        }

        public void ProductionInitialization(int id, string organization)
        {
            production = new Production(id, organization);
        }

        public class Production
        {
            public int Id;
            public string Organization;

            public Production(int id, string organization)
            {
                Id = id;
                Organization = organization;
            }
        }
        public class Developer
        {
            public string Name;
            public int Id;
            public string Department;

            public Developer(string name, int id, string department)
            {
                Name = name;
                Id = id;
                Department = department;
            }
        }

        public string this[int index]
        {
            get
            {
                if (index > (int)this - 1)
                    throw new ArgumentOutOfRangeException();

                var size = 0;
                foreach (var item in _set)
                {
                    if (size == index)
                        return item;
                    size++;
                }

                return "";
            }
            set
            {
                if (index > (int)this - 1)
                    throw new ArgumentOutOfRangeException();

                var set = new HashSet<string>();
                var size = 0;

                foreach (var item in _set)
                {
                    set.Add(size == index ? value : item);
                    size++;
                }

                _set = set;
            }
        }

        public void Print()
        {
            foreach (var str in _set)
            {
                Console.WriteLine("value: {0}", str);
            }
        }

        #region operators
        public static MySet operator +(MySet set, string item)
        {
            set._set.Add(item);
            return set;
        }

        public static MySet operator +(MySet set, MySet set2)
        {
            foreach (var e in set2._set)
            {
                set += e;
            }

            return set;
        }

        public static MySet operator *(MySet set, MySet set2)
        {
            set._set.IntersectWith(set2._set);
            return set;
        }

        public static explicit operator int(MySet set)
        {
            return set._set.Count;
        }


        public static bool operator false(MySet set)
        {
            return (int)set > MaxLen;
        }

        public static bool operator true(MySet set)
        {
            return (int)set <= MaxLen;
        }
        #endregion
    }
}
