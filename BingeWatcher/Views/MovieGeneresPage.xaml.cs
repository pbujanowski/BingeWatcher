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
        
        public MovieGeneresPage()
        {
            InitializeComponent();
            fillListBox(button1.Content.ToString());
            activeGenere = MovieGenre.Action;
            movies = new MovieService();
        }

        MovieService movies;
        MovieGenre activeGenere;

        private void fillListBox(string genere)
        {
            lb.Items.Clear();

            List<string> lista = new List<string>();
            for (int i = 0; i < 100; ++i)
            {
                lb.Items.Add(genere + " " + i.ToString());
            }
        }
        

        private void Button_Click1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Action;

            //Task<List<Movie>> moviesList = movies.GetMoviesByGenre(MovieGenre.Action);
            //List<Movie> list = moviesList.Result;
            fillListBox(button1.Content.ToString());
        }

        private void Button_Click2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Adventure;

            fillListBox(button2.Content.ToString());
        }

        private void Button_Click3(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Comedy;

            fillListBox(button3.Content.ToString());
        }

        private void Button_Click6(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Fantasy;

            fillListBox(button6.Content.ToString());
        }

        private void Button_Click8(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Horror;

            fillListBox(button8.Content.ToString());
        }

        private void Button_Click11(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.ScienceFiction;
            fillListBox(button11.Content.ToString());
        }

        private void Button_Click7(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Historical;

            fillListBox(button7.Content.ToString());
        }

        private void Button_Click12(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Thriller;

            fillListBox(button12.Content.ToString());
        }

        private void Button_Click13(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Western;
            
            fillListBox(button13.Content.ToString());
        }

        private void Button_Click4(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Crime;

            fillListBox(button4.Content.ToString());
        }

        private void Button_Click5(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Drama;

            fillListBox(button5.Content.ToString());
        }

        private void Button_Click14(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Musical;

            fillListBox(button14.Content.ToString());
        }

        private void Button_Click9(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Political;

            fillListBox(button9.Content.ToString());
        }

        private void Button_Click10(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Romance;

            fillListBox(button10.Content.ToString());
        }

        private void Button_Click15(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Anime;

            fillListBox(button15.Content.ToString());
        }
        
        private void HyperlinkButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (lb.SelectedIndex > -1)
            {
                hyper.Content = activeGenere.ToString() + (lb.SelectedIndex.ToString());

                Task<List<Movie>> movie = movies.GetMoviesByGenre(activeGenere);
                //List<Movie> list = movie.Result;
                //string source = list[lb.SelectedIndex].Source;

                /*Globals.Genre = list[lb.SelectedIndex].Genre;
                Globals.Source = list[lb.SelectedIndex].Source;
                Globals.Title = list[lb.SelectedIndex].Title;
                Globals.ReleaseDate = list[lb.SelectedIndex].ReleaseDate.Year;*/

                Globals.Genre = activeGenere.ToString();
                Globals.Source = "link";
                Globals.Title = "Titanic Super 3D";
                Globals.ReleaseDate = 1997.ToString();

                this.Frame.Navigate(typeof(MoviePlayerPage));
            }            
        }

    }
}
