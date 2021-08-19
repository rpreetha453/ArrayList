using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encap
{
    public class ArrayList
    {
        int[] _data;
        int _current = 0;
        int _Count;

        public int Count
        {
            get { return _current ; }
           }
        int _Capacity;

        public int Capacity
        {
            get { return _data.Length; }
           }
        bool _IsEmpty=true;

        public bool IsEmpty1
        {
            get {
                if (_Count > 0)
                {
                    _IsEmpty = false;
                }
                return _IsEmpty; }
           }

        public ArrayList(int size=2)
        {
            _data = new int[size];
        }
        public int Get(int index)
        {
            return _data[index];
        }
        public int Set(int index, int value)
        {
            return _data[index] = value;
        }
        public void Insert(int index, int value)
        {
            if (_Count + 1 == _Capacity)
            {
                Resize();
            }
            for (int i = index, j = index + 1; i <_Capacity; i++, j++)
            {
                _data[i] = value;
            }
            _data[index] = value;
            _current++;
        }
        public void Delete(int index, int value)
        {
            for (int i = index; i <=_Capacity; i++)
            {
                _data[i] = _data[i + 1];
             }
            _current--;
            
        }
       
        public void Add(int value)
        {
            _data[_current] = value;
            _current++;
        }
        public bool Contains(int value)
        {
            for (int i = 0; i < _data.Length; i++)
            {
                if (_data[i] == value)
                {
                    return true;
                }
            }
                return false;
        }

        private void Resize()
        {
            int []_arr=new int[_data.Length*2];
            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] =_data[i];
            }
            _data = _arr;
            }

        public void print()
        {
            for (int i = 0; i < _current; i++)
            {
                Console.Write(_data[i]+" ");
            }
        }


       }
}
