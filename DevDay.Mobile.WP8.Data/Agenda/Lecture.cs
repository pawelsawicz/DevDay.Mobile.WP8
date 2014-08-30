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
    }
}
