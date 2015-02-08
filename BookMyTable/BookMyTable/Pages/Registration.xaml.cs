using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyTable.Pages
{
    public partial class Registration
    {
        public Registration()
        {
            InitializeComponent();
        }

        public async void SingupClicked(object sender, EventArgs e)
        {

            await Navigation.PushModalAsync(new UserFeedback());

        }
        
        public void OnTapAdvisorStarRatingTapped(object sender, EventArgs args)
        {
            

        }
    }
}
