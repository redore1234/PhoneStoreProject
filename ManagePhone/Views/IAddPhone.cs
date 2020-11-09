using System;

namespace ManagePhone.Views
{
    public interface IAddPhone : IView
    {
        string PhoneName { get; }
        string Brand { get; }
        DateTime LaunchDate { get; }
        long Price { get; }
        int Quantity { get; }
        string Description { get; }
        string Image { get; set; }
    }
}