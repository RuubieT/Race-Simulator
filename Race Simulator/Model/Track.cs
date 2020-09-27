using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Track
    {
        public string Name;
        public LinkedList<Section> Sections;

        public Track()
        {

        }

        public Track (string name, SectionTypes[] sections)
        {
            Name = name;
            Sections = new LinkedList<Section>();

        }
    }
}
