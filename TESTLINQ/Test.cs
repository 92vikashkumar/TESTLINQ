using System;
using System.Collections.Generic;
using System.Text;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace TESTLINQ
{
    public interface ITest
    {
        bool validateint(int i);
        bool validateString(string abc);
    }
    public class Test : ITest
    {
        public bool validateint(int i)
        {
            return true;
        }
        public bool validateString(string abc)
        {
            return true;
        }
    }

   
    public class xyz
    {
        public ITest test;
        public xyz(ITest _test)
        {
            test = _test;
        }
        public void ValidateAll()
        {
            int i = 0;
            string abc = "";
            bool x = test.validateint(i);
            bool Y = test.validateString(abc);
            Console.WriteLine("Constructor injection");
            Console.WriteLine(x + "-" + Y);
        }


    }

}
