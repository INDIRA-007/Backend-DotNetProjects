using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class UnitTestDemo
    {
        public string ReturnPikachu(int num)
        {
            if (num == 0)
            {
                return "Pikachu";
            }
            else
            {
                return "Resources is not available";
            }
        }
    }
}
