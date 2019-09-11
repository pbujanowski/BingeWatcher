using System;

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

       
        private async void PlaybackSession_PlaybackStateChanged(MediaPlaybackSession sender, object args)
        {
            if (sender is MediaPlaybackSession playbackSession && playbackSession.NaturalVideoHeight != 0)
            {
                if (playbackSession.PlaybackState == MediaPlaybackState.Playing)
                {
                    if (!_isRequestActive)
                    {
                        await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                        {
                            _displayRequest.RequestActive();
                            _isRequestActive = true;
                        });
                    }
                }
                else
                {
                    if (_isRequestActive)
                    {
                        await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                        {
                            _displayRequest.RequestRelease();
                            _isRequestActive = false;
                        });
                    }
                }
            }
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Button_Click1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Button_Click2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Button_Click3(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Button_Click6(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Button_Click8(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Button_Click11(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Button_Click7(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Button_Click12(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Button_Click13(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Button_Click4(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Button_Click5(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Button_Click14(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Button_Click9(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Button_Click10(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Button_Click15(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}
