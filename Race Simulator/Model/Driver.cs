using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    //Mag veranderd worden.
    public class Driver : IParticipant
    {

        public Driver()
        {

        }


        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Points { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEquipment Equipment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TeamColors TeamColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
