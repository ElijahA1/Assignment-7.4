using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7._4
{
    internal class ParkingSystem
    {
        private uint AvailableBigCarSlots;
        private uint AvailableMediumCarSlots;
        private uint AvailableSmallCarSlots;

        public ParkingSystem(uint bigCarSlots, uint mediumCarSlots, uint smallCarSlots)
        {
            AvailableBigCarSlots = bigCarSlots;
            AvailableMediumCarSlots = mediumCarSlots;
            AvailableSmallCarSlots = smallCarSlots;
        }

        public bool AddCar(uint car)
        {
            if(AvailableBigCarSlots == 0 && car == 1)
                return false;
            if (AvailableMediumCarSlots == 0 && car == 2)
                return false;
            if (AvailableSmallCarSlots == 0 && car == 3)
                return false;
            switch (car)
            {
                case 1:
                    AvailableBigCarSlots--;
                    return true;
                case 2:
                    AvailableMediumCarSlots--;
                    return true;
                case 3:
                    AvailableSmallCarSlots--;
                    return true;
                default:
                    Console.Error.WriteLine("Not an available car type");
                    return false;
            }
        }
    }
}
