using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationWeek07
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }

        void Button_Clicked_Previous(System.Object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
