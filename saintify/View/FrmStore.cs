using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using saintify.Business;//Business Namespace to get easily access to business classes
using saintify.Data;//Data Namespace to get easily access to data classes

namespace saintify
{
    /// <summary>
    /// This class is designed to define a store form.
    /// </summary>
    public partial class FrmSaintify : Form
    {
        #region private attributs
        private List<Business.Artist> listOfArtists = null;
        private String currentDirectory = null;
        private String currentDirectoryImg = null;
        private String currentDirectoryData = null;
        private JsonConnector jsonConnector = null;
        #endregion private attributs

        /// <summary>
        /// This constructor initializes a new instance of the Saintify form class.
        /// </summary>
        public FrmSaintify()
        {
            InitializeComponent();
            this.currentDirectory = Directory.GetCurrentDirectory().Replace(@"bin\Debug", "");
            this.currentDirectoryImg = this.currentDirectory + @"img\";
            this.currentDirectoryData = this.currentDirectory + @"DBJson\";
        }

        #region private methods
        /// <summary>
        /// This method manages the load process of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSaintify_Load(object sender, EventArgs e)
        {
            //load Artists
            loadArtists();
        }

        /// <summary>
        /// This method manages the load process of the artists
        /// </summary>
        private void loadArtists()
        {
            this.jsonConnector = new JsonConnector(this.currentDirectoryData + "store.json");
            List<Artist> listOfArtists = this.jsonConnector.ListOfArtists();

            int counter = 0;
            if(listOfArtists != null)
            {
                foreach (Artist artist in listOfArtists)
                {
                    GenerateArtistGroupBox(artist.Name(), counter, artist.PictureName());
                    counter++;
                }
            }
        }

        /// <summary>
        /// This method generates artists visual components for the GUI.
        /// </summary>
        private void GenerateArtistGroupBox(String artistName, int artistNumber, String pictureName)
        {
            // 
            // picBArtist
            // 
            PictureBox picBArtist = new PictureBox();
            picBArtist.Image = Image.FromFile(this.currentDirectoryImg + pictureName);
            picBArtist.Location = new System.Drawing.Point(5, 15);
            picBArtist.Name = "PicBox" + artistName;
            picBArtist.Size = new System.Drawing.Size(260, 270);
            picBArtist.SizeMode = PictureBoxSizeMode.StretchImage;
            picBArtist.TabIndex = 0;
            picBArtist.TabStop = false;

            // 
            // grpBArtist
            // 
            GroupBox grpBArtist = new GroupBox();
            grpBArtist.Text = artistName;
            grpBArtist.ForeColor = Color.White;
            grpBArtist.Controls.Add(picBArtist);
            int xPosition = (grpBArtist.Size.Width + 80) * (artistNumber % 3);
            int yPosition = (grpBArtist.Size.Height + 200) * (artistNumber / 3);
            grpBArtist.Location = new System.Drawing.Point(xPosition, yPosition);
            grpBArtist.Name = "grpB" + artistName;
            grpBArtist.Size = new System.Drawing.Size(270, 290);
            grpBArtist.TabIndex = 0;
            grpBArtist.TabStop = false;

            //add Group Box Artist in the Store
            panStore.Controls.Add(grpBArtist);
        }
        #endregion private methods
    }
}
