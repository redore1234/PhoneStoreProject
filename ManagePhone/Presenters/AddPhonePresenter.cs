using ManagePhone.Models.Models;
using ManagePhone.Views;
using System;
using System.IO;
using System.Windows.Forms;

namespace ManagePhone.Presenters
{
    public class AddPhonePresenter : Presenter<IAddPhone>
    {
        private const string IMAGE_EXTENSIONS = "*.jpg; *.jpeg; *.png; *.gif; *.bmp";

        public AddPhonePresenter(IAddPhone view) : base(view)
        {
        }

        public string UploadPicture()
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

        public bool AddPhone(string PictureName)
        {
            string Name = View.PhoneName;
            string Brand = View.Brand;
            string Description = View.Description;
            DateTime LaunchDate = View.LaunchDate;
            long Price = View.Price;
            int Quantity = View.Quantity;

            ProductModel Product = new ProductModel()
            {
                ProductName = Name,
                Brand = Brand,
                Price = Price,
                Image = PictureName,
                LaunchDate = LaunchDate,
                Quantity = Quantity,
                Description = Description
            };

            bool IsAdded = Model.AddProduct(Product);
            if (IsAdded)
            {
                MessageBox.Show("Product Added", "Notice");
            }
            else
            {
                MessageBox.Show("Add Failed", "Error");
            }

            return IsAdded;
        }
    }
}