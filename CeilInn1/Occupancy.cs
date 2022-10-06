﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeilInn1
{
    public class Occupancy
    {
        public string OccupancyNumber { get; set; }
        public DateTime DateOccupied { get; set; }
        public string ProcessedBy { get; set; }
        public string ProcessedFor { get; set; }
        public string RoomOccupied { get; set; }
        public double RateApplied { get; set; }
        public double PhoneUse { get; set; }

        public override bool Equals(object? obj)
        {
            Occupancy rental = (Occupancy)obj;

            if (rental.OccupancyNumber == this.OccupancyNumber)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
