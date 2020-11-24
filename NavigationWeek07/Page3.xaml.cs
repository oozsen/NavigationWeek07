using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationWeek07
{
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        void Button_Clicked_Root(System.Object sender, System.EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}
