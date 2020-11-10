using ManagePhone.Models.Models;
using ManagePhone.Presenters;
using ManagePhone.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagePhone {
    public partial class frmUpdatePhone : Form, IUpdatePhoneView {
        public string PhoneName { 
            get => txtPhoneName.Text; 
            set => txtPhoneName.Text = value; 
        }

        public string Brand {
            get => cbPhoneBrand.Text;
            set => cbPhoneBrand.Text = value;
        }

        public DateTime LaunchDate { 
            get => dtLaunchDate.Value;
            set => dtLaunchDate.Value = value; 
        }

        public long Price { 
            get => long.Parse(txtPrice.Text);
            set => txtPrice.Text = value.ToString();
        }

        public int Quantity { 
            get => int.Parse(numQuantity.Value.ToString());
            set => numQuantity.Value = value; 
        }

        public string Description { 
            get => txtDescription.Text;
            set => txtDescription.Text = value; 
        }

        public string Image { 
            get => pbImage.ImageLocation;
            set => pbImage.ImageLocation = value; 
        }

        private ProductModel Model;
        string ImagePath;

        //The presentation
        UpdatePhonePresenter _updatePhonePresenter;

        public frmUpdatePhone() {
            InitializeComponent();
        }

        public frmUpdatePhone(ProductModel Model) : this() 
        {
            this.Model = Model;
            _updatePhonePresenter = new UpdatePhonePresenter(this);
        }

        private void frmUpdatePhone_Load(object sender, EventArgs e)
        {
            _updatePhonePresenter.Display(Model);
            ImagePath = Model.Image;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            ImagePath = _updatePhonePresenter.UploadPicture();
        }

        private void btnUpdatePhone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PhoneName))
            {
                MessageBox.Show("Field name can not empty!");
                return;
            }

            if (string.IsNullOrEmpty(Image))
            {
                MessageBox.Show("To add a new phone\nYou need to add a picture!");
                return;
            }

            if (string.IsNullOrEmpty(Brand))
            {
                MessageBox.Show("Field brand can not empty!");
                return;
            }

            if (Price < 0)
            {
                MessageBox.Show("Price must not lower than 0");
                return;
            }

            if (Quantity < 0)
            {
                MessageBox.Show("Quantity must not lower than 0");
                return;
            }

            if (string.IsNullOrEmpty(Description))
            {
                MessageBox.Show("Field description can not empty!");
                return;
            }

            bool IsUpdated = _updatePhonePresenter.UpdatePhone(Model, ImagePath);
            if(IsUpdated)
            {
                this.Close();
            }
        }
    }
}
