using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Tests
{
    public class UnitTest1TestFile
    {
        //Naming conventions - ClassName_MethodName_ExceptedResult
        public static void UnitTest1TestFile_ReturnPikachu_ReturnString()
        {
            try
            {
                //Arrange - Go get your variables, classes, methods
                int num = 0;
                UnitTestDemo Ut = new UnitTestDemo();

                //Act - execute this function
                string result = Ut.ReturnPikachu(num);

                //Assert - whatever is returned is it what we want
                if(result == "Pikachu")
                {
                    Console.WriteLine("Passed : UnitTest");
                }
                else
                {
                    Console.WriteLine("Failed: ");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
