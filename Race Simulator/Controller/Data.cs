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
            Car car5 = new Car(9, 10, 88, false);
            Driver driver5 = new Driver("Mario", 0, car5, TeamColors.Red);
            Car car6 = new Car(5, 8, 99, false);
            Driver driver6 = new Driver("Luigi", 0, car6, TeamColors.Green);

            competitite.Participants.Add(driver1);
            competitite.Participants.Add(driver2);
            competitite.Participants.Add(driver3);
            competitite.Participants.Add(driver4);
            competitite.Participants.Add(driver5);
            competitite.Participants.Add(driver6);

        }

        public static void VoegTrackToe()
        {
            SectionTypes[] basic = new SectionTypes[]
            {
                SectionTypes.StartGridHorizontal, 
                SectionTypes.StartGridHorizontal, 
                SectionTypes.StartGridHorizontal, 
                SectionTypes.FinishHorizontal, 
                SectionTypes.WestZuid,
                SectionTypes.StraightVertical, 
                SectionTypes.StraightVertical, 
                SectionTypes.StraightVertical, 
                SectionTypes.NoordWest,
                SectionTypes.StraightHorizontal, 
                SectionTypes.StraightHorizontal, 
                SectionTypes.StraightHorizontal, 
                SectionTypes.OostNoord,
                SectionTypes.StraightVertical, 
                SectionTypes.StraightVertical, 
                SectionTypes.StraightVertical, 
                SectionTypes.ZuidOost
            };
            Track oostendorp = new Track("Oostendorp",
                new SectionTypes[] { SectionTypes.StartGridHorizontal, SectionTypes.StartGridHorizontal, SectionTypes.StartGridHorizontal,SectionTypes.FinishHorizontal, SectionTypes.StraightHorizontal,
                    SectionTypes.WestNoord, SectionTypes.StraightVertical,SectionTypes.StraightVertical,SectionTypes.StraightVertical,SectionTypes.ZuidOost,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.WestZuid,SectionTypes.StraightVertical, SectionTypes.NoordWest,
                    SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,
                    SectionTypes.OostZuid,SectionTypes.StraightVertical,SectionTypes.StraightVertical,SectionTypes.StraightVertical,SectionTypes.StraightVertical, SectionTypes.NoordOost,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal, SectionTypes.WestZuid,
                    SectionTypes.NoordWest, SectionTypes.OostZuid, SectionTypes.NoordOost, SectionTypes.WestZuid, SectionTypes.NoordWest,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,
                    SectionTypes.OostNoord,SectionTypes.StraightVertical,SectionTypes.StraightVertical,SectionTypes.StraightVertical,SectionTypes.StraightVertical,SectionTypes.StraightVertical, SectionTypes.ZuidOost,SectionTypes.StraightHorizontal, SectionTypes.StraightHorizontal, SectionTypes.StraightHorizontal, SectionTypes.StraightHorizontal});

            
            Track track2 = new Track("Track 2", basic);


            competitite.Tracks.Enqueue(oostendorp);
            competitite.Tracks.Enqueue(track2);
           
        }

        public static void NextRace()
        {
            List<IParticipant> Participants = competitite.Participants;

            CurrentRace = new Race(competitite.NextTrack(), Participants);

        }

    }
}
