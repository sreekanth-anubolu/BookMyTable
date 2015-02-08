using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyTable.Pages
{
    public partial class SearchRestaurant
    {
        public SearchRestaurant()
        {
            InitializeComponent();
        }
        public async void SearchRestaurantClicked(object sender, EventArgs e)
        {

            await Navigation.PushModalAsync(new SearchResult());

        }
    }
}
