using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP_041_S.Models;
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

namespace UWP_041_S
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Cover> Covers;
        private ObservableCollection<Book> Books;
        public MainPage()
        {
            this.InitializeComponent();
            Covers = new List<Cover>();
            Covers.Add(new Cover { ImageBook = "Assets/1.png" });
            Covers.Add(new Cover { ImageBook = "Assets/2.png" });
            Covers.Add(new Cover { ImageBook = "Assets/3.png" });
            Covers.Add(new Cover { ImageBook = "Assets/4.png" });
            Covers.Add(new Cover { ImageBook = "Assets/5.png" });
            Covers.Add(new Cover { ImageBook = "Assets/6.png" });
            Covers.Add(new Cover { ImageBook = "Assets/7.png" });
            Covers.Add(new Cover { ImageBook = "Assets/8.png" });
            Covers.Add(new Cover { ImageBook = "Assets/9.png" });
            Covers.Add(new Cover { ImageBook = "Assets/10.png" });
            Covers.Add(new Cover { ImageBook = "Assets/11.png" });
            Covers.Add(new Cover { ImageBook = "Assets/12.png" });
            Covers.Add(new Cover { ImageBook = "Assets/13.png" });

            Books = new ObservableCollection<Book>();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string Image = ((Cover)CoverComboBox.SelectedValue).ImageBook;
            double Price = double.Parse(PriceTextBox.Text);
            Books.Add(new Book { Title = TitleTextBox.Text, Author = AuthorTextBox.Text, Price = Price, Cover = Image });
            TitleTextBox.Text = "";
            AuthorTextBox.Text = "";
            PriceTextBox.Text = "";
            CoverComboBox.SelectedIndex = -1;

            TitleTextBox.Focus(FocusState.Programmatic);

        }
    }
}
