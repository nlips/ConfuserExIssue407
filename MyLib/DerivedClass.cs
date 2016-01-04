using System;

namespace MyLib
{
    sealed class DerivedClass<T> : BaseAbstractClass<T>
    {
        protected override void ProtectedAbstractMethod()
        {
            throw new NotImplementedException();
        }
    }
}
