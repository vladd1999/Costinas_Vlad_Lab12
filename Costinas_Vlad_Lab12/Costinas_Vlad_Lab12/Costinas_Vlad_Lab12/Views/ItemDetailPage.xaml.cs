﻿using Costinas_Vlad_Lab12.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Costinas_Vlad_Lab12.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}