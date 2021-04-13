using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K, V>
    {
        K[] keysArray;
        V[] valuesArray;
        public MyDictionary()
        {
            keysArray = new K[0];
            valuesArray = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] tempKeys = keysArray;
            V[] tempValues = valuesArray;

            keysArray = new K[keysArray.Length + 1];
            valuesArray = new V[valuesArray.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keysArray[i] = tempKeys[i];
                valuesArray[i] = tempValues[i];
            }

            keysArray[keysArray.Length - 1] = key;
            valuesArray[valuesArray.Length - 1] = value;
        }

        public int LengthOfKeys
        {
            get { return keysArray.Length; }
        }
        public int LengthOfValues
        {
            get { return valuesArray.Length; }
        }
        public K[] keys
        {
            get { return keysArray; }
        }
        public V[] values
        {
            get { return valuesArray; }
        }

    }
}
