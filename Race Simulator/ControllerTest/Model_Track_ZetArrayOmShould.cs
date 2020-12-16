using Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControllerTest
{
    [TestFixture]
    class Model_Track_ZetArrayOmShould
    {
        private Track track;

        [SetUp]
        public void SetUp()
        {
            SectionTypes[] test = new SectionTypes[]
            {
                SectionTypes.StartGridHorizontal, SectionTypes.FinishHorizontal, SectionTypes.WestSouth, SectionTypes.StraightVertical, SectionTypes.StraightVertical, SectionTypes.NorthWest, SectionTypes.StraightHorizontal,
                SectionTypes.StraightHorizontal, SectionTypes.EastNorth, SectionTypes.StraightVertical, SectionTypes.StraightVertical, SectionTypes.SouthEast
            };
            track = new Track("Test", test);
        }

        [Test]
        public void ZetArrayOm_EmptyLinkedList_ReturnEmpty()
        {
            var EmptyLinkedList = new SectionTypes[] { };
            var result = track.ZetArrayOm(EmptyLinkedList);
            Assert.IsEmpty(result);
        }

      
    }
}
