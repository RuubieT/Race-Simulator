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
        
        
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Points { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEquipment Equipment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TeamColors TeamColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
