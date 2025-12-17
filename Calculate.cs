using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Hill_Adam
{
    /// <summary>
    /// Provides static methods for basic arithmetic calculations
    /// using both integers and floating-point numbers.
    /// </summary>
    internal class Calculate
    {
        /// <summary>
        /// Stores a shared calculation result.
        /// </summary>
        public static float result = 28.0f;

        /// <summary>
        /// Static constructor that initializes the result value.
        /// Runs once before the class is first used.
        /// </summary>
        static Calculate()
        {
            result = 21.0f;
        }

        // INTEGERS


        /// <summary>
        /// Adds two integers.
        /// </summary>
        public static int Add(int x, int y) 
        {
            return x + y;
        }
        /// <summary>
        /// Subtracts one integer from another.
        /// </summary>
        public static int sub(int x, int y) 
        {
            return x - y;
        }
        // <summary>
        /// Multiplies two integers.
        /// </summary>
        public static int mult(int x, int y) 
        {
            return x * y;
        }
        /// <summary>
        /// Divides one integer by another.
        /// </summary>
        public static int div(int x, int y) 
        {
            return x / y;
        }

        // FLOATING


        /// <summary>
        /// Adds two floating-point numbers.
        /// </summary>
        public static float Add(float x, float y)
        {
            return x + y;
        }
        /// <summary>
        /// Subtracts one floating-point number from another.
        /// </summary>
        public static float Sub(float x, float y)
        {
            return x - y;
        }
        /// <summary>
        /// Multiplies two floating-point numbers.
        /// </summary>
        public static float Mult(float x, float y)
        {
            return x * y;
        }
        /// <summary>
        /// Divides one floating-point number by another.
        /// </summary>
        public static float Div(float x, float y)
        {
            return x / y;
        }


    }
}
