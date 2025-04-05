using CollegeFestEventHandling;
using System;
using System.Windows.Forms;

namespace YourNamespaceHere
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // Use modern UI elements
            Application.SetCompatibleTextRenderingDefault(false); // Use GDI+ text rendering
            Application.Run(new Form1()); // Start the application and load Form1
        }
    }
}
