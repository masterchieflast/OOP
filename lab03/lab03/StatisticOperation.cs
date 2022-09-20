namespace lab03
{
    static class StatisticOperation
    {
        public static int Max(this MySet set)
        {
            return set._set.Select(item => item.Length).Max();
        }

        public static int Min(this MySet set)
        {
            return set._set.Select(item => item.Length).Min();
        }
        public static int Difference(this MySet set)
        {
            return Max(set) - Min(set);
        }

        public static int CountOfWords(this string str)
        {
            return str
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Length;
        }

        public static void AddComma(this MySet set)
        {
            var size = (int)set;
            var newSet = new HashSet<string>();

            for (var i = 0; i < size; i++)
            {
                var buf = set[i];
                newSet.Add(buf + ",");
            }

            set._set = newSet;
        }

        public static void Distinct(this MySet set)
        {
            set._set = set._set.Distinct().ToHashSet();
        }
    }
}
