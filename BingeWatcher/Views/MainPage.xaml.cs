﻿using System;

using BingeWatcher.ViewModels;

using Windows.UI.Xaml.Controls;

namespace BingeWatcher.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return ViewModelLocator.Current.MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
