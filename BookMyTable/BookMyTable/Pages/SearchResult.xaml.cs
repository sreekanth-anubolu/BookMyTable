using BookMyTable.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyTable.Pages
{
    public partial class SearchResult
    {
        public SearchResult()
        {
            InitializeComponent();

            List<Restaurant> restList = new List<Restaurant>();
            restList.Add(new Restaurant { Name = "KFC India", Contact = "9970956133", Location = "Kormangala",ImageUri="table.jpg"});
            restList.Add(new Restaurant { Name = "Udpi", Contact = "3452456734", Location = "IndiraNagar", ImageUri = "restaurant1.jpg" });
            restList.Add(new Restaurant { Name = "MacDonald", Contact = "0983745728", Location = "BTM Layout", ImageUri = "restaurant2.jpg" });
            restList.Add(new Restaurant { Name = "South Dosa", Contact = "09834758293", Location = "JP Nagar", ImageUri = "restaurant3.jpg" });
            restList.Add(new Restaurant { Name = "Idli Delivery", Contact = "0398475923", Location = "Kormangala", ImageUri = "restaurant5.jpg" });
            restList.Add(new Restaurant { Name = "Matten", Contact = "0938472345", Location = "Jay Nagar", ImageUri = "restaurant7.jpg" });
            restList.Add(new Restaurant { Name = "Leela Palace", Contact = "08293748234", Location = "Marathali", ImageUri = "restaurant1.jpg" });
            restList.Add(new Restaurant { Name = "Jal Mahal Palace", Contact = "06829348234", Location = "White Field", ImageUri = "restaurant2.jpg" });
            restList.Add(new Restaurant { Name = "Taj India", Contact = "09782345258", Location = "Airport Road", ImageUri = "restaurant3.jpg" });
            restList.Add(new Restaurant { Name = "Radission", Contact = "09823473854", Location = "Kormangala", ImageUri = "restaurant7.jpg" });
            restList.Add(new Restaurant { Name = "KFC India", Contact = "9970956133", Location = "Kormangala", ImageUri = "table.jpg" });
            restList.Add(new Restaurant { Name = "Udpi", Contact = "3452456734", Location = "IndiraNagar", ImageUri = "restaurant1.jpg" });
     
            myList.ItemsSource = restList;
        }

        public async void OnItemClicked(object sender, EventArgs args)
        {
            Restaurant resItem = myList.SelectedItem as Restaurant;
            await this.Navigation.PushModalAsync(new ReasturantDetails(resItem));
        }
    }
}
