using CoreProjectNinjectTool.InterFace;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProjectNinjectTool.Concrete
{
    class AStation:IStation
    {
        public AStation()
        {
            Station();
        }
        public int Station()
        {
            Console.WriteLine("A station is here..");
            return 10;
        }
    }
}
