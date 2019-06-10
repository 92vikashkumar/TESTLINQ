using System;
using System.Collections.Generic;
using System.Text;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace TESTLINQ
{
    public class Windsortest : IWindsortest2
    {
        public int ADD(int a, int b)
        {
            return a + b;
        }
    }

    public class Windsortest1: IWindsortest2
    {
        public int ADD(int x, int y)
        {

            return x + y;
        }
    }

    public interface IWindsortest2
    {
        int ADD(int a, int b);
    }

    public interface IWindsorTest
    {
        IList<string> getDetails();
    }

    public class WINTest : IWindsorTest
    {
        public IList<string> getDetails()
        {
            IList<string> vs = new List<string>();
            vs.Add("Vikash");
            vs.Add("Gaurav");
            return vs;
        }
    }
}
