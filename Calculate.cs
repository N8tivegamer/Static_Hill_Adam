using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Hill_Adam
{
    internal class Calculate
    {

        public static float result = 28.0f;


        static Calculate()
        {
            result = 21.0f;
        }

        // INTEGERS

        public static int Add(int x, int y) 
        {
            return x + y;
        }
        public static int sub(int x, int y) 
        {
            return x - y;
        }
        public static int mult(int x, int y) 
        {
            return x * y;
        }
        public static int div(int x, int y) 
        {
            return x / y;
        }

        // FLOATING


        public static float Add(float x, float y)
        {
            return x + y;
        }
        public static float sub(float x, float y)
        {
            return x - y;
        }
        public static float mult(float x, float y)
        {
            return x * y;
        }
        public static float div(float x, float y)
        {
            return x / y;
        }


    }
}
