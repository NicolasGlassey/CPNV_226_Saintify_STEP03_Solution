using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saintify.Business
{
    /// <summary>
    /// This class is designed to define an artist
    /// </summary>
    public class Artist
    {
        #region private attributes
        private int id = -1;//artist's id
        private String pictureName = "";//artist's picture's file name (see application ressources.resx)
        private String name = "";//artist's name
        private List<Song> listOfSongs = null;//list of the artist's songs 
        #endregion private attributes

        #region constructors
        /// <summary>
        /// This constructor initializes a new instance of the artist class.
        /// </summary>
        /// <param name="id">The artist'id</param>
        /// <param name="pictureName">The artist's picture (see application ressources.resx</param>
        /// <param name="name">The artist's name</param>
        /// <param name="listOfSongs">The list of artist's songs</param>
        public Artist (int id, String pictureName, String name, List<Song> listOfSongs)
        {
            this.id = id;
            this.pictureName = pictureName;
            this.name = name;
            this.listOfSongs = listOfSongs;
        }
        #endregion constructors

        #region public methods
        #region getters and setters
        /// <summary>
        /// This getter delivers the value of the private attribut "id" 
        /// </summary>
        /// <returns>The artist's id</returns>
        public int Id()
        {
            return this.id;
        }


        /// <summary>
        /// This getter delivers the value of the private attribut "title" 
        /// </summary>
        /// <returns>The artist's picture's file name (see application ressources.resx)</returns>
        public String PictureName()
        {
            return this.pictureName;
        }

        /// <summary>
        /// This getter delivers the value of the private attribut "name" 
        /// </summary>
        /// <returns>The artist's name</returns>
        public String Name()
        {
            return this.name;
        }

        /// <summary>
        /// This getter delivers the list of Songs
        /// </summary>
        /// <returns>All songs performed by the artists</returns>
        public List<Song> ListOfSongs()
        {
            return this.listOfSongs;
        }

        /// <summary>
        /// This method allows to add a song
        /// </summary>
        /// <param name="songToAdd">an object song to add to the list of existing song</param>
        public void AddSong (Song songToAdd)
        {
            if (songToAdd != null)
            {
                if (songToAdd.Title() != "" == songToAdd.Duration() > 0)
                {
                    if (!SongExists(songToAdd))
                    {
                        this.listOfSongs.Add(songToAdd);
                    }
                }

            }
        }

        /// <summary>
        /// This method allows to add a song
        /// </summary>
        /// <param name="songToAdd">The song to be added</param>
        public void AddSong(List<Song> listOfSongsToAdd)
        {
            if (listOfSongsToAdd != null)
            {
                foreach (Song song in listOfSongsToAdd)
                {
                    this.AddSong(song);
                }
            }
        }
        #endregion getters and setters

        #region private
        /// <summary>
        /// This method prevents duplicate (when adding a song for the second time)
        /// </summary>
        /// <param name="songToCheck">The song to be added</param>
        /// <returns></returns>
        private bool SongExists(Song songToCheck)
        {
            bool exists = false;

            foreach (Song song in this.listOfSongs)
            {
                if (song.Title() == songToCheck.Title())
                {
                    exists = true;
                }
            }
            return exists;
        }

        /// <summary>
        /// This method prevents adding "null" song
        /// </summary>
        /// <param name="songToCheck">The song to be added</param>
        /// <returns></returns>
        private bool SongNotNull(Song songToCheck)
        {
            bool songNotEmpty = true;

            foreach (Song song in this.listOfSongs)
            {
                if (song != null)
                {
                    if (song.Title() != "")
                    {
                        songNotEmpty = true;
                    }
                }
            }
            return songNotEmpty;
        }
        #endregion private
        #endregion public methods


    }
}
