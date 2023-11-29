namespace ConsoleApp1
{
    public static class ArrayExtensions
    {
        public static int CountOccurrences<T>(this T[] array, T value) where T : IEquatable<T>
        {
            return array.Count(x => x.Equals(value));
        }

        public static T[] Unify<T>(this T[] array) where T : IEquatable<T>
        {
            List<T> unifiedList = new();
            foreach (var item in array)
            {
                if (!unifiedList.Contains(item))
                {
                    unifiedList.Add(item);
                }
            }

            return unifiedList.ToArray();
        }
    }
}
