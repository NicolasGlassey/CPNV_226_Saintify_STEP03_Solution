using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace saintify.Business
{
    [TestClass]
    public class UnitTestArtist
    {

        #region private attributes
        private Artist artist = null;
        private int expectedArtistId = -1;
        private String expectedArtistName = "Artist's Name";
        private String expectedArtistPictureName = "Artist's picture name";
        private List<Song> expectedArtistListOfSongs = null;
        #endregion private attributes

        /// <summary>
        /// This test method initializes variables and objects needed for the next test session.
        /// Run before each test method.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            this.expectedArtistId = 1;
            this.expectedArtistListOfSongs = new List<Song>();
            for (int i = 0; i < 10; i++ )
            {
                Song song = new Song("Song" + i.ToString(), i+60);
                this.expectedArtistListOfSongs.Add(song);
            }
            artist = new Artist(this.expectedArtistId, this.expectedArtistPictureName, this.expectedArtistName,this.expectedArtistListOfSongs);
        }

        /// <summary>
        /// This test method is designed to test the Getter in charge to deliver the artist's id
        /// </summary>
        [TestMethod]
        public void TestMethodGetterArtistIDSucess()
        {
            //given
            //please refer to Init() method
            int actualArtistId = -1;

            //then
            actualArtistId = this.artist.Id();

            //when
            Assert.AreEqual(this.expectedArtistId, actualArtistId);
        }

        /// <summary>
        /// This test method is designed to test the Getter in charge to deliver the artist's picutre's name
        /// </summary>
        [TestMethod]
        public void TestMethodGetterActistPictureNameSucess()
        {
            //given
            //please refer to Init() method
            String actualArtistPictureName = "";

            //then
            actualArtistPictureName = this.artist.PictureName();

            //when
            Assert.AreEqual(this.expectedArtistPictureName, actualArtistPictureName);
        }

        /// <summary>
        /// This test method is designed to test the Getter in charge to deliver the artist's name
        /// </summary>
        [TestMethod]
        public void TestMethodGetterArtistNameSucess()
        {
            //given
            //please refer to Init() method
            String actualArtistName = "";

            //then
            actualArtistName = this.artist.Name();

            //when
            Assert.AreEqual(this.expectedArtistName, actualArtistName);
        }

        /// <summary>
        /// This test method is designed to test the method allowing to add a single song
        /// </summary>
        [TestMethod]
        public void TestMethodAddSongSucess()
        {
            //given
            //please refer to Init() method
            Song songToAdd = new Song("TitleToAdd", 120);
            int expectedAmountOfSongs = 11;
            int actualAmountOfSongs = -1;

            //then
            this.artist.AddSong(songToAdd);
            actualAmountOfSongs = this.artist.ListOfSongs().Count;

            //when
            Assert.AreEqual(expectedAmountOfSongs, actualAmountOfSongs);
        }

        /// <summary>
        /// This test method is designed to test the method allowing to add a single song
        /// In this case, one of songs to add is "null" and must be rejected.
        /// </summary>
        [TestMethod]
        public void TestMethodAddSongFail()
        {
            //given
            //please refer to Init() method
            Song songNullToAdd = null;
            Song songNotNullToAdd = new Song("SongNotNull", 12);
            int expectedAmountOfSongs = 11;
            int actualAmountOfSongs = -1;

            //then
            this.artist.AddSong(songNullToAdd);
            this.artist.AddSong(songNotNullToAdd);
            actualAmountOfSongs = this.artist.ListOfSongs().Count;

            //when
            Assert.AreEqual(expectedAmountOfSongs, actualAmountOfSongs);
        }

        /// <summary>
        /// This test method is designed to test the method allowing to add a list of songs
        /// </summary>
        [TestMethod]
        public void TestMethodAddListOfSongsSucess()
        {
            //given
            //please refer to Init() method
            List<Song> listOfSongsToAdd = new List<Song>();
            for (int i = 0; i < 10; i++)
            {
                Song song = new Song("SongToAdd" + i.ToString(), i + 60);
                listOfSongsToAdd.Add(song);
            }
            int expectedAmountOfSongs = 20;
            int actualAmountOfSongs = -1;

            //then
            this.artist.AddSong(listOfSongsToAdd);
            actualAmountOfSongs = this.artist.ListOfSongs().Count;

            //when
            Assert.AreEqual(expectedAmountOfSongs, actualAmountOfSongs);
        }

        /// <summary>
        /// This test method is designed to test the method allowing to add a list of songs
        /// In this case, the list of song is "null" and must be rejected.
        /// </summary>
        [TestMethod]
        public void TestMethodAddListOfSongsFail()
        {
            //given
            //please refer to Init() method
            List<Song> listOfSongsToAddNull = null;
            Song songToAdd = new Song("Song to add", 12);
            List<Song> listOfSongToAddNotNull = new List<Song>();
            listOfSongToAddNotNull.Add(songToAdd);

            int expectedAmountOfSongs = 11;
            int actualAmountOfSongs = -1;

            //then
            this.artist.AddSong(listOfSongsToAddNull);
            this.artist.AddSong(listOfSongToAddNotNull);
            actualAmountOfSongs = this.artist.ListOfSongs().Count;

            //when
            Assert.AreEqual(expectedAmountOfSongs, actualAmountOfSongs);
        }

        /// <summary>
        /// This test method is designed to test the method allowing to add a list of songs
        /// In this case, the list of song contains a "null" song.
        /// Only the "null" song must be rejected. The others must be added.
        /// </summary>
        [TestMethod]
        public void TestMethodAddListOfSongsRejectNullSongSuccess()
        {
            //given
            //please refer to Init() method
            List<Song> listOfSongsToAdd = new List<Song>();
            for (int i = 0; i < 10; i++)
            {
                Song song = new Song("SongToAdd" + i.ToString(), i + 60);
                listOfSongsToAdd.Add(song);
            }
            Song emptySong = null;
            listOfSongsToAdd.Add(emptySong);//11th songs, must be rejected

            int expectedAmountOfSongs = 20;
            int actualAmountOfSongs = -1;

            //then
            this.artist.AddSong(listOfSongsToAdd);
            actualAmountOfSongs = this.artist.ListOfSongs().Count;

            //when
            Assert.AreEqual(expectedAmountOfSongs, actualAmountOfSongs);
        }

        /// <summary>
        /// This test method cleanup variables and objects used for the last test session.
        /// Run after each test method.
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {
            this.artist = null;
        }
    }
}
