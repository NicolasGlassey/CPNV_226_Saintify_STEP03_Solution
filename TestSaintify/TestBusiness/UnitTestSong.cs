using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace saintify.Business
{
    [TestClass]
    public class UnitTestSong
    {
        #region private attributes
        private Song song = null;
        private String expectedSongsTitle = "Song's Title";
        private int expectedSongsDuration = 23;
        #endregion private attributes

        /// <summary>
        /// This test method initializes variables and objects needed for the next test session.
        /// Run before each test method.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            song = new Song(this.expectedSongsTitle, this.expectedSongsDuration);
        }

        /// <summary>
        /// This test method is designed to test the Getter in charge to deliver the song's title
        /// </summary>
        [TestMethod]
        public void TestMethodGetterTitleSucess()
        {
            //given
            //please refer to Init() method
            String actualSongsTitle = "";

            //then
            actualSongsTitle = this.song.Title();

            //when
            Assert.AreEqual(this.expectedSongsTitle, actualSongsTitle);
        }

        /// <summary>
        /// This test method is designed to test the Getter in charge to deliver the song's duration
        /// </summary>
        [TestMethod]
        public void TestMethodGetterDurationSucess()
        {
            //given
            //please refer to Init() method
            int actualSongsDuration = -1;

            //then
            actualSongsDuration = this.song.Duration();

            //when
            Assert.AreEqual(this.expectedSongsDuration, actualSongsDuration);
        }

        /// <summary>
        /// This test method cleanup variables and objects used for the last test session.
        /// Run after each test method.
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {
            this.song = null;
        }
    }
}
