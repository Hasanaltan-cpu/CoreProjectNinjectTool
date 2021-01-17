using CoreProjectNinjectTool.InterFace;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProjectNinjectTool.Concrete
{
    class BStation : IStation
    {
        public BStation()
        {
            Station();
        }
        public int Station()
        {
            Console.WriteLine("B station is here");
            return 15;
        }
    }
}
