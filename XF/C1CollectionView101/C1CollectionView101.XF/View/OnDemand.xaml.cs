﻿using C1CollectionView101.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using C1.CollectionView;

namespace C1CollectionView101
{
    public partial class OnDemand: ContentPage
    {
        YouTubeCollectionView _collectionView;

        public OnDemand()
        {
            InitializeComponent();
            Title = AppResources.OnDemandTitle;
            search.Placeholder = AppResources.SearchPlaceholderText;
            _collectionView = new YouTubeCollectionView();
            list.ItemsSource = _collectionView;
        }

        private async void OnTextChanged(object sender, EventArgs e)
        {
            try
            {

                message.IsVisible = false;
                list.IsVisible = false;
                activityIndicator.IsRunning = true;
                await _collectionView.SearchAsync(search.Text);
                list.IsVisible = true;
            }
            catch
            {
                message.Text = AppResources.InternetConnectionError;
                message.IsVisible = true;
            }
            finally
            {
                activityIndicator.IsRunning = false;
            }
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var video = e.Item as YouTubeVideo;
            Device.OpenUri(new Uri(video.Link));
        }
    }
}
