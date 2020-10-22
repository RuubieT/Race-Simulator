﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    //Mag veranderd worden.
    public class Car : IEquipment
    {
        public int Quality { get; set; }
        public int Performance { get; set; }
        public int Speed { get; set; }
        public bool IsBroken { get; set; }

        public Car(int quality, int performance, int speed, bool isbroken)
        {
            Quality = quality;
            Performance = performance;
            Speed = speed;
            IsBroken = isbroken;
        }

    }
}
