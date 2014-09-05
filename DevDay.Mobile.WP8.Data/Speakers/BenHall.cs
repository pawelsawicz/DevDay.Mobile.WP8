using DevDay.Mobile.WP8.Data.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay.Mobile.WP8.Data.Speakers
{
    public class BenHall : Speaker
    {
        public BenHall()
        {
            Name = "Ben Hall";
            TwitterAccount = "@Ben_Hall";
            Company = "UNICORN, HIPSTER, FOUNDER";
            ImageURL = "/Assets/Images/Speakers/benhall.png";
            ShortName = "benhall";
            Description = "Ben has done the rounds as a tester, developer, speaker, freelancer, startup entrepreneur and most recently working " +
                "at a startup investment company in London. Ben is currently working on his next venture.";
            Lectures = new List<Lecture>();
        }
    }
}
