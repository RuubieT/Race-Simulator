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
        public static Competition competition;
        public static Race CurrentRace;
        
        public static void Initialize()
        {
            competition = new Competition();
            AddParticipants();
            AddTrack();
        }

        public static void AddParticipants()
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

            competition.Participants.Add(driver1);
            competition.Participants.Add(driver2);
            competition.Participants.Add(driver3);
            competition.Participants.Add(driver4);
            competition.Participants.Add(driver5);
            competition.Participants.Add(driver6);

        }

        public static void AddTrack()
        {
            SectionTypes[] basic = new SectionTypes[]
            {
                SectionTypes.StartGridHorizontal, 
                SectionTypes.StartGridHorizontal, 
                SectionTypes.StartGridHorizontal, 
                SectionTypes.FinishHorizontal, 
                SectionTypes.WestSouth,
                SectionTypes.StraightVertical, 
                SectionTypes.StraightVertical, 
                SectionTypes.StraightVertical, 
                SectionTypes.NorthWest,
                SectionTypes.StraightHorizontal, 
                SectionTypes.StraightHorizontal, 
                SectionTypes.StraightHorizontal, 
                SectionTypes.EastNorth,
                SectionTypes.StraightVertical, 
                SectionTypes.StraightVertical, 
                SectionTypes.StraightVertical, 
                SectionTypes.SouthEast
            };
            Track oostendorp = new Track("Oostendorp",
                new SectionTypes[] { SectionTypes.StartGridHorizontal, SectionTypes.StartGridHorizontal, SectionTypes.StartGridHorizontal,SectionTypes.FinishHorizontal, SectionTypes.StraightHorizontal,
                    SectionTypes.WestNorth, SectionTypes.StraightVertical,SectionTypes.StraightVertical,SectionTypes.StraightVertical,SectionTypes.SouthEast,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.WestSouth,SectionTypes.StraightVertical, SectionTypes.NorthWest,
                    SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,
                    SectionTypes.EastSouth,SectionTypes.StraightVertical,SectionTypes.StraightVertical,SectionTypes.StraightVertical,SectionTypes.StraightVertical, SectionTypes.NorthEast,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal, SectionTypes.WestSouth,
                    SectionTypes.NorthWest, SectionTypes.EastSouth, SectionTypes.NorthEast, SectionTypes.WestSouth, SectionTypes.NorthWest,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,SectionTypes.StraightHorizontal,
                    SectionTypes.EastNorth,SectionTypes.StraightVertical,SectionTypes.StraightVertical,SectionTypes.StraightVertical,SectionTypes.StraightVertical,SectionTypes.StraightVertical, SectionTypes.SouthEast,SectionTypes.StraightHorizontal, SectionTypes.StraightHorizontal, SectionTypes.StraightHorizontal, SectionTypes.StraightHorizontal});

            
            Track track2 = new Track("Track 2", basic);


            competition.Tracks.Enqueue(oostendorp);
            competition.Tracks.Enqueue(track2);
           
        }

        public static void NextRace()
        {
            List<IParticipant> Participants = competition.Participants;

            CurrentRace = new Race(competition.NextTrack(), Participants);

        }

    }
}
