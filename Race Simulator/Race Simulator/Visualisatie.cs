using System;
using System.Collections.Generic;
using System.Text;
using Controller;
using ControllerTest;
using Model;

namespace Race_Simulator
{
    public static class Visualisatie
    {
        private static int x;
        private static int y;
        private static int Direction;

        //All the sections.
        #region graphics
        private static string[] _OostNaarZuid =
        {
            " /--", 
            "/2  ",
            "| 1 ",
            "|  /"
        };
        private static string[] _ZuidNaarOost =
        {
            " /--",
            "/1  ",
            "| 2 ",
            "|  /"
        };
        private static string[] _OostNaarNoord =
        {
            "|  \\",
            "|  2",
            "\\1  ",
            " \\--"
        };
        private static string[] _NoordNaarOost =
        {
            "|  \\",
            "|  1",
            "\\2  ",
            " \\--"
        };
        private static string[] _WestNaarZuid =
        {
            "--\\ ",
            "  1\\",
            " 2 |",
            "\\  |"
        };
        private static string[] _ZuidNaarWest =
        {
            "--\\ ",
            "  2\\",
            " 1 |",
            "\\  |"
        };
        private static string[] _NoordNaarWest = 
        { 
            "/  |",
            "1  |",
            " 2 /",
            "--/ "
        };
        private static string[] _WestNaarNoord =
        {
            "/  |",
            "2  |",
            " 1 /",
            "--/ "
        };

        private static string[] _lijnVerticaal =
        {
            "|  |",
            "|1 |",
            "| 2|",
            "|  |"
        };
        private static string[] _lijnHorizontaal =
        {
            "----",
            "  1 ",
            " 2  ",
            "----"
        };

        private static string[] _finishHorizontal =
        {
            "----", 
            "  1#", 
            " 2 #", 
            "----"
        };
        private static string[] _finishVertical =
        {
            "|##|",
            "|1 |", 
            "| 2|", 
            "|  |"
        };
        private static string[] _startGridHorizontal =
        {
            "----",
            "  1]",
            " 2] ",
            "----"
        };
        private static string[] _startGridVertical =
        {
            "|^ |",
            "|1^|",
            "| 2 |",
            "|  |"
        };

        private static string[] _empty =
        {
            "    ", 
            "    ", 
            "    ", 
            "    "
        };


        #endregion

        public static void Initialize()
        {
            x = 0;
            y = 0;
            Direction = 1;
        }
            
        //Checking all options and drawing the whole track.
        public static void DrawTrack(Track track)
        {
            x = 30;
            y = 50;
            foreach (var s in track.Sections)
            {
                switch (s.SectionType.ToString())
                {
                    case "StartGridHorizontal":
                        DrawSection(ReplacePlaceholders(_startGridHorizontal, Data.CurrentRace.GetSectionData(s).Right, Data.CurrentRace.GetSectionData(s).Left), x, y);
                        SetXenY();
                        break;
                    case "StartGridVertical":
                        DrawSection(ReplacePlaceholders(_startGridVertical, Data.CurrentRace.GetSectionData(s).Right, Data.CurrentRace.GetSectionData(s).Left), x, y);
                        SetXenY();
                        break;
                    case "FinishHorizontal":
                        DrawSection(ReplacePlaceholders(_finishHorizontal, Data.CurrentRace.GetSectionData(s).Right, Data.CurrentRace.GetSectionData(s).Left), x, y);
                        SetXenY();
                        break;
                    case "FinishVertical":
                        DrawSection(ReplacePlaceholders(_finishVertical, Data.CurrentRace.GetSectionData(s).Right, Data.CurrentRace.GetSectionData(s).Left), x, y);
                        SetXenY();
                        break;
                    case "StraightHorizontal":
                        DrawSection(ReplacePlaceholders(_lijnHorizontaal, Data.CurrentRace.GetSectionData(s).Right, Data.CurrentRace.GetSectionData(s).Left), x, y);
                        SetXenY();
                        break;
                    case "StraightVertical":
                        DrawSection(ReplacePlaceholders(_lijnVerticaal, Data.CurrentRace.GetSectionData(s).Right, Data.CurrentRace.GetSectionData(s).Left), x, y);
                        SetXenY();
                        break;
                    case "NoordOost":
                        SetDirection(SectionTypes.NoordOost);
                        DrawSection(ReplacePlaceholders(_NoordNaarOost, Data.CurrentRace.GetSectionData(s).Right, Data.CurrentRace.GetSectionData(s).Left), x, y);
                        SetXenY();
                        break;
                    case "NoordWest":
                        SetDirection(SectionTypes.NoordWest);
                        DrawSection(ReplacePlaceholders(_NoordNaarWest, Data.CurrentRace.GetSectionData(s).Right, Data.CurrentRace.GetSectionData(s).Left), x, y);
                        SetXenY();
                        break;
                    case "OostNoord":
                        SetDirection(SectionTypes.OostNoord);
                        DrawSection(ReplacePlaceholders(_OostNaarNoord, Data.CurrentRace.GetSectionData(s).Right, Data.CurrentRace.GetSectionData(s).Left), x, y);
                        SetXenY();
                        break;
                    case "OostZuid":
                        SetDirection(SectionTypes.OostZuid);
                        DrawSection(ReplacePlaceholders(_OostNaarZuid, Data.CurrentRace.GetSectionData(s).Right, Data.CurrentRace.GetSectionData(s).Left), x, y);
                        SetXenY();
                        break;
                    case "ZuidOost":
                        SetDirection(SectionTypes.ZuidOost);
                        DrawSection(ReplacePlaceholders(_ZuidNaarOost, Data.CurrentRace.GetSectionData(s).Right, Data.CurrentRace.GetSectionData(s).Left), x, y);
                        SetXenY();
                        break;
                    case "ZuidWest":
                        SetDirection(SectionTypes.ZuidWest);
                        DrawSection(ReplacePlaceholders(_ZuidNaarWest, Data.CurrentRace.GetSectionData(s).Right, Data.CurrentRace.GetSectionData(s).Left), x, y);
                        SetXenY();
                        break;
                    case "WestNoord":
                        SetDirection(SectionTypes.WestNoord);
                        DrawSection(ReplacePlaceholders(_WestNaarNoord, Data.CurrentRace.GetSectionData(s).Right, Data.CurrentRace.GetSectionData(s).Left), x, y);
                        SetXenY();
                        break;
                    case "WestZuid":
                        SetDirection(SectionTypes.WestZuid);
                        DrawSection(ReplacePlaceholders(_WestNaarZuid, Data.CurrentRace.GetSectionData(s).Right, Data.CurrentRace.GetSectionData(s).Left), x, y);
                        SetXenY();
                        break;

                }

            }

        }

        //Making sure after a section is drawn everything updates.
        public static void DrawSection(string[] section, int x, int y)
        {
            Console.CursorTop = y;
            foreach (var s in section)
            {
                Console.CursorLeft = x;
                Console.WriteLine(s);
            }
        }

        //Confirms which direction a new sections needs to be built at.
        public static void SetDirection(SectionTypes sectiontype)
        {
            switch (sectiontype)
            {
                case SectionTypes.NoordOost:
                    Direction = 1;
                    break;
                case SectionTypes.NoordWest:
                    Direction = 3;
                    break;
                case SectionTypes.OostNoord:
                    Direction = 0;
                    break;
                case SectionTypes.OostZuid:
                    Direction = 2;
                    break;
                case SectionTypes.ZuidOost:
                    Direction = 1;
                    break;
                case SectionTypes.ZuidWest:
                    Direction = 3;
                    break;
                case SectionTypes.WestNoord:
                    Direction = 0;
                    break;
                case SectionTypes.WestZuid:
                    Direction = 2;
                    break;
                default:
                    Direction = 1;
                    break;
            }
        }

        //After a new direction is given update all the positions.
        public static void SetXenY()
        {
            switch (Direction)
            {
                case 0:
                    y = y - 4;
                    break;
                case 1:
                    x = x + 4;
                    break;
                case 2:
                    y = y + 4;
                    break;
                case 3:
                    x = x - 4;
                    break;
            }
        }

        //Visualising participants.
        public static string[] ReplacePlaceholders(string[] section, IParticipant right, IParticipant left)
        {
            char nameLeft;
            char nameRight;
            string[] result = { "", "", "", "" };

            if (left is null && !(right is null))
            {
                for (int i = 0; i < 4; i++)
                {
                    string s = section[i];
                    nameRight = right.Name[0];
                    if (right.Equipment.IsBroken)
                        nameRight = 'X';

                    result[i] = s.Replace('1', nameRight).Replace('2', ' ');
                }
                return result;
            }
            if (!(left is null) && right is null)
            {
                for (int i = 0; i < 4; i++)
                {
                    string s = section[i];
                    nameLeft = left.Name[0];
                    if (left.Equipment.IsBroken)
                        nameLeft = 'X';

                    result[i] = s.Replace('1', ' ').Replace('2', nameLeft);
                }
                return result;
            }
            if (left is null && right is null)
            {
                for (int i = 0; i < 4; i++)
                {
                    string s = section[i];

                    result[i] = s.Replace('1', ' ').Replace('2', ' ');
                }
                return result;
            }
            for (int i = 0; i < 4; i++)
            {
                string s = section[i];
                nameRight = right.Name[0];
                nameLeft = left.Name[0];
                if (right.Equipment.IsBroken)
                    nameRight = 'X';
                if (left.Equipment.IsBroken)
                    nameLeft = 'X';

                result[i] = s.Replace('1', nameRight).Replace('2', nameLeft);
            }
            return result;
        }
    }
}
