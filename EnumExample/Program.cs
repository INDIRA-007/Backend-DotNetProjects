using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    enum Weekdays { Mon, Tue, Wed, Thu, Fri, Sat, Sun }
    enum TransactionStatus { Success=1, Pending=2, Failed=3}
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("{0} = {1}", Weekdays.Mon, (int)Weekdays.Mon);
            Console.WriteLine("{0} = {1}", Weekdays.Tue, (int)Weekdays.Tue);

            Console.WriteLine("{0} = {1}", TransactionStatus.Success, (int)TransactionStatus.Success);
            Console.WriteLine("{0} = {1}", TransactionStatus.Failed, (int)TransactionStatus.Failed);
        }
    }
}
