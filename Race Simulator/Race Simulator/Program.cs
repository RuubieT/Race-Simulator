using System;
using Controller;
using Model;


namespace Race_Simulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Data.Initialize();
            Data.NextRace();

            
            Console.WriteLine(Data.CurrentRace.track.Name);
            for (; ; )
            {
                System.Threading.Thread.Sleep(100);
            }


        }
        
    }
}
