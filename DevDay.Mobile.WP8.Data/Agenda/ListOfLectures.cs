﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay.Mobile.WP8.Data.Agenda
{
    public class ListOfLectures
    {
        public List<Lecture> Lectures { get; set; }

        public ListOfLectures()
        {
            Lectures = new List<Lecture>();
        }
    }

    public class CoffeBreak : Lecture
    {
        public CoffeBreak()
        {
            Name = "Coffee!";
            Classroom = "/Assets/Images/neutral_path.png";
            Category = "Neutral";
        }
    }

    public class Registration : Lecture
    {
        public Registration()
        {
            Name = "Registration";
            Time = "8:00 - 9:00";
            Classroom = "/Assets/Images/neutral_path.png";
            Category = "Neutral";
        }
    }

    public class Welcome : Lecture
    {
        public Welcome()
        {
            Name = "Welcome session";
            Time = "9:00 - 9:20";
            Classroom = "/Assets/Images/neutral_path.png";
            Category = "Neutral";
        }
    }

    public class First : Lecture
    {
        public First()
        {
            IdLecture = 1;
            Name = "Software Architecture vs Code";
            Time = "9:20 - 10:10";
            NameOfPresenter = "Simon Brown";
            Classroom = "/Assets/Images/neutral_path.png";
            VoteURL = "/Assets/Images/Vote/blue_tick.png";
            Category = "Neutral";
            Description = "Software architecture and coding are often seen as mutually exclusive disciplines, despite us referring to higher level abstractions when we talk about our software." +
                "You've probably heard others on your team talking about components, services and layers rather than objects when they're having discussions. Take a look at the codebase though." +
                "Can you clearly see these abstractions or does the code reflect some other structure? If so, why is there no clear mapping between the architecture and the code? " +
                "Why do those architecture diagrams that you have on the wall say one thing whereas your code says another? " +
                "In fact, why is it so hard to automatically generate a decent architecture diagram from an existing codebase? " +
                "Join us to explore this topic further.";
        }
    }


}
