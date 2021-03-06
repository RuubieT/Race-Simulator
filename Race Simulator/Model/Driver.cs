﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    //Mag veranderd worden.
    public class Driver : IParticipant
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public IEquipment Equipment { get; set; }
        public TeamColors TeamColor { get; set; }

        public Driver(string name, int points, IEquipment equipment, TeamColors teamcolor)
        {
            Name = name;
            Points = points;
            Equipment = equipment;
            TeamColor = teamcolor;
        }
  
    }
}
