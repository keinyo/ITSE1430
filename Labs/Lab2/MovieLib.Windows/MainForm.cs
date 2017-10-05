using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLib.Windows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void OnMoviesAdd( object sender, EventArgs e )
        {
            var child = new MovieDetailForm();
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //Save Movie
            _movie = child.Movie;
        }

        private void OnMoviesEdit( object sender, EventArgs e )
        {
            var child = new MovieDetailForm();
            child.Movie = _movie;
            //TODO: Add validation

            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //Save Movie
            _movie = child.Movie;
        }

        private void OnMoviesDelete( object sender, EventArgs e )
        {
            //If there is no movie, does nothing
            if (_movie == null)
                return;

            //Confirm Delete
            if ((MessageBox.Show(this, $"Are you sure you want to delete {_movie.Title}?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
                return;

            //Deletes Movie
            _movie = null;
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            var box = new AboutBox();
            box.ShowDialog();
        }

        private Movie _movie;
    }
}
