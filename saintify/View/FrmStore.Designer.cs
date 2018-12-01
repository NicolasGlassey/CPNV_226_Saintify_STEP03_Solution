namespace saintify
{
    partial class FrmSaintify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaintify));
            this.cBoxPlaylistSelection = new System.Windows.Forms.ComboBox();
            this.grpBPlaylist = new System.Windows.Forms.GroupBox();
            this.grpBoxStore = new System.Windows.Forms.GroupBox();
            this.panStore = new System.Windows.Forms.Panel();
            this.grpBPlaylist.SuspendLayout();
            this.grpBoxStore.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBoxPlaylistSelection
            // 
            this.cBoxPlaylistSelection.FormattingEnabled = true;
            this.cBoxPlaylistSelection.Location = new System.Drawing.Point(20, 32);
            this.cBoxPlaylistSelection.Name = "cBoxPlaylistSelection";
            this.cBoxPlaylistSelection.Size = new System.Drawing.Size(121, 21);
            this.cBoxPlaylistSelection.TabIndex = 0;
            // 
            // grpBPlaylist
            // 
            this.grpBPlaylist.Controls.Add(this.cBoxPlaylistSelection);
            this.grpBPlaylist.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpBPlaylist.Location = new System.Drawing.Point(920, 24);
            this.grpBPlaylist.Name = "grpBPlaylist";
            this.grpBPlaylist.Size = new System.Drawing.Size(200, 72);
            this.grpBPlaylist.TabIndex = 1;
            this.grpBPlaylist.TabStop = false;
            this.grpBPlaylist.Text = "Playlists";
            // 
            // grpBoxStore
            // 
            this.grpBoxStore.Controls.Add(this.panStore);
            this.grpBoxStore.ForeColor = System.Drawing.Color.Gray;
            this.grpBoxStore.Location = new System.Drawing.Point(13, 12);
            this.grpBoxStore.Name = "grpBoxStore";
            this.grpBoxStore.Size = new System.Drawing.Size(886, 349);
            this.grpBoxStore.TabIndex = 3;
            this.grpBoxStore.TabStop = false;
            this.grpBoxStore.Text = "Store";
            // 
            // panStore
            // 
            this.panStore.AutoScroll = true;
            this.panStore.Location = new System.Drawing.Point(14, 19);
            this.panStore.Name = "panStore";
            this.panStore.Size = new System.Drawing.Size(866, 310);
            this.panStore.TabIndex = 0;
            // 
            // FrmSaintify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(911, 374);
            this.Controls.Add(this.grpBoxStore);
            this.Controls.Add(this.grpBPlaylist);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSaintify";
            this.Text = "Saintify";
            this.Load += new System.EventHandler(this.FrmSaintify_Load);
            this.grpBPlaylist.ResumeLayout(false);
            this.grpBoxStore.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxPlaylistSelection;
        private System.Windows.Forms.GroupBox grpBPlaylist;
        private System.Windows.Forms.GroupBox grpBoxStore;
        private System.Windows.Forms.Panel panStore;
    }
}

