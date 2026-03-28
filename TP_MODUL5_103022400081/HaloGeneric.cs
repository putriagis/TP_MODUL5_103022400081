using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL5_103022400081
{
    internal class HaloGeneric
    {
        public void SapaUser <T>(T user)
        {
            Console.WriteLine("Halo user " + user);
        }
    }
}
