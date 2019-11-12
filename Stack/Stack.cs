using System;
using System.Collections.Generic;
using System.Text;
using static Stack.CustomException;

namespace Stack
{
   public  class Stack<T>
    {
        #region Members
        private readonly T[]  stackArray;
        private readonly  int maximumLength;
        #endregion

        #region Properties
        public int Size { get; private set; }
        #endregion

        #region Constuctor
        public Stack(int length)
        {
            maximumLength = length;
            stackArray = new T[length];
        }
        #endregion

        public void Push(T value)
        {
            if(Size == maximumLength)
                throw new ExceededSizeException();

            stackArray[Size++] = value;
        }
        public T Pop()
        {
            if (Size == 0)
                throw new ExpenditureProhibitedException();

            return stackArray[--Size];
        }
        public T Peek()
        {
            if (Size == 0)
                throw new ExpenditureProhibitedException();
            return stackArray[Size - 1];
        }
    }
}
