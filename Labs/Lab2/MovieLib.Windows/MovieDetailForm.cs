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
    public partial class MovieDetailForm : Form
    {
        public MovieDetailForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            if (Movie != null)
            {
                _txtTitle.Text = Movie.Title;
                _txtDescription.Text = Movie.Description;
                _txtLength.Text = Movie.Length.ToString();
                _chkOwned.Checked = Movie.Owned;

            };
        }
            /// <summary>Gets or sets the movie being shown/summary>
            public Movie Movie { get; set; }

        #region Buttons

        private void OnSave( object sender, EventArgs e )
        {
            var movie = new Movie();
            movie.Title = _txtTitle.Text;
            movie.Description = _txtDescription.Text;
            movie.Length = GetPrice();
            movie.Owned = _chkOwned.Checked;

            //Validation
            var error = movie.Validate();
            if(!String.IsNullOrEmpty(error))
            {
                //Display error
                ShowError(error, "Validation Error");
                return;
            }

            Movie = movie;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCancel( object sender, EventArgs e )
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
        #endregion
        
        private int GetPrice()
        {
            if (Int32.TryParse(_txtLength.Text, out int length))
                return length;

            //TODO: Validate price
            return 0;
        }

        private void ShowError( string message, string title)
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}
