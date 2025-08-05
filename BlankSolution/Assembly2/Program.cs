using System;
using Assembly1;
namespace Assembly2
{
    public class Assembly2DerivedClass : Assembly1BaseClass
    {
        public void TestAccessInDerivedClass()
        {
            //Not accessible
            //Console.WriteLine(privateVariable);
            //Console.WriteLine(internalVariable);

            //accessbile
            Console.WriteLine(protectedVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVariable);
        }
    }

    public class Assembly2OtherClass
    {
        public void TestAccessOtherClass()
        {
            Assembly1BaseClass objBase = new Assembly1BaseClass();

            //Not accessible
            //Console.WriteLine(objBase.privateVariable);
            //Console.WriteLine(objBase.internalVariable);
            //Console.WriteLine(objBase.protectedVariable);
            //Console.WriteLine(objBase.protectedInternalVariable);

            ////accessbile
            Console.WriteLine(objBase.publicVariable);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly2DerivedClass objDerived = new Assembly2DerivedClass();
            objDerived.TestAccessInDerivedClass();

            Console.WriteLine();
            
            //to access parent class object
            objDerived.TestAccess();

            Console.WriteLine();

            Assembly2OtherClass objOther = new Assembly2OtherClass();
            objOther.TestAccessOtherClass();
                 

        }
    }
}
