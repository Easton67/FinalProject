using LogicLayer;
using DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FinalProject
{
    public partial class SongAddEdit : Form
    {
        bool editMode;
        string Mp3FileName = "";
        string AlbumFileName = "";
        string albumArtDataPath = Application.StartupPath + @"\albumart";
        string mp3DataPath = Application.StartupPath + @"\songfiles";
        string defaultDataPath = Application.StartupPath;

        SongListManipulator _songListManipulator;
        int _songIndex;

        public SongAddEdit()
        {
            editMode = false;
            _songListManipulator = new SongListManipulator();
            InitializeComponent();
        }

        public SongAddEdit(int songIndex, SongListManipulator songListManipulator)
        {
            editMode = true;
            _songListManipulator = new SongListManipulator();
            InitializeComponent();
        }
        private void SongAddEdit_Load(object sender, EventArgs e)
        {
            if (editMode == true)
            {
                this.txtTitle.Text = _songListManipulator.SongList[_songIndex].Title;
                this.txtAlbum.Text = _songListManipulator.SongList[_songIndex].Album;
                this.txtDisplayMP3.Text = _songListManipulator.SongList[_songIndex].Mp3FileName;

                AlbumFileName = _songListManipulator.SongList[_songIndex].AlbumArtFileName;
                pictureboxAlbumArt.Image = Image.FromFile(albumArtDataPath + @"\" + AlbumFileName);

                this.Text = "Edit a Song";
            }
            else
            {
                this.Text = "Add a Song";
            }
        }

        private void btnAddMp3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdMp3 = new OpenFileDialog();
            ofdMp3.FileName = "";
            ofdMp3.Multiselect = false;

            ofdMp3.Filter = "Mp3 files (*.mp3)|*.mp3";

            ofdMp3.InitialDirectory = defaultDataPath;
            ofdMp3.ShowDialog(this);

            if (ofdMp3.FileName != null && ofdMp3.FileName != "")
            {
                txtDisplayMP3.Text = ofdMp3.SafeFileName;

                Mp3FileName = ofdMp3.SafeFileName;
            }
        }

        private void btnChooseAlbumArt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdAlbum = new OpenFileDialog();
            ofdAlbum.FileName = "";
            ofdAlbum.Multiselect = false;

            ofdAlbum.Filter = "Png files (*.png)|*.png";

            ofdAlbum.InitialDirectory = defaultDataPath;
            ofdAlbum.ShowDialog(this);

            if (ofdAlbum.FileName != null && ofdAlbum.FileName != "")
            {
                pictureboxAlbumArt.Image = Image.FromFile(ofdAlbum.FileName);

                AlbumFileName = ofdAlbum.SafeFileName;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtDisplayMP3.Text == "")
            {
                MessageBox.Show("You Must Enter an Mp3 Song File");
                txtDisplayMP3.Focus();
                return;
            }

            if (txtTitle.Text == "")
            {
                txtTitle.Text = "Unknown";
            }

            if (txtArtist.Text == "")
            {
                // Applications like Apple Music will enter these fields as 
                // "unknown", so instead of not letting you enter the song, I 
                // use this point to set default values if nothing is entered

                txtArtist.Text = "Unknown"; 
            }

            if (txtAlbum.Text == "")
            {
                txtAlbum.Text = "Unknown";
            }

            if (txtLyrics.Text == "")
            {
                txtLyrics.Text = "No Lyrics Provided";
            }

            if (lblLyrics.Text != "Lyics")
            {
                lblLyrics.Text = txtTitle.Text;
            }

            var song = new Song();
            song.Mp3FileName = txtDisplayMP3.Text;
            song.Title = txtTitle.Text;
            song.Artist = txtArtist.Text;
            song.Album = txtAlbum.Text;
            song.AlbumArtFileName = AlbumFileName;
            song.Year = numericYear.Value.ToString();

            var lyrics = new Lyrics();
            lyrics.Title = txtLyrics.Text;
            if (editMode == true)                               
            {
                _songListManipulator.EditSong(song, lyrics, _songIndex);
                this.Close();
            }
            else                                                
            {
                int songCount = _songListManipulator.SongList.Count;
                var newSongList = _songListManipulator.AddSong(song, lyrics);

                this.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editMode = true;
        }
    }
}
