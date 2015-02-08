using BookMyTable.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace BookMyTable
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new ChooseRegistrationType(); 
        }
    }
}
