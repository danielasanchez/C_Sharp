using System;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = null;

            if (original == null) 
            { 
                throw new System.ArgumentException("Esta variable no puede ser nula", "original"); 
            }

        }
    }
}
