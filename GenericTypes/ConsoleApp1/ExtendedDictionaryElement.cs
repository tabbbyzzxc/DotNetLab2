﻿namespace ConsoleApp1
{
    public class ExtendedDictionaryElement<T, U, V>
    {
        public T TKeyValue { get; }
        public U UValue { get; }
        public V VValue { get; }

        public ExtendedDictionaryElement(T TKeyValue, U UValue, V VValue)
        {
            this.TKeyValue = TKeyValue;
            this.UValue = UValue;
            this.VValue = VValue;
        }
    }
}
