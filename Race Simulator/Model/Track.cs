using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Track
    {
        public string Name;
        public Section section;
        public LinkedList<Section> Sections;

       

        public Track (string name, SectionTypes[] sections)
        {
            Name = name;
            Sections = new LinkedList<Section>();
            foreach (SectionTypes s in sections)
            {
                section = new Section(s);
                Sections.AddLast(section);
            }
            
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(" ");
            return sb.ToString();
        }

    }
}
