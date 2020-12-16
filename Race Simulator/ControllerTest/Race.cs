using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using Model;

namespace ControllerTest
{
    public class Race
    {
        public Track track;
        public List<IParticipant> Participants;
        public DateTime StartTime;
        public event EventHandler TimedEvent;
        public event EventHandler DriversChanged;

        private Timer timer;
        private Random _random;
        private Dictionary<Section, SectionData> _positions;

        public Race(Track t, List<IParticipant> participants)
        {
            track = t;
            timer = new Timer(500);
            timer.Elapsed += OnTimedEvent;


            _positions = new Dictionary<Section, SectionData>();
            _random = new Random(DateTime.Now.Millisecond);
            StartPosition(t, participants);

        }

        

        public void OnTimedEvent(object o, ElapsedEventArgs e)
        {
            Start();
        }


        public void Start()
        {
            timer.Start();
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
                placedParticipants = PlaceParticipants(participants, placedParticipants, s);
            }
        }

        public int PlaceParticipants(List<IParticipant> participants, int placedParticipants, Section s)
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

            return placedParticipants;
        }
    }
}
