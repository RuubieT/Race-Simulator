using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Competition
    {
        public Competition()
        {

        }

        public List<IParticipant> Participants;
        Queue<Track> Tracks;
        public Track NextTrack;


    }
}
