using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using ControllerTest;
using Model;

namespace Controller
{
    public static class Data
    {
        public static Competition competitite;
        public static Track track;
        public static Race CurrentRace;
        

        public static void Initialize()
        {
            competitite = new Competition();
            track = new Track("Track 1");
            VoegDeelnemersToe();
            VoegTrackToe();

        }

        public static void VoegDeelnemersToe()
        {
            competitite.Participants.Add(new Driver());
            competitite.Participants.Add(new Driver());
            competitite.Participants.Add(new Driver());
            competitite.Participants.Add(new Driver());
        }

        public static void VoegTrackToe()
        {
            competitite.Tracks.Enqueue(track);
            competitite.Tracks.Enqueue(new Track("Track 2" ));
            competitite.Tracks.Enqueue(new Track("Track 3" ));
            competitite.Tracks.Enqueue(new Track("Track 4" ));
        }

        public static void NextRace()
        {
           competitite.NextTrack();
           if (competitite.Tracks != null){
                CurrentRace = new Race(track);
           }
                 

        }

        

    }
}
