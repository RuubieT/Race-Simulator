using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    //Mag veranderd worden.
    public class Car : IEquipment
    {
        public Car()
        {

        }

        public int Quality { get; set ; }
        public int Performance { get; set; }
        public int Speed { get; set; }
        public bool IsBroken { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(" ");
            return sb.ToString();
        }


    }
}
