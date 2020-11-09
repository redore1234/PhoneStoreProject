using ManagePhone.Presenters;
using ManagePhone.Views;
using System;
using System.Windows.Forms;

namespace ManagePhone
{
    public partial class frmAddPhone : Form, IAddPhone
    {
        public string PhoneName => txtPhoneName.Text;
        public string Brand => cbPhoneBrand.SelectedItem.ToString();
        public DateTime LaunchDate => dtLaunchDate.Value;
        public long Price => long.Parse(txtPrice.Text);
        public int Quantity => int.Parse(numQuantity.Value.ToString());
        public string Description => txtDescription.Text;

        public string Image
        {
            get => pbImage.ImageLocation;
            set => pbImage.ImageLocation = value;
        }

        //The presenter
        private AddPhonePresenter _addPhonePresenter;

        private string pictureName;

        public frmAddPhone()
        {
            InitializeComponent();
            _addPhonePresenter = new AddPhonePresenter(this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            pictureName = _addPhonePresenter.UploadPicture();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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

            bool IsAddSuccess = _addPhonePresenter.AddPhone(pictureName);
            if (IsAddSuccess)
            {
                this.Close();
            }
        }

        private void frmAddPhone_Load(object sender, EventArgs e)
        {
            dtLaunchDate.Format = DateTimePickerFormat.Custom;
            dtLaunchDate.CustomFormat = "dd-MM-yyyy";
        }
    }
}