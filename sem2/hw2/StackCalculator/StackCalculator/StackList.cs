﻿using System;

namespace StackCalculator
{
    class StackList : IStack
    {
        private class StackElement
        {
            public int Value { get; set; }
            public StackElement Next { get; set; }

            public StackElement(int newValue, StackElement newNext)
            {
                Value = newValue;
                Next = newNext;
            }
        }

        private StackElement head;

        public void Push(int value)
        {
            head = new StackElement(value, head);
        }

        public bool IsEmpty() => head == null;

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Removing from the empty stack");
            }

            var temp = Peek();
            head = head.Next;
            return temp;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Peek from the empty stack");
            }

            return head.Value;
        }
    }
}
