using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Collections.ObjectModel;
using DevDay.Mobile.WP8.Data.Agenda;
using DevDay.Mobile.WP8.Data;
using DevDay.Mobile.WP8.Data.Speakers;
using Microsoft.Phone.Tasks;

namespace DevDay.Mobile.WP8.Views
{
    public partial class MainView : PhoneApplicationPage
    {
        private ListOfSpeakers _listOfSpeakers;
        //private ListOfLectures _listOfLectures;
        //private ObservableCollection<Lecture> _lectures;

        public MainView()
        {
            _listOfSpeakers = new ListOfSpeakers();
            //_listOfLectures = new ListOfLectures();
            InitializeComponent();

            //AgendaListBox.ItemsSource = _lectures;
            SpeakerListBox.ItemsSource = _listOfSpeakers.Speakers;

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //foreach (var item in _listOfLectures.Lectures)
            //{
            //    item.CheckVoting();
            //}

            //base.OnNavigatedTo(e);
        }

        private void SelectionChange_SpeakerListBox(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;

            if (listBox != null && listBox.SelectedItem != null)
            {
                var sItem = (Speaker)listBox.SelectedItem;

                if (sItem.Name != null)
                {
                    NavigationService.Navigate(new Uri("/View/Speakers/Speaker.xaml?speaker=" + sItem.Name, UriKind.Relative));
                }
            }
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Terminate();
        }

        private void GreenCategorySelected(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //AgendaListBox.ItemsSource = GetGreen();
        }

        private void BlueCategorySelected(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //AgendaListBox.ItemsSource = GetBlue();
        }


        private ObservableCollection<Lecture> GetGreen()
        {
            //var x = _listOfLectures.Lectures.Where(i => (i.Category == "Green" || i.Category == "Neutral" || i.Category == "Blue")).ToList();
            //foreach (var item in x)
            //{
            //    if (item.Category == "Blue")
            //    {
            //        item.Time = string.Empty;
            //    }
            //}
            //_lectures = new ObservableCollection<Lecture>(x);
            //return _lectures;

            return new ObservableCollection<Lecture>();
        }

        private ObservableCollection<Lecture> GetBlue()
        {
            //_lectures = new ObservableCollection<Lecture>(_listOfLectures.Lectures.Where(i => (i.Category == "Blue" || i.Category == "Neutral")).ToList());
            //return _lectures;
            return new ObservableCollection<Lecture>();
        }

        private void LectureTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //TextBlock textBlock = sender as TextBlock;
            //var sItem = (Lecture)(((Grid)((Grid)textBlock.Parent).Parent).DataContext);

            //if (sItem.Name != null && sItem.Description != null && sItem.Name != "TBA")
            //{
            //    NavigationService.Navigate(new Uri("/View/Lectures/Lecture.xaml?lecture=" + sItem.Name, UriKind.Relative));
            //}
        }

        private void VoteTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //Image textBlock = sender as Image;
            //var sItem = (Lecture)(((Grid)((Grid)textBlock.Parent).Parent).DataContext);

            //if (sItem.Name != null && sItem.Description != null && sItem.Name != "TBA")
            //{
            //    NavigationService.Navigate(new Uri("/View/VoteView.xaml?lecture=" + sItem.Name, UriKind.Relative));
            //}
        }

        private void Abb_Logo_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var wbTask = new WebBrowserTask();
            wbTask.Uri = new Uri("http://new.abb.com/pl/centrum-system%C3%B3w-informatycznych-abb", UriKind.RelativeOrAbsolute);
            wbTask.Show();
        }
    }
}