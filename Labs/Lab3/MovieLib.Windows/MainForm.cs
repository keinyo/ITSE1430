/*
 * Jacob Lanham
 * ITSE 1430
 * 10-29-2017
 */
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

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            _gridMovies.AutoGenerateColumns = false;

            UpdateList();
        }

        private Movie GetSelectedMovie ()
        {
            if (_gridMovies.SelectedRows.Count > 0)
                return _gridMovies.SelectedRows[0].DataBoundItem as Movie;

            return null;
        }

        private void UpdateList ()
        {
            _bsMovies.DataSource = _database.GetAll().ToList();
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
            _database.Add(child.Movie);
            UpdateList();
        }

        private void OnMovieEdit( object sender, EventArgs e )
        {
            var movie = GetSelectedMovie();

            //If there is no movie, show error dialog.
            if (movie == null)
            {
                MessageBox.Show(this, "No movie to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EditMovie(movie);
        }

        private void EditMovie(Movie movie)
        {
            var child = new MovieDetailForm();
            child.Movie = movie;

            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //Save Movie
            _database.Update(child.Movie);
            UpdateList();
        }

        private void OnMoviesDelete( object sender, EventArgs e )
        {
            var movie = GetSelectedMovie();
            //If there is no movie, show error dialog.
            if (movie == null)
            {
                MessageBox.Show(this, "No movie to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DeleteMovie(movie);
        }

        private void DeleteMovie(Movie movie)
        {
            //Confirm Delete
            if ((MessageBox.Show(this, $"Are you sure you want to delete {movie.Title}?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
                return;

            //Deletes Movie
            _database.Remove(movie.Id);
            UpdateList();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            var box = new AboutBox();
            box.ShowDialog();
        }

        private void OnKeyDownGrid( object sender, KeyEventArgs e )
        {
            var movie = GetSelectedMovie();
            if (e.KeyCode == Keys.Delete && movie != null)
                DeleteMovie(movie);
            else if (e.KeyCode == Keys.Enter && movie != null)
                EditMovie(movie);

            e.SuppressKeyPress = true;
        }

        private void OnEditRow( object sender, DataGridViewCellEventArgs e )
        {
            var grid = sender as DataGridView;

            //Handle column clicks
            if (e.RowIndex < 0)
                return;

            var row = grid.Rows[e.RowIndex];
            var item = row.DataBoundItem as Movie;

            if (item != null)
                EditMovie(item);
        }

        private IMovieDatabase _database = new MovieLib.Data.Memory.MemoryMovieDatabase();
    }
}
