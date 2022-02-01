using System;

namespace encapsulation
{
    // C# program to illustrate encapsulation

    public class BaseClass
    {
        protected internal int myValue = 0;
    }


    class DerivedClass : BaseClass
    {
        static void Main()
        {

            var derivedObject = new DerivedClass();

            // Error CS1540, because myValue can only be accessed by
            // classes derived from BaseClass.
            // baseObject.myValue = 10;
            Console.WriteLine("priti");
            // OK, because this class derives from BaseClass.
            derivedObject.myValue = 10;
        }
    }
}
