/*
 * Jacob Lanham
 * ITSE 1430
 * 11-23-2017
 */
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

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

            var connString = ConfigurationManager.ConnectionStrings["MovieDatabase"].ConnectionString;

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
            try
            {
                _bsMovies.DataSource = _database.GetAll().ToList();
            }catch(Exception e)
            {
                DisplayError(e, "Refresh failed");
                _bsMovies.DataSource = null;
            };

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

            try
            {
                _database.Add(child.Movie);
            } catch (ValidationException ex)
            {
                DisplayError(ex, "Validation Failed");
            } catch (Exception ex)
            {
                DisplayError( ex, "Add Failed");
             };

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
            try
            {
                _database.Update(child.Movie);
            } catch(Exception ex)
            {
                DisplayError(ex, "Update failed");
            };
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
            try
            {
                _database.Remove(movie.Id);
            } catch (Exception e)
            {
                DisplayError(e, "Delete failed");
            }

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
        private void DisplayError( Exception error, string title = "Error" )
        {
            DisplayError(error.Message, title);
        }
        private void DisplayError( string message, string title = "Error" )
        {
            MessageBox.Show(this, message, title ?? "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private IMovieDatabase _database;
    }
}
