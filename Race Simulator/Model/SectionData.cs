using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class SectionData : IParticipant
    {
        public IParticipant Left;
        public int DistanceLeft;
        public IParticipant Right;
        public int DistanceRight;


        public string Name { get; set; }
        public int Points { get; set; }
        public IEquipment Equipment { get; set; }
        public TeamColors TeamColor { get; set; }

   
    }
}
