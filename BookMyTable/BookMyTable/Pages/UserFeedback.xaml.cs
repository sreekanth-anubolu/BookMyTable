using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyTable.Pages
{
    public partial class UserFeedback
    {
        public UserFeedback()
        {
            InitializeComponent();
            txtThanks.IsVisible = false;
        }
        public void SubmitClicked(object sender, EventArgs args)
        {
            txtThanks.IsVisible = true;
        }

        public async void ContinueClicked(object sender, EventArgs args)
        {
            await this.Navigation.PushModalAsync(new SearchRestaurant());
        }
    }
}
