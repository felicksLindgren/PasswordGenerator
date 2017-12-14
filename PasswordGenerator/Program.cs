using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var pass = System.Web.Security.Membership.GeneratePassword(20, 10);
            Console.WriteLine(pass);
            Clipboard.SetText(pass);
            Console.WriteLine("Copied to clipboard.");
            Console.ReadLine();
        }
    }
}
