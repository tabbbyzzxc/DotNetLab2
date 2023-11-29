using System.Data;

namespace ConsoleApp1
{

    public class ExtendedDictionary<T, U, V>
    {
        private Dictionary<T, (U, V)> _holder = new();

        public int Count => _holder.Count();

        public void Add(T TKey, U UValue, V VValue)
        {
            _holder.Add(TKey, (UValue, VValue));
        }
        
        public bool RemoveByKey(T TKeyValue)
        {
            return _holder.Remove(TKeyValue);
        }

        public  bool ExistsWithKey(T TKeyValue)
        {
            return _holder.ContainsKey(TKeyValue);
        }

        public bool ExistsWithValue(U UValue, V VValue)
        {
            return _holder.ContainsValue((UValue, VValue));
        }

        public (U UValue, V VValue) this[T TKeyValue]
        {
            get
            {
                if(_holder.TryGetValue(TKeyValue, out var UVValues))
                {
                    return UVValues;
                }
                else
                {
                    throw new KeyNotFoundException($"Key {TKeyValue} does not exist in this dictionary");
                }
            }
        }

        public IEnumerable<ExtendedDictionaryElement<T, U, V>> Elements
        {
            get
            {
                return _holder.Select(x => new ExtendedDictionaryElement<T, U, V>(x.Key, x.Value.Item1, x.Value.Item2));
            }
        }

    }
}
