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
            activeGenere = MovieGenre.Action;
            movies = new MovieService();
            moviesList = movies.GetMoviesByGenre(activeGenere);
            list = moviesList.Result;
        }

        MovieService movies;
        MovieGenre activeGenere;

        Task<List<Movie>> moviesList;
        List<Movie> list;


        private void Button_Click1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Action;

            lb.Items.Clear();

            moviesList = movies.GetMoviesByGenre(activeGenere);
            list = moviesList.Result;
            for (int i = 0; i < list.Count; ++i)
            {
                lb.Items.Add(list[i].Title);
            }
        }

        private void Button_Click2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Adventure;

            lb.Items.Clear();

            moviesList = movies.GetMoviesByGenre(activeGenere);
            list = moviesList.Result;
            for (int i = 0; i < list.Count; ++i)
            {
                lb.Items.Add(list[i].Title);
            }
        }

        private void Button_Click3(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Comedy;

            lb.Items.Clear();

            moviesList = movies.GetMoviesByGenre(activeGenere);
            list = moviesList.Result;
            for (int i = 0; i < list.Count; ++i)
            {
                lb.Items.Add(list[i].Title);
            }
        }

        private void Button_Click6(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Fantasy;

            lb.Items.Clear();

            moviesList = movies.GetMoviesByGenre(activeGenere);
            list = moviesList.Result;
            for (int i = 0; i < list.Count; ++i)
            {
                lb.Items.Add(list[i].Title);
            }
        }

        private void Button_Click8(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Horror;

            lb.Items.Clear();

            moviesList = movies.GetMoviesByGenre(activeGenere);
            list = moviesList.Result;
            for (int i = 0; i < list.Count; ++i)
            {
                lb.Items.Add(list[i].Title);
            }
        }

        private void Button_Click11(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.ScienceFiction;

            lb.Items.Clear();

            moviesList = movies.GetMoviesByGenre(activeGenere);
            list = moviesList.Result;
            for (int i = 0; i < list.Count; ++i)
            {
                lb.Items.Add(list[i].Title);
            }
        }

        private void Button_Click7(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Historical;

            lb.Items.Clear();

            moviesList = movies.GetMoviesByGenre(activeGenere);
            list = moviesList.Result;
            for (int i = 0; i < list.Count; ++i)
            {
                lb.Items.Add(list[i].Title);
            }
        }

        private void Button_Click12(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Thriller;

            lb.Items.Clear();

            moviesList = movies.GetMoviesByGenre(activeGenere);
            list = moviesList.Result;
            for (int i = 0; i < list.Count; ++i)
            {
                lb.Items.Add(list[i].Title);
            }
        }

        private void Button_Click13(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Western;

            lb.Items.Clear();

            moviesList = movies.GetMoviesByGenre(activeGenere);
            list = moviesList.Result;
            for (int i = 0; i < list.Count; ++i)
            {
                lb.Items.Add(list[i].Title);
            }
        }

        private void Button_Click4(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Crime;

            lb.Items.Clear();

            moviesList = movies.GetMoviesByGenre(activeGenere);
            list = moviesList.Result;
            for (int i = 0; i < list.Count; ++i)
            {
                lb.Items.Add(list[i].Title);
            }
        }

        private void Button_Click5(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Drama;

            lb.Items.Clear();

            moviesList = movies.GetMoviesByGenre(activeGenere);
            list = moviesList.Result;
            for (int i = 0; i < list.Count; ++i)
            {
                lb.Items.Add(list[i].Title);
            }
        }

        private void Button_Click14(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Musical;

            lb.Items.Clear();

            moviesList = movies.GetMoviesByGenre(activeGenere);
            list = moviesList.Result;
            for (int i = 0; i < list.Count; ++i)
            {
                lb.Items.Add(list[i].Title);
            }
        }

        private void Button_Click9(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Political;

            lb.Items.Clear();

            moviesList = movies.GetMoviesByGenre(activeGenere);
            list = moviesList.Result;
            for (int i = 0; i < list.Count; ++i)
            {
                lb.Items.Add(list[i].Title);
            }
        }

        private void Button_Click10(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Romance;

            lb.Items.Clear();

            moviesList = movies.GetMoviesByGenre(activeGenere);
            list = moviesList.Result;
            for (int i = 0; i < list.Count; ++i)
            {
                lb.Items.Add(list[i].Title);
            }
        }

        private void Button_Click15(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            activeGenere = MovieGenre.Anime;

            lb.Items.Clear();

            moviesList = movies.GetMoviesByGenre(activeGenere);
            list = moviesList.Result;
            for (int i = 0; i < list.Count; ++i)
            {
                lb.Items.Add(list[i].Title);
            }
        }
        
        private void HyperlinkButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (lb.SelectedIndex > -1)
            {
                Globals.Genre = list[lb.SelectedIndex].Genre.ToString();
                Globals.Source = list[lb.SelectedIndex].Source;
                Globals.Title = list[lb.SelectedIndex].Title;
                Globals.ReleaseDate = list[lb.SelectedIndex].ReleaseDate.Year.ToString();
                
                this.Frame.Navigate(typeof(MoviePlayerPage));
            }            
        }

    }
}
