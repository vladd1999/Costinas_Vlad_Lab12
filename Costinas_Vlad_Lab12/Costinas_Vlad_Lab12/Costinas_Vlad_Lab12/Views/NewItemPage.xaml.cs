using Costinas_Vlad_Lab12.Models;
using Costinas_Vlad_Lab12.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Costinas_Vlad_Lab12.Views
{
    public partial class NewItemPage : ContentPage
    {
        public MenuItem Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}