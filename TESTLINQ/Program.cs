using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TESTLINQ.ClassLibrary1;


namespace TESTLINQ
{
   
    class Program
    {
        static void Main(string[] args)
        {
            IList<abc> abcs = new List<abc>() {
            new abc(){ A="10",B="a1",C="100"},
            new abc(){ A="11",B="",C="110"},
            new abc(){ A="12",B=null,C="120"},
            new abc(){ A="13",B="b1",C="130"},
            new abc(){ A="14",B="c1",C="140"},
            new abc(){ A="Z",B="X",C="V"},
            new abc(){ A="15",B="d1",C="150"}
            };

            IList<abc> list1 = new List<abc>() {
            new abc(){ A="16",B="a1",C="100"},
            new abc(){ A="17",B=null,C="110"},
            new abc(){ A="12",B="",C="120"},
            new abc(){ A="18",B="b1",C="130"},
            new abc(){ A="19",B="c1",C="140"},
            new abc(){ A="20",B="X",C="V"},
            new abc(){ A="15",B="d1",C="150"}
            };

            var objabc1 = abcs.Where(x => !string.IsNullOrEmpty(x.B));
            Console.WriteLine("B is null or empty:");
            foreach (var x in objabc1)
                Console.WriteLine(x.A + "-" + x.B + "-" + x.C);

            var objabc3 = abcs.FirstOrDefault(x => x.A == "13" && x.C == "130").C;
            Console.WriteLine("Use of Where Condition:");
            Console.WriteLine(objabc3);

            var result = abcs.SkipWhile(x => x.A != "Z")
                .Skip(1)
                .FirstOrDefault();
            Console.WriteLine("Use of skip:");
            Console.WriteLine(result.A + "-" + result.B + "-" + result.C);

            var result1 = abcs.Where(x => !string.IsNullOrEmpty(x.B)).TakeWhile(x => x.A != "Z")
            .Take(3);
            var result2 = abcs.SkipWhile(x => x.A != "Z")
            .Skip(1);
            var sum = result1.Concat(result2).Sum(x => Convert.ToInt32(x.C));
            Console.WriteLine("Sum of Column C:");
            Console.WriteLine(sum);

            var Group = abcs.GroupJoin(list1, x => x.A, A => A.A, (x, list) => new { gp = list, rs1 = x.A, rs2 = x.B, rs3 = x.C })
                .Where(x => !string.IsNullOrEmpty(x.rs2));
            foreach (var item in Group)
            {
                Console.WriteLine(item.rs1);
                foreach (var items in item.gp)
                    Console.WriteLine(items);
            }

            //var (a, s) = AddAndSub(100, 200);

            string x1 = "India";

            //int z = 0, z1 = 0, z2 = 0;
            int a1 = 10, c1 = 50, n1 = 0, n2 = 0;

            //if (x == "India")
            //{
            //    z = a1 + c1;
            //    z1 = a1 + n1;
            //    z2 = a1 + n2;
            //}
            //else
            //{
            //    z = a1 * c1;
            //}

            var (x11, x2, x3) = x1 == "India"
                ? ((a1 + c1), (a1 + n1), (a1 + n2))
                : ((a1 * c1), 0, 0);
            Console.WriteLine("Question 5 Answer below:");
            Console.WriteLine(x11);

            //abc anotherExample = new abc();
            //anotherExample.ExampleMethod(1, optionalint: 5);


            ITest test = new Test();
            xyz xyx = new xyz(test);
            xyx.ValidateAll();

            var X = new Castle.Windsor.WindsorContainer();//Create Container 
            X.Register(Component.For<IWindsorTest>().ImplementedBy<WINTest>()); //register the Interface and Class in which interface extended
            var res = X.Resolve<IWindsorTest>(); // resolve the Interface.
            res.getDetails();
            foreach (var n in res.getDetails())
                Console.WriteLine("One interface and One Class:{0}", n);

            //var X1 = new Castle.Windsor.WindsorContainer();//Create Container 
            X.Register(Component.For<IWindsortest2>().ImplementedBy<Windsortest>()); //register the Interface and Class in which interface extended
            var res1 = X.ResolveAll<IWindsortest2>(); // resolve the Interface.
            int a = 40, b = 20;
            //res1.ADD(a,b);
            foreach (var res3 in res1)
                Console.WriteLine(res3.ADD(a, b));
            AddAndSub(50, 30);

            //var var1 = new Castle.Windsor.WindsorContainer();
            //X.Register(Component.For<IClass>().ImplementedBy<Class1>());
            //var res2 = X.Resolve<IClass>();
            //decimal p = 15, q = 18;
            //Console.WriteLine(res2.Multiply(p, q));


            Console.WriteLine("Reverse a string");
            string str21 = "i am going to market";
            string result21 = "";
            for (int i = str21.Length - 1; i >= 0; i--)
            {
                result21 += str21[i];
            }

            Console.WriteLine(result21);

            Console.WriteLine("Asyncronous task.");
            Call();

            abc ab = new abc();
            ab.A = "";
            Console.WriteLine(ab?.A ?? "Not available");

            CallerInfo();

            int numeric = default;
            Object reference = default;
            DateTime value = default;
            Console.WriteLine(numeric);

            Console.WriteLine(reference);
            Console.WriteLine(value);
        }


        public static void CallerInfo([CallerMemberName] string mname = "", [CallerFilePath] string fpath = "", [CallerLineNumber] int lineno = 0)
        {
            Console.WriteLine(mname);
            Console.WriteLine(fpath);
            Console.WriteLine(lineno);
        }
        public static async Task Call()
        {
            Task<int> t = Method1();
            Method2();
            int count = await t;
            Method3(count);
        }
        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" Method 1");
                    count += 1;
                }
            });
            return count;
        }
        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }
        public static void Method3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }
        public static (decimal? add, decimal? subtract) AddAndSub(decimal? a, decimal? b)
        {
            return ((a + b), (a - b));
        }

        
    }

    public class Calculation
    {
        public int SUM(int x,int y)
        {
            return x + y;
        }
    }
    
    class DerivedClass2 : BaseClass
    {
        void Access()
        {
            // Error CS0122, because myValue can only be
            // accessed by types in Assembly1
            // myValue = 10;
            myValue = 10;
        }
    }
    


    public class abc
    {
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }

        public void ExampleMethod(int required, string optionalstr = "default string", int optionalint = 10)
        {
            Console.WriteLine("{0}: {1}, {2}, and {3}.", required, optionalstr,
                optionalint);
        }
    }
}
