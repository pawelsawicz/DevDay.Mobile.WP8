using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay.Mobile.WP8.Data.Agenda
{
    public class Lecture
    {
        public int IdLecture { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Classroom { get; set; }
        public string Time { get; set; }
        public string NameOfPresenter { get; set; }
        public string Category { get; set; }
        public string VoteURL { get; set; }
        public bool IsVoteAble { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public void CheckVoting()
        {
            if (Description != null)
            {
                if ((DateTime.Now > EndTime) && (!DataHelper.ReadVote(this)))
                {
                    IsVoteAble = true;
                }
            }

            IsVoteAble = true;
        }

        public void SetTime()
        {
            var timeArray = Time.Split('-', ':');
            if (Description != null)
            {
                EndTime = new DateTime(2014, 9, 26, int.Parse(timeArray[2]), int.Parse(timeArray[3]), 0);
            }
        }
    }
}
