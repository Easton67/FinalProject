using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using DataObjects;

namespace FinalProject
{
    public partial class SongLibraryForm : Form
    {
        private SongListManipulator _songListManipulator = new SongListManipulator();

        public SongLibraryForm()
        {
            InitializeComponent();
        }

        private void SongLibraryForm_Load(object sender, EventArgs e)
        {
            libraryView();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            var AddEditForm = new SongAddEdit();
            AddEditForm.ShowDialog();
            _songListManipulator = new SongListManipulator();
            libraryView();
        }

        private void pictureBoxAlbumArt_Click(object sender, EventArgs e)
        {

        }

        private void libraryView()
        {
            listViewSongs.Items.Clear();
            for (int i = 0; i < _songListManipulator.SongList.Count; i++)
            {
                this.listViewSongs.Items.Add(_songListManipulator.SongList[i].Title);
                this.listViewSongs.Items[this.listViewSongs.Items.Count - 1].SubItems.Add(_songListManipulator.SongList[i].Album);
            }

            if (false)
            {
                btnPaginationLeft.Visible = true;
                btnPaginationRight.Visible = true;
            }

            btnPaginationLeft.Visible = false;
            btnPaginationRight.Visible = false;

            lblSong1LibraryDisplay.Text = "";
            lblSong2LibraryDisplay.Text = "";
            lblSong3LibraryDisplay.Text = "";
            lblSong4LibraryDisplay.Text = "";
            lblSong4LibraryDisplay.Text = "";

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Works");
        }
    }
}