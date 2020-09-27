using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Competition
    {
        public Competition()
        {
            Participants = new List<IParticipant>();
            Tracks = new Queue<Track>();
        }

        public List<IParticipant> Participants;
        public Queue<Track> Tracks;
        public Track NextTrack()
        {

        }


    }
}
