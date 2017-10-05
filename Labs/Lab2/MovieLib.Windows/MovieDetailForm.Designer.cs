namespace MovieLib.Windows
{
    partial class MovieDetailForm
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
            this._lblTitle = new System.Windows.Forms.Label();
            this._lblDescription = new System.Windows.Forms.Label();
            this._lblLength = new System.Windows.Forms.Label();
            this._chkOwned = new System.Windows.Forms.CheckBox();
            this._txtTitle = new System.Windows.Forms.TextBox();
            this._txtLength = new System.Windows.Forms.TextBox();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._lblMinutes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblTitle
            // 
            this._lblTitle.AutoSize = true;
            this._lblTitle.Location = new System.Drawing.Point(12, 42);
            this._lblTitle.Name = "_lblTitle";
            this._lblTitle.Size = new System.Drawing.Size(33, 13);
            this._lblTitle.TabIndex = 0;
            this._lblTitle.Text = "Title: ";
            // 
            // _lblDescription
            // 
            this._lblDescription.AutoSize = true;
            this._lblDescription.Location = new System.Drawing.Point(12, 68);
            this._lblDescription.Name = "_lblDescription";
            this._lblDescription.Size = new System.Drawing.Size(66, 13);
            this._lblDescription.TabIndex = 2;
            this._lblDescription.Text = "Description: ";
            // 
            // _lblLength
            // 
            this._lblLength.AutoSize = true;
            this._lblLength.Location = new System.Drawing.Point(12, 165);
            this._lblLength.Name = "_lblLength";
            this._lblLength.Size = new System.Drawing.Size(43, 13);
            this._lblLength.TabIndex = 3;
            this._lblLength.Text = "Length:";
            // 
            // _chkOwned
            // 
            this._chkOwned.AutoSize = true;
            this._chkOwned.Location = new System.Drawing.Point(84, 188);
            this._chkOwned.Name = "_chkOwned";
            this._chkOwned.Size = new System.Drawing.Size(60, 17);
            this._chkOwned.TabIndex = 8;
            this._chkOwned.Text = "Owned";
            this._chkOwned.UseVisualStyleBackColor = true;
            // 
            // _txtTitle
            // 
            this._txtTitle.Location = new System.Drawing.Point(84, 42);
            this._txtTitle.Name = "_txtTitle";
            this._txtTitle.Size = new System.Drawing.Size(313, 20);
            this._txtTitle.TabIndex = 5;
            // 
            // _txtLength
            // 
            this._txtLength.Location = new System.Drawing.Point(84, 162);
            this._txtLength.Name = "_txtLength";
            this._txtLength.Size = new System.Drawing.Size(60, 20);
            this._txtLength.TabIndex = 7;
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(84, 68);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(313, 88);
            this._txtDescription.TabIndex = 6;
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(241, 216);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 9;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(322, 216);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 10;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _lblMinutes
            // 
            this._lblMinutes.AutoSize = true;
            this._lblMinutes.Location = new System.Drawing.Point(150, 165);
            this._lblMinutes.Name = "_lblMinutes";
            this._lblMinutes.Size = new System.Drawing.Size(43, 13);
            this._lblMinutes.TabIndex = 10;
            this._lblMinutes.Text = "minutes";
            // 
            // MovieDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 251);
            this.Controls.Add(this._lblMinutes);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this._txtLength);
            this.Controls.Add(this._txtTitle);
            this.Controls.Add(this._chkOwned);
            this.Controls.Add(this._lblLength);
            this.Controls.Add(this._lblDescription);
            this.Controls.Add(this._lblTitle);
            this.Name = "MovieDetailForm";
            this.Text = "Movie Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblTitle;
        private System.Windows.Forms.Label _lblDescription;
        private System.Windows.Forms.Label _lblLength;
        private System.Windows.Forms.CheckBox _chkOwned;
        private System.Windows.Forms.TextBox _txtTitle;
        private System.Windows.Forms.TextBox _txtLength;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Label _lblMinutes;
    }
}