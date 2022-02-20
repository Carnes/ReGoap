using System.Collections.Generic;

namespace ReGoap.Utilities
{
    public static class DictionaryExtensions // https://stackoverflow.com/questions/1343704/casting-c-sharp-out-parameters
    {
        public static bool TryGetValueAs<Key, Value, ValueAs>(this IDictionary<Key, Value> dictionary, Key key, out ValueAs valueAs) where ValueAs : Value
        {
            if(dictionary.TryGetValue(key, out Value value))
            {
                valueAs = (ValueAs)value;
                return true;
            }

            valueAs = default;
            return false;
        }
    }	
}