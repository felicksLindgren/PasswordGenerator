using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var pass = System.Web.Security.Membership.GeneratePassword(20, 10);
            Clipboard.SetText(pass);
            Console.WriteLine($@"""{pass}"" has been copied to clipboard.");
            Console.ReadLine();
        }
    }
}
