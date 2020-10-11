using System;
using Controller;
using Model;


namespace Race_Simulator
{
    public class Program
    {
        public static class Visualisatie
        {
            #region graphics
            private static string[] _linksBovenBocht = {" /--", "/   ", "|   ", "|  /"};
            private static string[] _lijnHorizontaal = {"----", "    ", "    ", "----"};
            private static string[] _finishHorizontal = { "----", "  # ", "  # ", "----" };
            private static string[] _rechtsBovenBocht = {"--\\ ", "   \\", "   |", "\\  |"};
            private static string[] _lijnVerticaal = {"|  |","|  |","|  |", "|  |"};
            private static string[] _empty = {"    ", "    ", "    ", "    "};
            private static string[] _linksOnderBocht = { "|  \\", "|   ", "\\   ", " \\--" };
            private static string[] _rechtsOnderBocht = { "/  |", "   |", "   /", "--/ " };

            private static Array[] TopRow =
                {_linksBovenBocht, _lijnHorizontaal, _finishHorizontal, _rechtsBovenBocht};
            private static Array[] MidTopRow =
                {_lijnVerticaal, _empty, _empty, _lijnVerticaal};
            private static Array[] MidBottomRow =
                {_lijnVerticaal, _empty, _empty, _lijnVerticaal};
            private static Array[] BottomRow =
                {_linksOnderBocht, _lijnHorizontaal, _lijnHorizontaal, _rechtsOnderBocht};

            #endregion

            public static void Initialize()
            {

            }


            public static void DrawTrack(Track track)
            {
                Console.WriteLine(track.Name);
               
                
                    for (int i = 0; i < TopRow.Length; i++)
                    {
                        foreach (var l in TopRow)
                        {
                            Console.Write(l.GetValue(i));
                        }

                        Console.WriteLine();

                    }
                    for (int i = 0; i < MidTopRow.Length; i++)
                    {
                        foreach (var l in MidTopRow)
                        {
                            Console.Write(l.GetValue(i));
                        }

                        Console.WriteLine();

                    }
                    for (int i = 0; i < MidBottomRow.Length; i++)
                    {
                        foreach (var l in MidBottomRow)
                        {
                            Console.Write(l.GetValue(i));
                        }

                        Console.WriteLine();

                    }
                    for (int i = 0; i < BottomRow.Length; i++)
                    {
                        foreach (var l in BottomRow)
                        {
                            Console.Write(l.GetValue(i));
                        }

                        Console.WriteLine();

                    }


            }

        }
        static void Main(string[] args)
        {
            
            Data.Initialize();
            Data.NextRace();
            Visualisatie.DrawTrack(Data.CurrentRace.track);

            for (; ; )
            {
                System.Threading.Thread.Sleep(100);
            }


        }
        
    }
}
