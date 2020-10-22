using NUnit.Framework;
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

        [Test]
        public void NextTrack_OneInQueue_ReturnTrack()
        {
            SectionTypes[] test = new SectionTypes[]
            {
                SectionTypes.StraightHorizontal,
                SectionTypes.StraightHorizontal,
                SectionTypes.StraightHorizontal,
            };

            Track track = new Track("Track 1", test);
            _competition.Tracks.Enqueue((track));
            var result = _competition.NextTrack();
            Assert.AreEqual(track,result);

        }

        [Test]
        public void NextTrack_OneInQueue_RemoveTrackFromQueue()
        {
            SectionTypes[] test = new SectionTypes[]
            {
                SectionTypes.StraightHorizontal,
                SectionTypes.StraightHorizontal,
                SectionTypes.StraightHorizontal,
            };
            Track track = new Track("Track 1", test);
            _competition.Tracks.Enqueue((track));
            var result = _competition.NextTrack();
            result = _competition.NextTrack();
            Assert.IsNull(result);
        }

        [Test]
        public void NextTrack_TwoInQueue_ReturnNextTrack()
        {
            SectionTypes[] test = new SectionTypes[]
            {
                SectionTypes.StraightHorizontal,
                SectionTypes.StraightHorizontal,
                SectionTypes.StraightHorizontal,
            };
            Track track = new Track("Track 1", test);
            Track track2 = new Track("Track 2", test);
            _competition.Tracks.Enqueue(track);
            _competition.Tracks.Enqueue(track2);
            var result = _competition.NextTrack();
            Assert.AreEqual(track, result);
            result = _competition.NextTrack();
            Assert.AreEqual(track2,result);

        }
    }
}
