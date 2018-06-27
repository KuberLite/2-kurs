using System;
using System.Collections.Generic;

namespace Task4_1_
{
    public class BstuNet
    {
        private static readonly BstuNet bstuNet = new BstuNet();

        public List<Server> servers { get; private set; }

        private BstuNet()
        { 
        }

        public static BstuNet GetInstance()
        {
            return bstuNet;
        }
    }
}