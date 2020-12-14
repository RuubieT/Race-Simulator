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
                SectionTypes.StartGridHorizontal, SectionTypes.FinishHorizontal, SectionTypes.WestZuid, SectionTypes.StraightVertical, SectionTypes.StraightVertical, SectionTypes.NoordWest, SectionTypes.StraightHorizontal,
                SectionTypes.StraightHorizontal, SectionTypes.OostNoord, SectionTypes.StraightVertical, SectionTypes.StraightVertical, SectionTypes.ZuidOost
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
