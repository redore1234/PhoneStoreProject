using ManagePhone.Models.Models;
using ManagePhone.Views;
using System.Windows.Forms;
using System;
using System.IO;

namespace ManagePhone.Presenters
{
    public class UpdatePhonePresenter : Presenter<IUpdatePhoneView>
    {
        private const string IMAGE_EXTENSIONS = "*.jpg; *.jpeg; *.png; *.gif; *.bmp";

        //Constructor
        public UpdatePhonePresenter(IUpdatePhoneView view) : base(view) {}

        public void Display(ProductModel Product)
        {
            string WorkingDirectory = Environment.CurrentDirectory;
            string ProjectDirectory = Directory.GetParent(WorkingDirectory).Parent.Parent.FullName;
            string ImagePath = ProjectDirectory + Product.Image;

            View.PhoneName = Product.ProductName;
            View.Brand = Product.Brand;
            View.Image = ImagePath;
            View.LaunchDate = Product.LaunchDate;
            View.Price = Product.Price;
            View.Quantity = Product.Quantity;
            View.Description = Product.Description;
        }

        public string UploadPicture(string ImagePath)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(" + IMAGE_EXTENSIONS + ")|" + IMAGE_EXTENSIONS + "";
            fileDialog.Multiselect = false;
            if (!string.IsNullOrEmpty(View.PhoneName))
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get path from file
                    string LocalPath = fileDialog.FileName;
                    string ExtensionFile = Path.GetExtension(fileDialog.FileName);
                    string Destination = @"\Image\" + (DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond) + "_" + View.PhoneName + ExtensionFile;
                    string WorkingDirectory = Environment.CurrentDirectory;
                    string ProjectDirectory = Directory.GetParent(WorkingDirectory).Parent.Parent.FullName;
                    string ProjectPath = ProjectDirectory + Destination;

                    //Copy image to folder resource in project
                    File.Copy(LocalPath, ProjectPath, true);

                    //Delete old image
                    File.Delete(ProjectDirectory + ImagePath);

                    //Set image
                    View.Image = ProjectPath;

                    return Destination;
                }
            }
            else
            {
                MessageBox.Show("Please enter phone name first before choose image!", "Error");
            }

            return null;
        }

        public bool UpdatePhone(ProductModel Product, string PictureName)
        {
            int ProductID = Product.ProductID;
            string ProductName = View.PhoneName;
            string Brand = View.Brand;
            string Image = PictureName;
            DateTime LaunchDate = View.LaunchDate;
            long Price = View.Price;
            int Quantity = View.Quantity;
            string Description = View.Description;

            ProductModel UpdateProduct = new ProductModel()
            {
                ProductID = ProductID,
                ProductName = ProductName,
                Brand = Brand,
                Image = Image,
                LaunchDate = LaunchDate,
                Price = Price,
                Quantity = Quantity,
                Description = Description
            };


            bool IsUpdated = Model.UpdateProduct(UpdateProduct);
            if(IsUpdated)
            {
                MessageBox.Show("Updated successful!", "Notice");
            } else
            {
                MessageBox.Show("Updated fail!", "Error");
            }

            return IsUpdated;
        }
    }
}