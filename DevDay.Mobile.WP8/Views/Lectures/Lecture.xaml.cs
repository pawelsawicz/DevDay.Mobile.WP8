using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using DevDay.Mobile.WP8.Data.Speakers;

namespace DevDay.Mobile.WP8.Views.Lectures
{
    public partial class Lecture : PhoneApplicationPage
    {
        public Lecture()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //base.OnNavigatedTo(e);

            //string lecture = "";

            //if (NavigationContext.QueryString.TryGetValue("lecture", out lecture))
            //{
            //    _listofLectures = new ListOfLectures();
            //    _lecture = _listofLectures.Lectures.Where(i => i.Name == lecture).Single();
            //    _listOfSpeakers = new ListOfSpeakers();
            //    var speakerQuery = _listOfSpeakers.Speakers.Where(i => i.Name == _lecture.NameOfPresenter).ToList();
            //    ContentPanel.DataContext = _lecture;
            //    SpeakersInPresentationListBox.ItemsSource = speakerQuery;

            //}
        }

        private void SpeakerSelection(object sender, SelectionChangedEventArgs e)
        {
            var obj = sender as ListBox;
            var sItem = (Speaker)obj.SelectedItem;

            if (sItem != null)
            {
                NavigationService.Navigate(new Uri("/Views/Speakers/Speaker.xaml?speaker=" + sItem.Name, UriKind.Relative));
            }
        }
    }
}