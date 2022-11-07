﻿namespace OOP.AbstractClassAndMethods
{
    public class MinHeap : Heap
    {
        public override int Extract()
        {
            var item = _list.Min;
            _list.Remove(item);
            return item;
        }
    }
}
