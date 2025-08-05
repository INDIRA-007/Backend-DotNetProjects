using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly1
{
    public class Assembly1BaseClass
    {
        private string privateVariable = "private";
        protected string protectedVariable = "protected";
        internal string internalVariable = "internal";
        protected internal string protectedInternalVariable = "protected internal";
        public string publicVariable = "public";

        public void TestAccess()
        {
            //accessible
            Console.WriteLine(privateVariable);
            Console.WriteLine(protectedVariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVariable);
        }

    }
    public class Assembly1DerivedClass : Assembly1BaseClass
    {
        public void TestAccessDerivedClass()
        {
            //Not accessible
            //Console.WriteLine(privateVariable);
            
            //accessbile
            Console.WriteLine(protectedVariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVariable);
        }
    }

    public class Assembly1OtherClass
    {
        public void TestAccessOtherClass()
        {
            // to call properties of base class to other class without deriving it 
            // create the object of baseclass and call the properties/methods object.property
            Assembly1BaseClass objBase = new Assembly1BaseClass();

            //Not accessible
            //Console.WriteLine(objBase.privateVariable);
            //Console.WriteLine(objBase.protectedVariable);
            
            //accessible
            Console.WriteLine(objBase.internalVariable);
            Console.WriteLine(objBase.protectedInternalVariable);
            Console.WriteLine(objBase.publicVariable);
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            //Assembly1BaseClass objBase = new Assembly1BaseClass();
            //objBase.TestAccess();

            Assembly1DerivedClass objDerivedClass = new Assembly1DerivedClass();
            objDerivedClass.TestAccessDerivedClass();

            Console.WriteLine();

            //to access method of base class from object of derived class
            objDerivedClass.TestAccess();

            Console.WriteLine();

            Assembly1OtherClass objOtherClass = new Assembly1OtherClass();
            objOtherClass.TestAccessOtherClass();

            Console.WriteLine();


        }
    }
}
