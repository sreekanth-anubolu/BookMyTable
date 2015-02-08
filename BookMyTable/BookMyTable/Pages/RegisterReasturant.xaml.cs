using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyTable.Pages
{
    public partial class RegisterReasturant
    {
        public RegisterReasturant()
        {
            InitializeComponent();
        }
        public async void RegisterClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SearchRestaurant());

        }
    }
}
