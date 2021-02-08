using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1School_CarWAshSystem
{
    public class WashingHall
    {
        public List<Vehicle> VehicleInHall { get; set; }

        public List<WashingType> WashType { get; set; }

        public WashingHall(List<WashingType> types)
        {
            WashType = new List<WashingType>();
            WashType = types;
        }

        public void AddWashType(WashingType type)
        {
            WashType.Add(type);
        }
    }
}