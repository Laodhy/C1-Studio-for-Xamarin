﻿using FlexGrid101.Resources;
using Xamarin.Forms;

namespace FlexGrid101
{
    public partial class FullTextFilter : ContentPage
    {
        public FullTextFilter()
        {
            InitializeComponent();

            this.Title = AppResources.FullTextFilterTitle;
            filter.Placeholder = AppResources.FilterPlaceholderText;
            filter.Keyboard = Keyboard.Plain;

            var data = Customer.GetCustomerList(100);
            grid.ItemsSource = data;
            grid.MinColumnWidth = 85;
        }
    }
}
