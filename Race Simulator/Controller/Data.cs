﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using Model;

namespace Controller
{
    public static class Data
    {
        public static Competition competitite;
        public static Track track;

        public static void Initialize()
        {
            competitite = new Competition();
            VoegDeelnemersToe();
            VoegTrackToe();

        }

        public static void VoegDeelnemersToe()
        {
            competitite.Participants.Add(new Driver());
        }

        public static void VoegTrackToe()
        {
            competitite.Tracks.Enqueue(new Track());

        }

    }
}
