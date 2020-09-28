using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace ControllerTest
{
    public class Race
    {
        public Track track;
        public List<IParticipant> Participants;
        public DateTime StartTime;

        private Random _random;
        private Dictionary<Section, SectionData> _positions;

        public Race(Track t, List<IParticipant> participants)
        {
            track = t;
            participants = new List<IParticipant>();
            Participants = participants;
            _random = new Random(DateTime.Now.Millisecond);

        }

        public Race (Track t)
        {
            track = t;
        }



       
        public void GetSectionData(Section s)
        {
            if (!_positions.TryGetValue(s, out SectionData sectionData))
            {
                return;
            }
            else
            {
                _positions.Add(s, sectionData);
            }
        }


        public void RandomizeEquipment()
        {
            foreach (IParticipant p in Participants)
            {
                p.Equipment.Quality = 4;
                p.Equipment.Performance = 1;
            }
        }
    }
}
