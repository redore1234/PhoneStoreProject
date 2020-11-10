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

namespace ManagePhone
{
    public partial class frmShowImage : Form, IShowImageView
    {
        //The presenter
        ShowImagePresenter _showImagePresenter;
        string ImagePath;

        public frmShowImage()
        {
            InitializeComponent();
        }

        public frmShowImage(string ProductName, string ImagePath) : this()
        {
            _showImagePresenter = new ShowImagePresenter(this);
            this.ImagePath = ImagePath;
            Text = "Image of " + ProductName;
        }

        public string Image {
            set => pbImage.ImageLocation = value;
        }

        private void frmShowImage_Load(object sender, EventArgs e)
        {
            _showImagePresenter.ShowImage(ImagePath);
        }
    }
}
