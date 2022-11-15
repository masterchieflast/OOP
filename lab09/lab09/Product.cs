using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09
{
    public class Product : IOrderedDictionary
    {
        private ArrayList _product;

        public Product()
        {
            _product = new ArrayList();
        }

        public int IndexOfKey(object key)
        {
            for (var i = 0; i < _product.Count; i++)
            {
                if (((DictionaryEntry)_product[i]!).Key == key)
                    return i;
            }

            // key not found, return -1.
            return -1;
        }

        public object this[object key]
        {
            get => ((DictionaryEntry)_product[IndexOfKey(key)]).Value;
            set => _product[IndexOfKey(key)] = new DictionaryEntry(key, value);
        }

        // IOrderedDictionary Members
        public IDictionaryEnumerator GetEnumerator()
        {
            return new PeopleEnum(_product);
        }

        public void Insert(int index, object key, object value)
        {
            if (IndexOfKey(key) != -1)
            {
                throw new ArgumentException("An element with the same key already exists in the collection.");
            }
            
            _product.Insert(index, new DictionaryEntry(key, value));
        }

        public void RemoveAt(int index)
        {
            _product.RemoveAt(index);
        }

        public object this[int index]
        {
            get => ((DictionaryEntry)_product[index]).Value;
            set
            {
                var key = ((DictionaryEntry)_product[index]).Key;
                _product[index] = new DictionaryEntry(key, value);
            }
        }
        // IDictionary Members

        public void Add(object key, object value)
        {
            if (IndexOfKey(key) != -1)
            {
                throw new ArgumentException("An element with the same key already exists in the collection.");
            }
            _product.Add(new DictionaryEntry(key, value));
        }

        public void Clear()
        {
            _product.Clear();
        }

        public bool Contains(object key)
        {
            return IndexOfKey(key) != -1;
        }

        public bool IsFixedSize => false;

        public bool IsReadOnly => false;

        public ICollection Keys
        {
            get
            {
                var KeyCollection = new ArrayList(_product.Count);
                foreach (var t in _product)
                {
                    KeyCollection.Add(((DictionaryEntry)t).Key);
                }
                
                return KeyCollection;
            }
        }

        public void Remove(object key)
        {
            _product.RemoveAt(IndexOfKey(key));
        }

        public ICollection Values
        {
            get
            {
                var ValueCollection = new ArrayList(_product.Count);
                foreach (var t in _product)
                {
                    ValueCollection.Add(((DictionaryEntry)t).Value);
                }
                
                return ValueCollection;
            }
        }

        // ICollection Members

        public void CopyTo(Array array, int index)
        {
            _product.CopyTo(array, index);
        }

        public int Count => _product.Count;

        public bool IsSynchronized => _product.IsSynchronized;

        public object SyncRoot => _product.SyncRoot;

        // IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PeopleEnum(_product);
        }
    }

    public class PeopleEnum : IDictionaryEnumerator
    {
        public ArrayList _people;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        private int position = -1;

        public PeopleEnum(ArrayList list)
        {
            _people = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _people.Count);
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public DictionaryEntry Entry => (DictionaryEntry)Current;

        public object Key
        {
            get
            {
                try
                {
                    return ((DictionaryEntry)_people[position]).Key;
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public object Value
        {
            get
            {
                try
                {
                    return ((DictionaryEntry)_people[position]).Value;
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
