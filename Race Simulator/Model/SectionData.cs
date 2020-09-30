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

        public SectionData(IParticipant left, int distanceleft, IParticipant right, int distanceright)
        {
            Left = left;
            DistanceLeft = distanceleft;
            Right = right;
            DistanceRight = distanceright;

        }
        
        
        public string Name { get; set; }
        public int Points { get; set; }
        public IEquipment Equipment { get; set; }
        public TeamColors TeamColor { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(" ");
            return sb.ToString();
        }
    }
}
