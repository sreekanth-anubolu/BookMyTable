using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BookMyTable.Pages
{
    public partial class ChooseRegistrationType:ContentPage
    {
        public ChooseRegistrationType()
        {
            InitializeComponent();
        }

        public async void SearchRestaurantClicked(object sender, EventArgs e)
        {

            await Navigation.PushModalAsync(new SearchRestaurant());

        }

        public async void RegisterReasturantClicked(object sender, EventArgs e)
        {

            await Navigation.PushModalAsync(new RegisterReasturant());

        }
    }
}
