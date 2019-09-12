using System;

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

        private void TextBlock_SelectionChanged(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void HyperlinkButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
           
            
            this.Frame.Navigate(typeof(MoviePlayerPage));
        }
    }
}
