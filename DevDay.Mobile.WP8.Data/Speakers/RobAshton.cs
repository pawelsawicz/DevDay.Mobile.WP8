using DevDay.Mobile.WP8.Data.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay.Mobile.WP8.Data.Speakers
{
    public class RobAshton : Speaker
    {
        public RobAshton()
        {
            Name = "Rob Ashton";
            TwitterAccount = "@robashton";
            Company = "PROFESSIONAL NAYSAYER";
            ImageURL = "/Assets/Images/Speakers/robashton.png";
            ShortName = "robashton";
            Description = "Rob finds himself leaping from technology to technology, striving to put right what once went wrong, " +
                "and hoping each time that his next leap will be the leap to something he actually likes.";
            Lectures = new List<Lecture>();
        }
    }
}
