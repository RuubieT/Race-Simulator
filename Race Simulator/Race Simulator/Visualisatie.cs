using System;
using System.Collections.Generic;
using System.Text;
using ControllerTest;
using Model;

namespace Race_Simulator
{
    public static class Visualisatie
    {
        private static int x;
        private static int y;
        private static int Richting;


        #region graphics
        private static string[] _OostNaarZuid =
        {
            " /--", 
            "/   ",
            "|   ",
            "|  /"
        };
        private static string[] _ZuidNaarOost =
        {
            " /--",
            "/   ",
            "|   ",
            "|  /"
        };
        private static string[] _OostNaarNoord =
        {
            "|  \\",
            "|   ",
            "\\   ",
            " \\--"
        };
        private static string[] _NoordNaarOost =
        {
            "|  \\",
            "|   ",
            "\\   ",
            " \\--"
        };
        private static string[] _WestNaarZuid =
        {
            "--\\ ",
            "   \\",
            "   |",
            "\\  |"
        };
        private static string[] _ZuidNaarWest =
        {
            "--\\ ",
            "   \\",
            "   |",
            "\\  |"
        };
        private static string[] _NoordNaarWest = 
        { 
            "/  |",
            "   |",
            "   /",
            "--/ "
        };
        private static string[] _WestNaarNoord =
        {
            "/  |",
            "   |",
            "   /",
            "--/ "
        };

        private static string[] _lijnVerticaal =
        {
            "|  |",
            "|  |",
            "|  |",
            "|  |"
        };
        private static string[] _lijnHorizontaal =
        {
            "----",
            "    ",
            "    ",
            "----"
        };

        private static string[] _finishHorizontal =
        {
            "----", 
            "  # ", 
            "  # ", 
            "----"
        };
        private static string[] _finishVertical =
        {
            "|##|",
            "|  |", 
            "|  |", 
            "|  |"
        };
        private static string[] _startGridHorizontal =
        {
            "----",
            "  ] ",
            " ]  ",
            "----"
        };
        private static string[] _startGridVertical =
        {
            "|  |",
            "|^ |",
            "| ^|",
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
            Richting = 1;
        }

      

        public static void DrawTrack(Track track)
        {
            x = 30;
            y = 50;
            foreach (var s in track.Sections)
            {
                switch (s.SectionType.ToString())
                {
                    case "StartGridHorizontal":
                        DrawSection(_startGridHorizontal, x, y);
                        SetXenY();
                        break;
                    case "StartGridVertical":
                        DrawSection(_startGridVertical, x, y);
                        SetXenY();
                        break;
                    case "FinishHorizontal":
                        DrawSection(_finishHorizontal, x, y);
                        SetXenY();
                        break;
                    case "FinishVertical":
                        DrawSection(_finishVertical, x, y);
                        SetXenY();
                        break;
                    case "StraightHorizontal":
                        DrawSection(_lijnHorizontaal, x, y);
                        SetXenY();
                        break;
                    case "StraightVertical":
                        DrawSection(_lijnVerticaal, x, y);
                        SetXenY();
                        break;
                    case "NoordOost":
                        SetRichting(SectionTypes.NoordOost);
                        DrawSection(_NoordNaarOost, x, y);
                        SetXenY();
                        break;
                    case "NoordWest":
                        SetRichting(SectionTypes.NoordWest);
                        DrawSection(_NoordNaarWest, x, y);
                        SetXenY();
                        break;
                    case "OostNoord":
                        SetRichting(SectionTypes.OostNoord);
                        DrawSection(_OostNaarNoord, x, y);
                        SetXenY();
                        break;
                    case "OostZuid":
                        SetRichting(SectionTypes.OostZuid);
                        DrawSection(_OostNaarZuid, x, y);
                        SetXenY();
                        break;
                    case "ZuidOost":
                        SetRichting(SectionTypes.ZuidOost);
                        DrawSection(_ZuidNaarOost, x, y);
                        SetXenY();
                        break;
                    case "ZuidWest":
                        SetRichting(SectionTypes.ZuidWest);
                        DrawSection(_ZuidNaarWest, x, y);
                        SetXenY();
                        break;
                    case "WestNoord":
                        SetRichting(SectionTypes.WestNoord);
                        DrawSection(_WestNaarNoord, x, y);
                        SetXenY();
                        break;
                    case "WestZuid":
                        SetRichting(SectionTypes.WestZuid);
                        DrawSection(_WestNaarZuid, x, y);
                        SetXenY();
                        break;

                }

            }

        }
        public static void DrawSection(string[] section, int x, int y)
        {
            Console.CursorTop = y;
            foreach (var s in section)
            {
                Console.CursorLeft = x;
                Console.WriteLine(s);
            }
        }

        public static void SetRichting(SectionTypes sectiontype)
        {
            switch (sectiontype)
            {
                case SectionTypes.NoordOost:
                    Richting = 1;
                    break;
                case SectionTypes.NoordWest:
                    Richting = 3;
                    break;
                case SectionTypes.OostNoord:
                    Richting = 0;
                    break;
                case SectionTypes.OostZuid:
                    Richting = 2;
                    break;
                case SectionTypes.ZuidOost:
                    Richting = 1;
                    break;
                case SectionTypes.ZuidWest:
                    Richting = 3;
                    break;
                case SectionTypes.WestNoord:
                    Richting = 0;
                    break;
                case SectionTypes.WestZuid:
                    Richting = 2;
                    break;
            }
        }

        public static void SetXenY()
        {
            switch (Richting)
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

    }
}
