﻿using System;

using BingeWatcher.ViewModels;

using Windows.Media.Playback;
using Windows.System.Display;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace BingeWatcher.Views
{
    public sealed partial class MovieGeneresPage : Page
    {
        private MovieGeneresViewModel ViewModel { get; } = ViewModelLocator.Current.MovieGeneresViewModel;

        // For more on the MediaPlayer and adjusting controls and behavior see https://docs.microsoft.com/en-us/windows/uwp/controls-and-patterns/media-playback
        // The DisplayRequest is used to stop the screen dimming while watching for extended periods
        private readonly DisplayRequest _displayRequest = new DisplayRequest();
        private bool _isRequestActive = false;

        public MovieGeneresPage()
        {
            InitializeComponent();
        }

        private void ClearGeneres()
        {
            
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            //anime

        }
    }
}
