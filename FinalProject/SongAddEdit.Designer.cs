namespace FinalProject
{
    partial class SongAddEdit
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.numericYear = new System.Windows.Forms.NumericUpDown();
            this.pictureboxAlbumArt = new System.Windows.Forms.PictureBox();
            this.btnChooseAlbumArt = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblLyrics = new System.Windows.Forms.Label();
            this.btnAddMp3 = new System.Windows.Forms.Button();
            this.txtDisplayMP3 = new System.Windows.Forms.TextBox();
            this.txtLyrics = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxAlbumArt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(15, 90);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(15, 119);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(44, 20);
            this.lblArtist.TabIndex = 1;
            this.lblArtist.Text = "Artist";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(15, 153);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(53, 20);
            this.lblAlbum.TabIndex = 2;
            this.lblAlbum.Text = "Album";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(17, 185);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(37, 20);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(148, 87);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(159, 27);
            this.txtTitle.TabIndex = 4;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(148, 119);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(159, 27);
            this.txtArtist.TabIndex = 5;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(148, 153);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(159, 27);
            this.txtAlbum.TabIndex = 6;
            // 
            // numericYear
            // 
            this.numericYear.Location = new System.Drawing.Point(148, 186);
            this.numericYear.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericYear.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.numericYear.Name = "numericYear";
            this.numericYear.Size = new System.Drawing.Size(150, 27);
            this.numericYear.TabIndex = 7;
            this.numericYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // pictureboxAlbumArt
            // 
            this.pictureboxAlbumArt.Location = new System.Drawing.Point(17, 248);
            this.pictureboxAlbumArt.Name = "pictureboxAlbumArt";
            this.pictureboxAlbumArt.Size = new System.Drawing.Size(183, 180);
            this.pictureboxAlbumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxAlbumArt.TabIndex = 8;
            this.pictureboxAlbumArt.TabStop = false;
            // 
            // btnChooseAlbumArt
            // 
            this.btnChooseAlbumArt.Location = new System.Drawing.Point(15, 449);
            this.btnChooseAlbumArt.Name = "btnChooseAlbumArt";
            this.btnChooseAlbumArt.Size = new System.Drawing.Size(184, 29);
            this.btnChooseAlbumArt.TabIndex = 9;
            this.btnChooseAlbumArt.Text = "Choose Album Art";
            this.btnChooseAlbumArt.UseVisualStyleBackColor = true;
            this.btnChooseAlbumArt.Click += new System.EventHandler(this.btnChooseAlbumArt_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(17, 484);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 29);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(348, 484);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 29);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(556, 484);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(183, 29);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLyrics
            // 
            this.lblLyrics.AutoSize = true;
            this.lblLyrics.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLyrics.Location = new System.Drawing.Point(507, 46);
            this.lblLyrics.Name = "lblLyrics";
            this.lblLyrics.Size = new System.Drawing.Size(76, 35);
            this.lblLyrics.TabIndex = 14;
            this.lblLyrics.Text = "Lyrics";
            // 
            // btnAddMp3
            // 
            this.btnAddMp3.Location = new System.Drawing.Point(12, 46);
            this.btnAddMp3.Name = "btnAddMp3";
            this.btnAddMp3.Size = new System.Drawing.Size(103, 29);
            this.btnAddMp3.TabIndex = 15;
            this.btnAddMp3.Text = "Choose Mp3";
            this.btnAddMp3.UseVisualStyleBackColor = true;
            this.btnAddMp3.Click += new System.EventHandler(this.btnAddMp3_Click);
            // 
            // txtDisplayMP3
            // 
            this.txtDisplayMP3.Location = new System.Drawing.Point(148, 48);
            this.txtDisplayMP3.Name = "txtDisplayMP3";
            this.txtDisplayMP3.ReadOnly = true;
            this.txtDisplayMP3.Size = new System.Drawing.Size(181, 27);
            this.txtDisplayMP3.TabIndex = 16;
            // 
            // txtLyrics
            // 
            this.txtLyrics.Location = new System.Drawing.Point(348, 90);
            this.txtLyrics.Multiline = true;
            this.txtLyrics.Name = "txtLyrics";
            this.txtLyrics.Size = new System.Drawing.Size(391, 373);
            this.txtLyrics.TabIndex = 17;
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnEdit.Location = new System.Drawing.Point(216, 484);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 29);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // SongAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 548);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtLyrics);
            this.Controls.Add(this.txtDisplayMP3);
            this.Controls.Add(this.btnAddMp3);
            this.Controls.Add(this.lblLyrics);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChooseAlbumArt);
            this.Controls.Add(this.pictureboxAlbumArt);
            this.Controls.Add(this.numericYear);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblTitle);
            this.Name = "SongAddEdit";
            this.Text = "AddEdit";
            this.Load += new System.EventHandler(this.SongAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxAlbumArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblArtist;
        private Label lblAlbum;
        private Label lblYear;
        private TextBox txtTitle;
        private TextBox txtArtist;
        private TextBox txtAlbum;
        private NumericUpDown numericYear;
        private PictureBox pictureboxAlbumArt;
        private Button btnChooseAlbumArt;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
        private Label lblLyrics;
        private Button btnAddMp3;
        private TextBox txtDisplayMP3;
        private TextBox txtLyrics;
        private Button btnEdit;
    }
}