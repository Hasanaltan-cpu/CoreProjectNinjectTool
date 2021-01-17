using CoreProjectNinjectTool.InterFace;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProjectNinjectTool.Concrete
{
  public class Vehicle
    {
        IVehicle _vehicle;
        //I called this from interface for generate an interface object.

        [Inject]

        //For this command usage for Nınject in our project with this i will point out it for injection.
        public Vehicle(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }
        public void Use()
        {
            _vehicle.Start();
            _vehicle.Stop();
            _vehicle.TurnRight();
            _vehicle.TurnLeft();
        }
    }
}
