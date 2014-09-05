using DevDay.Mobile.WP8.Data.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay.Mobile.WP8.Data.Speakers
{
    public class PeterSmith : Speaker
    {
        public PeterSmith()
        {
            Name = "Peter Smith";
            Company = "ASP.NET & DISTRIBUTED SYSTEMS CONSULTANT";
            ImageURL = "/Assets/Images/Speakers/petersmith.png";
            ShortName = "PeterSmith";
            Description = "Pete is a software consultant based in London with almost 10 years of experience making web applications with ASP.net, specialising in API design, "+
                "JavaScript applications and distributed systems. He is the author of Superscribe "+
                "- a graph based routing framework - and HTTP query library Linq to Querystring among others.";
            Lectures = new List<Lecture>();
        }
    }
}
