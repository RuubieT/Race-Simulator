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
        public static Race CurrentRace;
        
        public static void Initialize()
        {
            competitite = new Competition();
            VoegDeelnemersToe();
            VoegTrackToe();
        }

        public static void VoegDeelnemersToe()
        {
            Car car1 = new Car(7, 5, 60, false);
            Driver driver1 = new Driver("Ruben", 0, car1, TeamColors.Red);
            Car car2 = new Car(4, 7, 80, false);
            Driver driver2 = new Driver("Bob", 0, car2, TeamColors.Blue);
            Car car3 = new Car(8, 8, 90, false);
            Driver driver3 = new Driver("Shrek", 0, car3, TeamColors.Green);
            Car car4 = new Car(3, 8, 55, false);
            Driver driver4 = new Driver("Igor", 0, car4, TeamColors.Yellow);

            competitite.Participants.Add(driver1);
            competitite.Participants.Add(driver2);
            competitite.Participants.Add(driver3);
            competitite.Participants.Add(driver4);
            
        }

        public static void VoegTrackToe()
        {
            SectionTypes[] sections = new SectionTypes[]
            {
                SectionTypes.Straight,
                SectionTypes.LeftCorner,
                SectionTypes.RightCorner,
                SectionTypes.StartGrid,
                SectionTypes.Finish
            };
            Track track1 = new Track("Track 1a", sections);
            Track track2 = new Track("Track 2b", sections);
            Track track3 = new Track("Track 3c", sections);
            Track track4 = new Track("Track 4", sections);

            competitite.Tracks.Enqueue(track1);
            competitite.Tracks.Enqueue(track2);
            competitite.Tracks.Enqueue(track3);
            competitite.Tracks.Enqueue(track4);
        }

        public static void NextRace()
        {
            List<IParticipant> Participants = new List<IParticipant>();

            CurrentRace = new Race(competitite.NextTrack(), Participants);

        }

    }
}
