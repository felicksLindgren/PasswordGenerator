using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(System.Web.Security.Membership.GeneratePassword(20, 10));
            Console.ReadLine();
        }
    }
}
