using System;
using System.Collections.Generic;
using System.Linq;

namespace stos
{
    public class Stack
    {
        private readonly List<object> _list = new List<object>();
        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Parameter cannot be null");
            }
            else
            {
                _list.Add(obj);
            }
            
        }

        public object Pop()
        {            
                var quantity = _list.Count();
                if ( quantity == 0)
                {
                    throw new InvalidOperationException("Stack is empty");
                }
                else
                {
                    var last = _list[quantity - 1];
                    _list.RemoveAt(quantity - 1);
                    return last;
                }             
                        
        }
        public void Clear()
        {
            _list.Clear();
        }

    }
}
