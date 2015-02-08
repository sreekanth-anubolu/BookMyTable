using BookMyTable.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyTable.Pages
{
    public partial class ReasturantDetails
    {
        public ReasturantDetails()
        {
            InitializeComponent();
        }
        public ReasturantDetails(Restaurant reasturant)
        {
            InitializeComponent();
            this.BindingContext = reasturant;
        }

        public async void BookTableClicked(object sender, EventArgs args)
        {
            await this.Navigation.PushModalAsync(new Registration());
        }
    }
}
