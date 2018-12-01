using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saintify.Business
{
    /// <summary>
    /// This class is designed to define a song.
    /// </summary>
    public class Song
    {
        #region private attributes
        private String title = "";//Song's title
        private int duration = 0;//Song's duration in seconds
        #endregion private attributes

        #region constuctors
        /// <summary>
        /// This constructor initializes a new instance of the Song class.
        /// </summary>
        /// <param name="title">Song's title as a String</param>
        /// <param name="duration">Song's duration in seconds as an integer</param>
        public Song (String title, int duration)
        {
            this.title = title;
            this.duration = duration;
        }
        #endregion constructors

        #region public methods
        #region getters and setters
        /// <summary>
        /// This getter provides the value of the private attribut "title" 
        /// </summary>
        /// <returns>The song's title</returns>
        public String Title()
        {
            return this.title;
        }

        /// <summary>
        /// This getter provides the value of the private attribut "duration"
        /// </summary>
        /// <returns>The song's duration in seconds</returns>
        public int Duration()
        {
            return this.duration;
        }
        #endregion getters and setters
        #endregion public methods 
    }
}
