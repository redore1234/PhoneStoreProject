using ManagePhone.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Presenters
{
    public class CheckoutPresenter : Presenter<ICheckoutView>
    {
        public CheckoutPresenter(ICheckoutView view) : base(view)
        {
        }

        public bool CalculateCharge()
        {
            long Total = View.Total;
            long Cash = View.Cash;

            if (Cash >= Total)
            {
                View.Charge = Cash - Total;
                return true;
            }
            return false;
        }
    }
}
