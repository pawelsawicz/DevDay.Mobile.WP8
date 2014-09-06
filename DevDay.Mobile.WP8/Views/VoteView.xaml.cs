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
using DevDay.Mobile.WP8.Models;
using RestSharp;

namespace DevDay.Mobile.WP8.Views
{
    public partial class VoteView : PhoneApplicationPage
    {
        private ListOfLectures _listofLectures;
        private ListOfSpeakers _listofSpeakers;
        private Lecture _lecture;

        public VoteView()
        {
            _listofLectures = new ListOfLectures();
            _listofSpeakers = new ListOfSpeakers();
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string lecture = "";

            if (NavigationContext.QueryString.TryGetValue("lecture", out lecture))
            {
                _lecture = _listofLectures.Lectures.Where(i => i.Name == lecture).Single();
                var speaker = _listofSpeakers.Speakers.Where(i => i.Name == _lecture.NameOfPresenter).Single();
                ContentPanel.DataContext = _lecture;
                Company.Text = speaker.Company;
                Avatar.DataContext = speaker;
            }
        }

        private void GreenTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //_lecture.CheckVoting();
            Vote(_lecture.IdLecture, 3);

        }
        private void YellowTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Vote(_lecture.IdLecture, 2);
        }
        private void RedTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Vote(_lecture.IdLecture, 1);
        }

        private void Vote(int sid, int rate)
        {
            ResultModel model = new ResultModel();

            var client = new RestClient("http://www.devday.pl");
            var request = new RestRequest("api/vote/", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(new VoteModel
            {
                Sid = sid,
                Rate = rate,
                Debug = false
            });

            var asyncHandler = client.ExecuteAsync<ResultModel>(request, r =>
            {
                if (r.ResponseStatus == ResponseStatus.Completed)
                {
                    if (r.StatusCode == HttpStatusCode.OK)
                    {
                        OnVoteExecute(r.Data);
                    }
                }
            });
        }

        private void OnVoteExecute(ResultModel model)
        {
            switch (model.Result)
            {
                case 1:
                    MessageBox.Show(model.Message + " Your vote has been submited");
                    DataHelper.CreateVote(_lecture);
                    NavigationService.Navigate(new Uri("/View/MainView.xaml", UriKind.Relative));
                    break;
                case -1:
                    MessageBox.Show(model.Message + " Error, please check time of voting! Otherwise please contact with support ");
                    break;
                default:
                    break;
            }
        }
    }
}