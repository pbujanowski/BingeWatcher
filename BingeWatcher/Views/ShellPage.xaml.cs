﻿using System;
using BingeWatcher.Core.Models;
using BingeWatcher.ViewModels;

using Windows.UI.Xaml.Controls;

namespace BingeWatcher.Views
{
    // TODO WTS: Change the icons and titles for all NavigationViewItems in ShellPage.xaml.
    public sealed partial class ShellPage : Page
    {
        private ShellViewModel ViewModel
        {
            get { return ViewModelLocator.Current.ShellViewModel; }
        }

        public ShellPage()
        {
            InitializeComponent();
            DataContext = ViewModel;
            ViewModel.Initialize(shellFrame, navigationView, KeyboardAccelerators);
            Globals.Genre = "";
            Globals.Source = "";
            Globals.Title = "";
            Globals.ReleaseDate = "";
        }
    }
}
