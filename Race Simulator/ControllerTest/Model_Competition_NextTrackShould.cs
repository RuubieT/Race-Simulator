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
            SectionTypes[] sections1 = new SectionTypes[]
            {
                SectionTypes.Straight,
                SectionTypes.LeftCorner,
                SectionTypes.RightCorner,
                SectionTypes.StartGrid,
                SectionTypes.Finish
            };
            Track track = new Track("Track 1", sections1);
            _competition.Tracks.Enqueue((track));
            var result = _competition.NextTrack();
            Assert.AreEqual(track,result);

        }

        [Test]
        public void NextTrack_OneInQueue_RemoveTrackFromQueue()
        {
            SectionTypes[] sections1 = new SectionTypes[]
            {
                SectionTypes.Straight,
                SectionTypes.LeftCorner,
                SectionTypes.RightCorner,
                SectionTypes.StartGrid,
                SectionTypes.Finish
            };
            Track track = new Track("Track 1", sections1);
            _competition.Tracks.Enqueue((track));
            var result = _competition.NextTrack();
            result = _competition.NextTrack();
            Assert.IsNull(result);
        }

        [Test]
        public void NextTrack_TwoInQueue_ReturnNextTrack()
        {
            SectionTypes[] sections1 = new SectionTypes[]
            {
                SectionTypes.Straight,
                SectionTypes.LeftCorner,
                SectionTypes.RightCorner,
                SectionTypes.StartGrid,
                SectionTypes.Finish
            };
            Track track = new Track("Track 1", sections1);
            Track track2 = new Track("Track 2", sections1);
            _competition.Tracks.Enqueue(track);
            _competition.Tracks.Enqueue(track2);
            var result = _competition.NextTrack();
            Assert.AreEqual(track, result);
            result = _competition.NextTrack();
            Assert.AreEqual(track2,result);

        }
    }
}
