using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public enum SectionTypes
    {
        StraightHorizontal,
        StraightVertical,

        NorthEast,
        NorthWest,

        EastNorth,
        EastSouth,

        SouthEast,
        SouthWest,

        WestNorth,
        WestSouth,

        StartGridHorizontal,
        StartGridVertical,

        FinishHorizontal,
        FinishVertical
    }
    public class Section
    {
        public SectionTypes SectionType { get; set; }

        public Section(SectionTypes sectiontype)
        {
            SectionType = sectiontype;
        }
        

    }
}
