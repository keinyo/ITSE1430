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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this._chkOwned.Location = new System.Drawing.Point(100, 202);
            this._chkOwned.Name = "_chkOwned";
            this._chkOwned.Size = new System.Drawing.Size(60, 17);
            this._chkOwned.TabIndex = 4;
            this._chkOwned.Text = "Owned";
            this._chkOwned.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(100, 68);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 88);
            this.textBox3.TabIndex = 7;
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(222, 231);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 8;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(303, 231);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 9;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            // 
            // _lblMinutes
            // 
            this._lblMinutes.AutoSize = true;
            this._lblMinutes.Location = new System.Drawing.Point(307, 165);
            this._lblMinutes.Name = "_lblMinutes";
            this._lblMinutes.Size = new System.Drawing.Size(43, 13);
            this._lblMinutes.TabIndex = 10;
            this._lblMinutes.Text = "minutes";
            // 
            // MovieDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 266);
            this.Controls.Add(this._lblMinutes);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Label _lblMinutes;
    }
}