/*
 * Jacob Lanham
 * ITSE 1430
 * 10-05-2017
 */
namespace MovieLib.Windows
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miMoviesAdd = new System.Windows.Forms.ToolStripMenuItem();
            this._miMoviesEdit = new System.Windows.Forms.ToolStripMenuItem();
            this._miMoviesDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._gridMovies = new System.Windows.Forms.DataGridView();
            this._bsMovies = new System.Windows.Forms.BindingSource(this.components);
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainMenu
            // 
            this._mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.moviesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this._mainMenu.Location = new System.Drawing.Point(0, 0);
            this._mainMenu.Name = "_mainMenu";
            this._mainMenu.Size = new System.Drawing.Size(684, 24);
            this._mainMenu.TabIndex = 0;
            this._mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // _miFileExit
            // 
            this._miFileExit.Name = "_miFileExit";
            this._miFileExit.Size = new System.Drawing.Size(92, 22);
            this._miFileExit.Text = "E&xit";
            this._miFileExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miMoviesAdd,
            this._miMoviesEdit,
            this._miMoviesDelete});
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.moviesToolStripMenuItem.Text = "&Movies";
            // 
            // _miMoviesAdd
            // 
            this._miMoviesAdd.Name = "_miMoviesAdd";
            this._miMoviesAdd.Size = new System.Drawing.Size(107, 22);
            this._miMoviesAdd.Text = "&Add";
            this._miMoviesAdd.Click += new System.EventHandler(this.OnMoviesAdd);
            // 
            // _miMoviesEdit
            // 
            this._miMoviesEdit.Name = "_miMoviesEdit";
            this._miMoviesEdit.Size = new System.Drawing.Size(107, 22);
            this._miMoviesEdit.Text = "&Edit";
            this._miMoviesEdit.Click += new System.EventHandler(this.OnMovieEdit);
            // 
            // _miMoviesDelete
            // 
            this._miMoviesDelete.Name = "_miMoviesDelete";
            this._miMoviesDelete.Size = new System.Drawing.Size(107, 22);
            this._miMoviesDelete.Text = "&Delete";
            this._miMoviesDelete.Click += new System.EventHandler(this.OnMoviesDelete);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miHelpAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // _miHelpAbout
            // 
            this._miHelpAbout.Name = "_miHelpAbout";
            this._miHelpAbout.Size = new System.Drawing.Size(107, 22);
            this._miHelpAbout.Text = "About";
            this._miHelpAbout.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // _gridMovies
            // 
            this._gridMovies.AllowUserToAddRows = false;
            this._gridMovies.AllowUserToDeleteRows = false;
            this._gridMovies.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._gridMovies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._gridMovies.AutoGenerateColumns = false;
            this._gridMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.ownedDataGridViewCheckBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this._gridMovies.DataSource = this._bsMovies;
            this._gridMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridMovies.Location = new System.Drawing.Point(0, 24);
            this._gridMovies.Name = "_gridMovies";
            this._gridMovies.ReadOnly = true;
            this._gridMovies.RowHeadersVisible = false;
            this._gridMovies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._gridMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridMovies.Size = new System.Drawing.Size(684, 337);
            this._gridMovies.TabIndex = 1;
            this._gridMovies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnEditRow);
            this._gridMovies.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownGrid);
            // 
            // _bsMovies
            // 
            this._bsMovies.AllowNew = false;
            this._bsMovies.DataSource = typeof(MovieLib.Movie);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.FillWeight = 150F;
            this.titleDataGridViewTextBoxColumn.Frozen = true;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 150F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.FillWeight = 150F;
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            this.lengthDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ownedDataGridViewCheckBoxColumn
            // 
            this.ownedDataGridViewCheckBoxColumn.DataPropertyName = "Owned";
            this.ownedDataGridViewCheckBoxColumn.HeaderText = "Is Owned?";
            this.ownedDataGridViewCheckBoxColumn.MinimumWidth = 20;
            this.ownedDataGridViewCheckBoxColumn.Name = "ownedDataGridViewCheckBoxColumn";
            this.ownedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ownedDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ownedDataGridViewCheckBoxColumn.Width = 65;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this._gridMovies);
            this.Controls.Add(this._mainMenu);
            this.MainMenuStrip = this._mainMenu;
            this.Name = "MainForm";
            this.Text = "Movie Library";
            this._mainMenu.ResumeLayout(false);
            this._mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miFileExit;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miMoviesAdd;
        private System.Windows.Forms.ToolStripMenuItem _miMoviesEdit;
        private System.Windows.Forms.ToolStripMenuItem _miMoviesDelete;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miHelpAbout;
        private System.Windows.Forms.DataGridView _gridMovies;
        private System.Windows.Forms.BindingSource _bsMovies;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ownedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}

