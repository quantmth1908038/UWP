using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.PointOfService;
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

namespace UWP_021
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(HomePage));
            BackButton.Visibility = Visibility.Collapsed;

        }
        
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void IcomsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (HomeListBoxItem.IsSelected) 
            {
                MyFrame.Navigate(typeof(HomePage));
                TitlePage.Text = "Financial";
                if (MyFrame.CanGoBack)
                {
                    BackButton.Visibility = Visibility.Visible;
                }
                else { BackButton.Visibility = Visibility.Collapsed; }
            }
            else if (FavoritesListBoxItem.IsSelected) 
            {
                MyFrame.Navigate(typeof(FavoritesPage));
                TitlePage.Text = "Food";
                if (MyFrame.CanGoBack)
                {
                    BackButton.Visibility = Visibility.Visible;
                }
                else { BackButton.Visibility = Visibility.Collapsed; }
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
            }
            if (MyFrame.CanGoBack)
            {
                BackButton.Visibility = Visibility.Visible;
            }
            else { BackButton.Visibility = Visibility.Collapsed; }
            if (MyFrame.SourcePageType.Name == "HomePage"){
                TitlePage.Text = "Financial";
            } else if (MyFrame.SourcePageType.Name == "FavoritesPage")
            {
                TitlePage.Text = "Food";
            }
        }
        
    }
}
