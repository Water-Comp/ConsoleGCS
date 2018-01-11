using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGCS
{
    static class Elementary
    {
        public static void SendToServer(string message, string IP)
        {
            TCP.Connect(IP, message, 3456);
        }
    }
}
