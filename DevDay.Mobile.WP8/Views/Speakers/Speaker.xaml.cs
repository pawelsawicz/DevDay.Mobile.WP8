using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using DevDay.Mobile.WP8.Data.Agenda;
using DevDay.Mobile.WP8.Data;

namespace DevDay.Mobile.WP8.Views.Speakers
{
    public partial class Speaker : PhoneApplicationPage
    {
        private ListOfSpeakers _listOfSpeakers;
        public Speaker()
        {
            _listOfSpeakers = new ListOfSpeakers();
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string speaker = "";

            if (NavigationContext.QueryString.TryGetValue("speaker", out speaker))
            {
                var query = _listOfSpeakers.Speakers.Where(i => i.Name == speaker).Single();
                SpeakerSessionsListBox.ItemsSource = query.Lectures;

                avatarOfPresenter.DataContext = query;
                textBlockNameOfPresenter.Text = query.Name;
                textBlockNameOfCompany.Text = query.Company;
                textBlockDescriptionOfPresenter.Text = query.Description;
            }

        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            var lastPage = NavigationService.BackStack.FirstOrDefault().Source.OriginalString;

            if (lastPage.Contains("/Views/Lectures/Lecture.xaml"))
            {
                NavigationService.Navigate(new Uri("/Views/MainView.xaml", UriKind.Relative));
            }
        }

        private void SelectedSession(object sender, SelectionChangedEventArgs e)
        {
            var obj = sender as ListBox;
            var sItem = (Lecture)obj.SelectedItem;

            if (sItem != null)
            {
                NavigationService.Navigate(new Uri("/Views/Lectures/Lecture.xaml?lecture=" + sItem.Name, UriKind.Relative));
            }
        }
    }
}