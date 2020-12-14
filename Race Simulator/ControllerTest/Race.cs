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

            _positions = new Dictionary<Section, SectionData>();
            _random = new Random(DateTime.Now.Millisecond);
            StartPosition(t, participants);

        }

        public SectionData GetSectionData(Section s)
        {
            SectionData value;
            if (_positions.TryGetValue(s, out value))
            {
                return value;
            }
            else
            {
                _positions.Add(s, new SectionData());
                return _positions[s];
            }
        }

        public void RandomizeEquipment()
        {
            foreach (IParticipant p in Participants)
            {
                p.Equipment.Quality = _random.Next(1, 5);
                p.Equipment.Performance = _random.Next(1, 5);
            }
        }

        public void StartPosition(Track t, List<IParticipant> participants)
        {
            int placedParticipants = 0;
            foreach (Section s in t.Sections)
            {
                if (s.SectionType.Equals(SectionTypes.StartGridHorizontal) || s.SectionType.Equals(SectionTypes.StartGridVertical))
                {
                    for (int i = 0; i < 2; i++)
                    {
                        try
                        {
                            if (placedParticipants == 0 || placedParticipants % 2 == 0)
                            {
                                GetSectionData(s).Right = participants[placedParticipants];
                                GetSectionData(s).DistanceRight = 40;
                            }
                            else
                            {
                                GetSectionData(s).Left = participants[placedParticipants];
                                GetSectionData(s).DistanceLeft = 20;
                            }
                            placedParticipants++;
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    GetSectionData(s);
                }

            }
        }
    }
}
