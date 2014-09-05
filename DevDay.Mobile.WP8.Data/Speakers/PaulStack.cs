using DevDay.Mobile.WP8.Data.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay.Mobile.WP8.Data.Speakers
{
    public class PaulStack : Speaker
    {
        public PaulStack()
        {
            Name = "Paul Stack";
            Company = "OPENTABLE";
            ImageURL = "/Assets/Images/Speakers/paulstack.png";
            ShortName = "PaulStack";
            Description = "Paul Stack is a London based Infrastructure Engineer working for OpenTable. Paul has spoken at various events throughout the " +
                "world about his passion for continuous integration and continuous delivery and why they should be part of what developers do on a day to day basis." +
                "He believes that reliably delivering software is just as important as its development. Paul’s newest passion is the DevOps movement and how this helps not " +
                "just development and operations but the entire business and it’s customers.";
            Lectures = new List<Lecture>();
        }
    }
}
