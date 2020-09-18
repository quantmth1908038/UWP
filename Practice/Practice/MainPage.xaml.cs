using Practice.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Practice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private List<ImageProduct> ImageProducts;

        private ObservableCollection<Product> Products;

        public MainPage()
        {
            this.InitializeComponent();

            ImageProducts = new List<ImageProduct>();
            ImageProducts.Add(new ImageProduct { ImagePath = "Assets/P1.jpg" });
            ImageProducts.Add(new ImageProduct { ImagePath = "Assets/P2.jpg" });
            ImageProducts.Add(new ImageProduct { ImagePath = "Assets/P3.jpeg" });
            ImageProducts.Add(new ImageProduct { ImagePath = "Assets/P4.jpg" });

            Products = new ObservableCollection<Product>();
        }

        private void NewOrderButton_Click(object sender, RoutedEventArgs e)
        {
            string Image = ((ImageProduct)ImageComboBox.SelectedValue).ImagePath;
            Products.Add(new Product { ProductTitle = ProductTextBox.Text, Description = DescriptionTextBox.Text, ImageProductPath = Image });

            ProductTextBox.Text = "";
            DescriptionTextBox.Text = "";
            ImageComboBox.SelectedIndex = -1;

            ProductTextBox.Focus(FocusState.Programmatic);

        }
    }
}
