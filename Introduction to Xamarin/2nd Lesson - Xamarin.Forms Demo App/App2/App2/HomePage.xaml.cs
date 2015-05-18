using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace App2
{
    public partial class HomePage : MasterDetailPage
    {
        public HomePage()
        {
            InitializeComponent();

            List<MasterMenu> dataPattern = new List<MasterMenu> {
                new MasterMenu ("Home", "Home.png"),
                new MasterMenu ("Profile", "Profile.png")
            };

            OptionsView.ItemsSource = dataPattern;
            OptionsView.ItemSelected += OptionsView_ItemSelected;
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            ButtonBalance.IsVisible = false;
            LabelBalance.Text = "1000€";
        }

        async void OptionsView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var listView = sender as ListView;
            if (listView == null)
            {
                return;
            }
            if (listView.SelectedItem != null)
            {
                switch (((MasterMenu)listView.SelectedItem).Voce)
                {
                    case "Home":
                        {
                            break;
                        }
                    case "Profile":
                    {
                            await Navigation.PushModalAsync(new Profile());
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                listView.SelectedItem = null;
            }
            IsPresented = false;
        }

        private void Settings_OnClicked(object sender, EventArgs e)
        {
            //write here your code that will be run when the "Settings" button will be clicked
        }

        private void About_OnClicked(object sender, EventArgs e)
        {
            //write here your code that will be run when the "About" button will be clicked
        }
    }

    public class MasterMenu
    {
        public MasterMenu(string tVoce, string tImageURL)
        {
            Voce = tVoce;
            ImageURL = tImageURL;
        }

        public string Voce { get; set; }
        public string ImageURL { get; set; }
    }

    
}
