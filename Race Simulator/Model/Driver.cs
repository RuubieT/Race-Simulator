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
