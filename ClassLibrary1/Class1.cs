using System;

namespace TESTLINQ.ClassLibrary1
{
    public class Class1:IClass
    {
        public string name { get; set; }
        public Class1(string s)
        {
            name = s;
        }
        public decimal Multiply(decimal a,decimal b)
        {
            return a * b;
        }
    }

    public interface IClass
    {
        decimal Multiply(decimal a, decimal b);
    }

    public class BaseClass
    {
         protected internal int myValue = 0;
    }
    public class DerivedClass1 : BaseClass
    {
        void Access()
        {
            BaseClass baseObject = new BaseClass();

            // Error CS1540, because myValue can only be accessed by
            // classes derived from BaseClass.
            // baseObject.myValue = 5;  

            // OK, accessed through the current derived class instance
            myValue = 5;
        }
    }

}
