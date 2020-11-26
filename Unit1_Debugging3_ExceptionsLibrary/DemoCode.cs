using System;
using System.Collections.Generic;
using System.Text;

namespace Unit1_Debugging3_ExceptionsLibrary
{
    public class DemoCode
    {
        public int GrandparentMethod(int position)
        {
            int output = 0;

            Console.WriteLine("Open Database Connection");

            try
            {
                output = ParentMethod(position);
                if(position < 0)
                {
                    throw new IndexOutOfRangeException("The Value must be >= 0");
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("You passed in bad data", ex);
            }
            finally
            {
                Console.WriteLine("Close Database Connection");
            }
            return output;
        }

        public int ParentMethod(int position)
        {
            return GetNumber(position);
        }

        public int GetNumber(int position)
        {
            int output = 0;
            int[] numbers = new int[] { 1, 4, 7, 2 };
            output = numbers[position];

            return output;
        }
    }
}
