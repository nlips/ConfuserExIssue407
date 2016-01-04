using System;

namespace MyLib
{
    static public class Library
    {
        static public void Test()
        {
            var a = new DerivedClass<string>();
            a.PublicAbstractMethod();
        }
    }
}
