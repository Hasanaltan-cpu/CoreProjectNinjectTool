using CoreProjectNinjectTool.Concrete;
using CoreProjectNinjectTool.InterFace;
using Ninject;
using System;

namespace CoreProjectNinjectTool
{
    class Program
    {
        static void Main(string[] args)
        {
         
            IKernel kernel = new StandardKernel();
            kernel.Bind<IVehicle>().To<Bus>(); // Bind is the command of Ninject for binding with IVehicle & Bus
            var Vehicle = kernel.Get<Vehicle>(); // This is called from Ninject Kernel for Vehicle object

            kernel.Bind<IStation>().To<AStation>();//This is binding with the interface of Station to our A&B Stations by kernel.
            kernel.Bind<IStation>().To<BStation>();
            Vehicle.Use();//That is vehicle object Use method can be use easily by Ninject Kernel.
            Console.Read();


        }
    }
}
