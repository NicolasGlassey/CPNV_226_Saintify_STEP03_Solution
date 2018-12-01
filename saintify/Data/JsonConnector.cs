using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using saintify.Business;//Business Namespace to get easily access to business classes
using Newtonsoft.Json;//To manage JSON Content
using System.IO;//To manager files

namespace saintify.Data
{
    /// <summary>
    /// This class is designed to manage JSON File
    /// </summary>
    public class JsonConnector
    {
        #region private attributes
        private String jsonFileName = "";
        private List<Artist> listOfArtists;
        #endregion private attributes

        #region constructors
        /// <summary>
        /// This constructor initializes a new instance of the artist class.
        /// </summary>
        /// <param name="jsonFileName">File Name containing the json string</param>
        public JsonConnector (String jsonFileName)
        {
            this.jsonFileName = jsonFileName;
            this.listOfArtists = ReadJsonFile();
        }
        #endregion constructors

        #region private methods
        /// <summary>
        /// This method is designed to extrat from file json content and convert it in artist object
        /// </summary>
        /// <returns>A list of artists extracted from Json File</returns>
        private List<Artist> ReadJsonFile()
        {
            StreamReader strReader = new StreamReader(jsonFileName);
            String jsonFileContent = "";
            List<Artist> listOfArtists = null;
            if (File.Exists(jsonFileName))
            {
                try
                {
                    jsonFileContent = strReader.ReadToEnd();
                    if (jsonFileContent != null)
                    {
                        try
                        {
                            listOfArtists = new List<Artist>();
                            listOfArtists = JsonConvert.DeserializeObject<List<Artist>>(jsonFileContent);
                            //remove duplicate
                            listOfArtists = UnduplicateArtists(listOfArtists);
                        }
                        catch (JsonReaderException ex)
                        {
                            listOfArtists = null;
                        }
                    }
                }
                finally
                {
                    strReader.Close();
                }
            }

            return listOfArtists;
        }

        /// <summary>
        /// This method is designed to detect and remove duplicated artist
        /// A duplicate is either artists with the same id and list of songs or same id but with a different list of song
        /// If the list of song is differents, the function will merge all songs, avoiding duplicate.
        /// </summary>
        /// <param name="listOfArtistsToCheck"></param>
        /// <returns></returns>
        private List<Artist> UnduplicateArtists(List<Artist> listOfArtistsToCheck)
        {
            List<Artist> listOfArtistsChecked = new List<Artist>();
            Artist artistToAdd = null;

            foreach (Artist artistToCheck in listOfArtistsToCheck)
            {
                //we add the first artist if the list is empty
                if (listOfArtistsChecked.Count == 0)
                {
                    listOfArtistsChecked.Add(artistToCheck);
                }
                //we try to find the same artist in the existing "checked" list of artists
                foreach (Artist artistChecked in listOfArtistsChecked)
                {
                    //if its exits, we add only songs not yet present
                    if (artistToCheck.Id() == artistChecked.Id())
                    {
                        //we add to the existing artist the list of songs
                        artistChecked.AddSong(artistToCheck.ListOfSongs());
                    }
                    else
                    {
                        artistToAdd = artistToCheck;
                    }
                }
                if (artistToAdd != null)
                {
                    listOfArtistsChecked.Add(artistToAdd);
                }
            }
            return listOfArtistsChecked;
        }
        #endregion private methods

        #region public methods
        #region getters and setters
        /// <summary>
        /// This 
        /// </summary>
        /// <returns></returns>
        public List<Artist> ListOfArtists()
        {
            return this.listOfArtists; 
        }
        #endregion getters and setters
        #endregion public methods
    }
}
