using System;

namespace Day7Arrays.Helper
{
    public class ArrayReverser
    {
        public static void DoReversal<T>(T[] theArray)
        {
            T tempHolder = default(T);

            if (theArray.Length > 0)
            {
                for (int counter = 0; counter < (theArray.Length / 2); counter++)
                {
                    tempHolder = theArray[counter];
                    theArray[counter] = theArray[theArray.Length - counter - 1];
                    theArray[theArray.Length - counter - 1] = tempHolder;
                }
            }
            else
            {
                throw new ArgumentNullException("This is nothing that can be reversed: " + nameof(theArray));
            }
        }
    }
}