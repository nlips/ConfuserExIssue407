namespace MyLib
{
    abstract class BaseAbstractClass<T> : OtherNamespace.AncestorAbstractClass
    {
        public override void PublicAbstractMethod()
        {
            ProtectedAbstractMethod();
        }

        abstract protected void ProtectedAbstractMethod();
    }
}
