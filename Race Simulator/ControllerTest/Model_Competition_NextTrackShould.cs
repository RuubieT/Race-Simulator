﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace ControllerTest
{
    [TestFixture]
    public class Model_Competition_NextTrackShould
    {
        private Competition _competition;

        [SetUp]
        public void Setup()
        {
            
            _competition = new Competition();

        }

        [Test]
        public void NextTrack_EmptyQueue_ReturnNull()
        {
            var result = _competition.NextTrack();
            Assert.IsNull(result);

        }

    }
}
