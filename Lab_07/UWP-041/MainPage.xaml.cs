﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP_041.Models;
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

namespace UWP_041
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> Icons;
        private ObservableCollection<Contact> Contacts;
        public MainPage()
        {
            this.InitializeComponent();
            Icons = IconManager.GetIcons();
            Contacts = new ObservableCollection<Contact>();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string avatar = ((Icon)Avatar.SelectedValue).ImagePath;
            Contacts.Add(new Contact { FirstName = FirstName.Text, LastName = LastName.Text, AvatarPath = avatar });
            FirstName.Text = "";
            LastName.Text = "";
            Avatar.SelectedIndex = -1;

            FirstName.Focus(FocusState.Programmatic);

        }
    }
}
