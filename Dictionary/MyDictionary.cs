using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TK,TV>
    {
        TK[] dictionaryListKey;
        TV[] dictionaryListValue;

        public MyDictionary()
        {
            dictionaryListKey = new TK[0];
            dictionaryListValue = new TV[0];
        }
        public void Add(TK key,TV value)
        {
            TK[] tempListKey = dictionaryListKey;
            TV[] tempListValue = dictionaryListValue;
            dictionaryListKey = new TK[dictionaryListKey.Length + 1];
            dictionaryListValue = new TV[dictionaryListValue.Length + 1];
            for (int i = 0; i < tempListKey.Length; i++)
            {
                dictionaryListKey[i] = tempListKey[i];
                dictionaryListValue[i] = tempListValue[i];
            }
            dictionaryListKey[dictionaryListKey.Length - 1] = key;
            dictionaryListValue[dictionaryListValue.Length - 1] = value;
        }
       
        public int Count 
        {
            get { return dictionaryListKey.Length; }
        }
    }
}
