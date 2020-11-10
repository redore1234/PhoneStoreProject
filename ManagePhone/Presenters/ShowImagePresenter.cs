using ManagePhone.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Presenters
{
    public class ShowImagePresenter : Presenter<IShowImageView>
    {
        public ShowImagePresenter(IShowImageView view) : base(view) {}

        public void ShowImage(string ImagePath)
        {
            string WorkingDirectory = Environment.CurrentDirectory;
            string ProjectDirectory = Directory.GetParent(WorkingDirectory).Parent.Parent.FullName;
            string ImageRealPath = ProjectDirectory + ImagePath;
            View.Image = ImageRealPath;
        }
    }
}
