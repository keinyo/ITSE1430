﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nile.Windows
{
    public partial class ProductDetailForm : Form
    {
        #region Construction

         ProductDetailForm() //: base()
        {
            InitializeComponent();
        }

        public ProductDetailForm(string title) : this()
        {
            Text = title;
        }

        public ProductDetailForm( string title, Product product ) : this(title)
        {
            Product = product;
        }
        #endregion

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            if(Product != null)
            {
                _txtName.Text = Product.Name;
                _txtDescription.Text = Product.Description;
                _txtPrice.Text = Product.Price.ToString();
                _chkDiscontinued.Checked = Product.IsDiscontinued;
            };
        }


        /// <summary> Gets or sets the product being shown.</summary>
        public Product Product { get; set; }

        private void OnCancel( object sender, EventArgs e )
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void showError( string message, string title )
        {
            MessageBox.Show(this, message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void OnSave( object sender, EventArgs e )
        {
            var product = new Product();
            product.Name = _txtName.Text;
            product.Description = _txtDescription.Text;
            product.Price = GetPrice();
            product.IsDiscontinued = _chkDiscontinued.Checked;

            //Add validation
            var error = product.Validate();
            if(!String.IsNullOrEmpty(error))
            {
                //Show the error
                showError(error, "Validation Error");
                return;
            };

            Product = product;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private decimal GetPrice()
        {
            if (Decimal.TryParse(_txtPrice.Text, out decimal price))
                return price;

            //TODO: Validate price
            return 0;
        }

        private void ProductDetailForm_FormClosing( object sender, FormClosingEventArgs e )
        {
            //Do not do
            //var form = (Form)sender;

            //Runtime safe version
            var form = sender as Form;

            //casting for value types
            if (sender is int)
            {
                var intValue2 = (int)sender;
            };

            //Patern matching - not used in this class, but helpful for future.
            if (sender is int intValue)
            {

            };

            if (MessageBox.Show(this, "Are you Sure?", "Closing", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void ProductDetailForm_FormClosed( object sender, FormClosedEventArgs e )
        {

        }
    }
}
