﻿using Costinas_Vlad_Lab12.ViewModels;
using Costinas_Vlad_Lab12.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Costinas_Vlad_Lab12
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
