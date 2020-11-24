using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationWeek07
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}
