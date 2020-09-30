using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Competition
    {
        public List<IParticipant> Participants;
        public Queue<Track> Tracks;

        public Competition()
        {
            Participants = new List<IParticipant>();
            Tracks = new Queue<Track>();
            
        }

        
        public Track NextTrack()
        {
            
            if (Tracks.Count > 0)
            {
                Console.WriteLine($"De huidige track = {Tracks.Dequeue()}");
                 
            }
            return null;
            

        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(" ");
            return sb.ToString();
        }


    }
}
