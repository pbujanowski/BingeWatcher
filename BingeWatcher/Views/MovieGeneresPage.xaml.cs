using System;

using BingeWatcher.ViewModels;
using BingeWatcher.Services;

using Windows.Media.Playback;
using Windows.System.Display;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using System.Collections.Generic;
using BingeWatcher.Core.Models;
using Windows.Devices.Input;

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
            fillListBox(button1.Content.ToString());
        }

        MovieService movies = new MovieService();

        private void fillListBox(string genere)
        {
            lb.Items.Clear();

            List<string> lista = new List<string>();
            for (int i = 0; i < 100; ++i)
            {
                lb.Items.Add(genere + " " + i * 4 + 3.ToString());
            }
        }
        

        private void Button_Click1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            //akcja
            //Task<List<Movie>> moviesList = movies.GetMoviesByGenre(MovieGenre.Action);

            fillListBox(button1.Content.ToString());

        }

        private void Button_Click2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            fillListBox(button2.Content.ToString());
        }

        private void Button_Click3(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            fillListBox(button3.Content.ToString());
        }

        private void Button_Click6(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            fillListBox(button6.Content.ToString());
        }

        private void Button_Click8(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            fillListBox(button8.Content.ToString());
        }

        private void Button_Click11(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            fillListBox(button11.Content.ToString());
        }

        private void Button_Click7(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            fillListBox(button7.Content.ToString());
        }

        private void Button_Click12(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            fillListBox(button12.Content.ToString());
        }

        private void Button_Click13(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            fillListBox(button13.Content.ToString());
        }

        private void Button_Click4(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            fillListBox(button4.Content.ToString());
        }

        private void Button_Click5(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            fillListBox(button5.Content.ToString());
        }

        private void Button_Click14(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            fillListBox(button14.Content.ToString());
        }

        private void Button_Click9(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            fillListBox(button9.Content.ToString());
        }

        private void Button_Click10(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            fillListBox(button10.Content.ToString());
        }

        private void Button_Click15(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            fillListBox(button15.Content.ToString());
        }
    }
}
