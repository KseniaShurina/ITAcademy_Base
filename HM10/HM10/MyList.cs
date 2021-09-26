using System.Collections;
using System.Collections.Generic;

namespace HM10
{
    public class MyList : IList<MyItem>
    {
        private readonly List<MyItem> _data = new List<MyItem>();

        public IEnumerator<MyItem> GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(MyItem item)
        {
            _data.Add(item);
        }

        public void Clear()
        {
            _data.Clear();
        }

        public bool Contains(MyItem item)
        {
            return _data.Contains(item);
        }

        public void CopyTo(MyItem[] array, int arrayIndex)
        {
            _data.CopyTo(array, arrayIndex);
        }

        public bool Remove(MyItem item)
        {
            return _data.Remove(item);
        }

        public int Count => _data.Count;
        public bool IsReadOnly => false;
        public int IndexOf(MyItem item)
        {
            return _data.IndexOf(item);
        }

        public void Insert(int index, MyItem item)
        {
            _data.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _data.RemoveAt(index);
        }

        public MyItem this[int index]
        {
            get => _data[index];
            set => _data[index] = value;
        }
    }
}
