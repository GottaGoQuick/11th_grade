using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ConsoleApp1
{
    internal class Program
    {
        // Import the mouse_event function from user32.dll
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        // Define constants for mouse events
        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;

        static void Main(string[] args)
        {
            int start = 0;
            while (start > -1)
            {
                Console.WriteLine("Press p to start");
                string pchecker = Console.ReadLine();
                if (pchecker == "p")
                {
                    for (int i = 0; i < 100; i++)
                    {
                        // Simulate mouse click
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        // Add a slight delay to avoid overwhelming the system
                        System.Threading.Thread.Sleep(10);
                    }
                    start = -1;
                }
                else
                {
                    start++;
                }
            }
        }
    }
}
