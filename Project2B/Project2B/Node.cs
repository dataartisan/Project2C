using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2B
{
    
    public class Node<T>
    {

        
        private T _data;
        private Directions _dir;

        public Node() {}
        public Node(T _data, Directions direct)
        {
            this._data = _data;
            this._dir = direct;


        }

        public Directions Dir
        {
            get { return _dir; }
        }

        public T Value
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }

    }
}

