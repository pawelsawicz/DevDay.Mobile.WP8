using DevDay.Mobile.WP8.Data.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay.Mobile.WP8.Data.Speakers
{
    public class DanNorth : Speaker
    {
        public DanNorth()
        {
            Name = "Dan North";
            TwitterAccount = "@tastapod";
            Company = "DAN NORTH & ASSOCIATES";
            ImageURL = "/Assets/Images/Speakers/dannorth.png";
            ShortName = "DanNorth";
            Description = "Dan North uses his deep technical and organisational knowledge to help CIOs, business and software teams to deliver quickly and successfully. " +
                "He puts people first and finds simple, pragmatic solutions to business and technical problems, often using lean and agile techniques. " +
                "With over twenty years of experience in IT, Dan is a frequent speaker at technology conferences worldwide. The originator of Behaviour-Driven Development (BDD) " +
                "and Deliberate Discovery, Dan has published feature articles in numerous software and business publications, and contributed to The RSpec Book: Behaviour Driven " +
                "Development with RSpec, Cucumber, and Friends and 97 Things Every Programmer Should Know: Collective Wisdom from the Experts. " +
                "He occasionally blogs at http://dannorth.net/blog.";
            Lectures = new List<Lecture>();
        }
    }
}
