using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RTUnofficial.App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Nav_view_Loaded(object sender, RoutedEventArgs e)
        {
            // set the default selected item (home)
            foreach (NavigationViewItemBase item in nav_view.MenuItems)
            {
                if(item is NavigationViewItem && item.Tag.ToString() == "home_page")
                {
                    nav_view.SelectedItem = item;
                    break;
                }
            }

            content_frame.Navigate(typeof(HomePage));
        }

        private void Nav_view_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if(!(args.SelectedItem is NavigationViewItem))
            {
                return;
            }

            NavigationViewItem selected_item_ = (NavigationViewItem)args.SelectedItem;

            switch(selected_item_.Tag)
            {
                case "home_page":
                    content_frame.Navigate(typeof(HomePage));
                    break;

                case "channels_page":
                    content_frame.Navigate(typeof(ChannelsPage));
                    break;

                case "series_page":
                    content_frame.Navigate(typeof(SeriesPage));
                    break;

                case "episodes_page":
                    content_frame.Navigate(typeof(EpisodesPage));
                    break;

                case "live_page":
                    content_frame.Navigate(typeof(LivePage));
                    break;
            }
        }

        private void Nav_view_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
        }

        private void Nav_view_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            if(content_frame.CanGoBack)
            {
                content_frame.GoBack();
            }
        }

        private void Content_frame_Navigated(object sender, NavigationEventArgs e)
        {
            nav_view.IsBackEnabled = content_frame.CanGoBack;
        }
    }
}
