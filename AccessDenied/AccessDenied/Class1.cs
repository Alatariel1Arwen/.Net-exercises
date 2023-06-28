using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDenied
{
    internal class Class1
    {
        private int priv = 3;

        protected int prot = 3;

        internal int Inter = 4;

        public int Pub = 5;


        public int GetPriv()
        {
            return priv;
        }
        public int GetProt()
        {
            return prot;
        }

    }
}
