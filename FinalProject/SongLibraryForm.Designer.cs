namespace FinalProject
{
    partial class SongLibraryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMuseTitle = new System.Windows.Forms.Label();
            this.pictureBoxAlbumArt = new System.Windows.Forms.PictureBox();
            this.lblSongPlayingTitleWithArtist = new System.Windows.Forms.Label();
            this.btnPaginationLeft = new System.Windows.Forms.Button();
            this.pictureBoxDisplayedSong1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDisplayedSong2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDisplayedSong3 = new System.Windows.Forms.PictureBox();
            this.btnRestartSong = new System.Windows.Forms.Button();
            this.btnNextSong = new System.Windows.Forms.Button();
            this.btnPlayCurrentSong = new System.Windows.Forms.Button();
            this.btnPauseCurrentSong = new System.Windows.Forms.Button();
            this.pictureBoxDisplayedSong4 = new System.Windows.Forms.PictureBox();
            this.lblSong1LibraryDisplay = new System.Windows.Forms.Label();
            this.lblSong2LibraryDisplay = new System.Windows.Forms.Label();
            this.lblSong3LibraryDisplay = new System.Windows.Forms.Label();
            this.lblSong4LibraryDisplay = new System.Windows.Forms.Label();
            this.btnPaginationRight = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarCurrentSongPlaying = new System.Windows.Forms.ProgressBar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listViewSongs = new System.Windows.Forms.ListView();
            this.colTitle = new System.Windows.Forms.ColumnHeader();
            this.colArtist = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayedSong1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayedSong2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayedSong3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayedSong4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMuseTitle
            // 
            this.lblMuseTitle.AutoSize = true;
            this.lblMuseTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMuseTitle.Location = new System.Drawing.Point(93, 14);
            this.lblMuseTitle.Name = "lblMuseTitle";
            this.lblMuseTitle.Size = new System.Drawing.Size(98, 45);
            this.lblMuseTitle.TabIndex = 0;
            this.lblMuseTitle.Text = "Muse";
            // 
            // pictureBoxAlbumArt
            // 
            this.pictureBoxAlbumArt.Location = new System.Drawing.Point(195, 14);
            this.pictureBoxAlbumArt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxAlbumArt.Name = "pictureBoxAlbumArt";
            this.pictureBoxAlbumArt.Size = new System.Drawing.Size(72, 66);
            this.pictureBoxAlbumArt.TabIndex = 1;
            this.pictureBoxAlbumArt.TabStop = false;
            this.pictureBoxAlbumArt.Click += new System.EventHandler(this.pictureBoxAlbumArt_Click);
            // 
            // lblSongPlayingTitleWithArtist
            // 
            this.lblSongPlayingTitleWithArtist.AutoSize = true;
            this.lblSongPlayingTitleWithArtist.Location = new System.Drawing.Point(285, 14);
            this.lblSongPlayingTitleWithArtist.Name = "lblSongPlayingTitleWithArtist";
            this.lblSongPlayingTitleWithArtist.Size = new System.Drawing.Size(141, 15);
            this.lblSongPlayingTitleWithArtist.TabIndex = 2;
            this.lblSongPlayingTitleWithArtist.Text = "Press Play To Play a Song!";
            // 
            // btnPaginationLeft
            // 
            this.btnPaginationLeft.BackColor = System.Drawing.Color.White;
            this.btnPaginationLeft.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPaginationLeft.Location = new System.Drawing.Point(229, 139);
            this.btnPaginationLeft.Name = "btnPaginationLeft";
            this.btnPaginationLeft.Size = new System.Drawing.Size(72, 66);
            this.btnPaginationLeft.TabIndex = 3;
            this.btnPaginationLeft.Text = "<";
            this.btnPaginationLeft.UseVisualStyleBackColor = false;
            // 
            // pictureBoxDisplayedSong1
            // 
            this.pictureBoxDisplayedSong1.Location = new System.Drawing.Point(332, 139);
            this.pictureBoxDisplayedSong1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxDisplayedSong1.Name = "pictureBoxDisplayedSong1";
            this.pictureBoxDisplayedSong1.Size = new System.Drawing.Size(72, 66);
            this.pictureBoxDisplayedSong1.TabIndex = 6;
            this.pictureBoxDisplayedSong1.TabStop = false;
            // 
            // pictureBoxDisplayedSong2
            // 
            this.pictureBoxDisplayedSong2.Location = new System.Drawing.Point(429, 139);
            this.pictureBoxDisplayedSong2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxDisplayedSong2.Name = "pictureBoxDisplayedSong2";
            this.pictureBoxDisplayedSong2.Size = new System.Drawing.Size(72, 66);
            this.pictureBoxDisplayedSong2.TabIndex = 7;
            this.pictureBoxDisplayedSong2.TabStop = false;
            // 
            // pictureBoxDisplayedSong3
            // 
            this.pictureBoxDisplayedSong3.Location = new System.Drawing.Point(527, 139);
            this.pictureBoxDisplayedSong3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxDisplayedSong3.Name = "pictureBoxDisplayedSong3";
            this.pictureBoxDisplayedSong3.Size = new System.Drawing.Size(72, 66);
            this.pictureBoxDisplayedSong3.TabIndex = 8;
            this.pictureBoxDisplayedSong3.TabStop = false;
            // 
            // btnRestartSong
            // 
            this.btnRestartSong.Location = new System.Drawing.Point(285, 58);
            this.btnRestartSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestartSong.Name = "btnRestartSong";
            this.btnRestartSong.Size = new System.Drawing.Size(82, 22);
            this.btnRestartSong.TabIndex = 10;
            this.btnRestartSong.Text = "Restart";
            this.btnRestartSong.UseVisualStyleBackColor = true;
            // 
            // btnNextSong
            // 
            this.btnNextSong.Location = new System.Drawing.Point(572, 58);
            this.btnNextSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextSong.Name = "btnNextSong";
            this.btnNextSong.Size = new System.Drawing.Size(82, 22);
            this.btnNextSong.TabIndex = 11;
            this.btnNextSong.Text = "Next";
            this.btnNextSong.UseVisualStyleBackColor = true;
            // 
            // btnPlayCurrentSong
            // 
            this.btnPlayCurrentSong.Location = new System.Drawing.Point(373, 58);
            this.btnPlayCurrentSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayCurrentSong.Name = "btnPlayCurrentSong";
            this.btnPlayCurrentSong.Size = new System.Drawing.Size(82, 22);
            this.btnPlayCurrentSong.TabIndex = 12;
            this.btnPlayCurrentSong.Text = "Play";
            this.btnPlayCurrentSong.UseVisualStyleBackColor = true;
            // 
            // btnPauseCurrentSong
            // 
            this.btnPauseCurrentSong.Location = new System.Drawing.Point(485, 58);
            this.btnPauseCurrentSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPauseCurrentSong.Name = "btnPauseCurrentSong";
            this.btnPauseCurrentSong.Size = new System.Drawing.Size(82, 22);
            this.btnPauseCurrentSong.TabIndex = 13;
            this.btnPauseCurrentSong.Text = "Pause";
            this.btnPauseCurrentSong.UseVisualStyleBackColor = true;
            // 
            // pictureBoxDisplayedSong4
            // 
            this.pictureBoxDisplayedSong4.Location = new System.Drawing.Point(619, 139);
            this.pictureBoxDisplayedSong4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxDisplayedSong4.Name = "pictureBoxDisplayedSong4";
            this.pictureBoxDisplayedSong4.Size = new System.Drawing.Size(72, 66);
            this.pictureBoxDisplayedSong4.TabIndex = 14;
            this.pictureBoxDisplayedSong4.TabStop = false;
            // 
            // lblSong1LibraryDisplay
            // 
            this.lblSong1LibraryDisplay.AutoSize = true;
            this.lblSong1LibraryDisplay.Location = new System.Drawing.Point(343, 208);
            this.lblSong1LibraryDisplay.Name = "lblSong1LibraryDisplay";
            this.lblSong1LibraryDisplay.Size = new System.Drawing.Size(38, 15);
            this.lblSong1LibraryDisplay.TabIndex = 16;
            this.lblSong1LibraryDisplay.Text = "label1";
            // 
            // lblSong2LibraryDisplay
            // 
            this.lblSong2LibraryDisplay.AutoSize = true;
            this.lblSong2LibraryDisplay.Location = new System.Drawing.Point(437, 208);
            this.lblSong2LibraryDisplay.Name = "lblSong2LibraryDisplay";
            this.lblSong2LibraryDisplay.Size = new System.Drawing.Size(38, 15);
            this.lblSong2LibraryDisplay.TabIndex = 17;
            this.lblSong2LibraryDisplay.Text = "label2";
            // 
            // lblSong3LibraryDisplay
            // 
            this.lblSong3LibraryDisplay.AutoSize = true;
            this.lblSong3LibraryDisplay.Location = new System.Drawing.Point(541, 208);
            this.lblSong3LibraryDisplay.Name = "lblSong3LibraryDisplay";
            this.lblSong3LibraryDisplay.Size = new System.Drawing.Size(38, 15);
            this.lblSong3LibraryDisplay.TabIndex = 18;
            this.lblSong3LibraryDisplay.Text = "label3";
            // 
            // lblSong4LibraryDisplay
            // 
            this.lblSong4LibraryDisplay.AutoSize = true;
            this.lblSong4LibraryDisplay.Location = new System.Drawing.Point(634, 208);
            this.lblSong4LibraryDisplay.Name = "lblSong4LibraryDisplay";
            this.lblSong4LibraryDisplay.Size = new System.Drawing.Size(38, 15);
            this.lblSong4LibraryDisplay.TabIndex = 19;
            this.lblSong4LibraryDisplay.Text = "label4";
            // 
            // btnPaginationRight
            // 
            this.btnPaginationRight.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPaginationRight.Location = new System.Drawing.Point(717, 139);
            this.btnPaginationRight.Name = "btnPaginationRight";
            this.btnPaginationRight.Size = new System.Drawing.Size(72, 66);
            this.btnPaginationRight.TabIndex = 20;
            this.btnPaginationRight.Text = ">";
            this.btnPaginationRight.UseVisualStyleBackColor = true;
            // 
            // btnAddSong
            // 
            this.btnAddSong.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddSong.Location = new System.Drawing.Point(142, 139);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(72, 66);
            this.btnAddSong.TabIndex = 3;
            this.btnAddSong.Text = "+";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(142, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Song";
            // 
            // progressBarCurrentSongPlaying
            // 
            this.progressBarCurrentSongPlaying.Location = new System.Drawing.Point(285, 42);
            this.progressBarCurrentSongPlaying.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarCurrentSongPlaying.Name = "progressBarCurrentSongPlaying";
            this.progressBarCurrentSongPlaying.Size = new System.Drawing.Size(369, 12);
            this.progressBarCurrentSongPlaying.TabIndex = 21;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(100, 100);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listViewSongs
            // 
            this.listViewSongs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTitle,
            this.colArtist});
            this.listViewSongs.GridLines = true;
            this.listViewSongs.Location = new System.Drawing.Point(12, 236);
            this.listViewSongs.Name = "listViewSongs";
            this.listViewSongs.Size = new System.Drawing.Size(289, 154);
            this.listViewSongs.StateImageList = this.imageList1;
            this.listViewSongs.TabIndex = 23;
            this.listViewSongs.UseCompatibleStateImageBehavior = false;
            this.listViewSongs.View = System.Windows.Forms.View.Details;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Title";
            // 
            // colArtist
            // 
            this.colArtist.Text = "Artist";
            // 
            // SongLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 402);
            this.Controls.Add(this.listViewSongs);
            this.Controls.Add(this.progressBarCurrentSongPlaying);
            this.Controls.Add(this.btnPaginationRight);
            this.Controls.Add(this.lblSong4LibraryDisplay);
            this.Controls.Add(this.lblSong3LibraryDisplay);
            this.Controls.Add(this.lblSong2LibraryDisplay);
            this.Controls.Add(this.lblSong1LibraryDisplay);
            this.Controls.Add(this.pictureBoxDisplayedSong4);
            this.Controls.Add(this.btnPauseCurrentSong);
            this.Controls.Add(this.btnPlayCurrentSong);
            this.Controls.Add(this.btnNextSong);
            this.Controls.Add(this.btnRestartSong);
            this.Controls.Add(this.pictureBoxDisplayedSong3);
            this.Controls.Add(this.pictureBoxDisplayedSong2);
            this.Controls.Add(this.pictureBoxDisplayedSong1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.btnPaginationLeft);
            this.Controls.Add(this.lblSongPlayingTitleWithArtist);
            this.Controls.Add(this.pictureBoxAlbumArt);
            this.Controls.Add(this.lblMuseTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SongLibraryForm";
            this.Text = "Muse";
            this.Load += new System.EventHandler(this.SongLibraryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayedSong1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayedSong2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayedSong3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayedSong4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMuseTitle;
        private PictureBox pictureBoxAlbumArt;
        private Label lblSongPlayingTitleWithArtist;
        private Button btnPaginationLeft;
        private PictureBox pictureBoxDisplayedSong1;
        private PictureBox pictureBoxDisplayedSong2;
        private PictureBox pictureBoxDisplayedSong3;
        private Button btnRestartSong;
        private Button btnNextSong;
        private Button btnPlayCurrentSong;
        private Button btnPauseCurrentSong;
        private PictureBox pictureBoxDisplayedSong4;
        private Label lblSong1LibraryDisplay;
        private Label lblSong2LibraryDisplay;
        private Label lblSong3LibraryDisplay;
        private Label lblSong4LibraryDisplay;
        private Button btnPaginationRight;
        private Button btnAddSong;
        private Label label1;
        private ProgressBar progressBarCurrentSongPlaying;
        private ImageList imageList1;
        private ListView listViewSongs;
        private ColumnHeader colTitle;
        private ColumnHeader colArtist;
    }
}