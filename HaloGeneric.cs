using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL5_103022400130
{
    internal class HaloGeneric
    {
        public static void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
    }
}
