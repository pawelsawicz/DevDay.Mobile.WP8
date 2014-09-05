using DevDay.Mobile.WP8.Data.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay.Mobile.WP8.Data.Speakers
{
    public class EnricoCampidoglio : Speaker
    {
        public EnricoCampidoglio()
        {
            Name = "Enrico Campidoglio";
            TwitterAccount = "@ecampidoglio";
            Company = "TRETTON37";
            ImageURL = "/Assets/Images/Speakers/enricocampidoglio.png";
            ShortName = "enricocampidoglio";
            Description = "Enrico is a programmer who combines a strong passion for quality with a mild OCD. He has spent over a decade in the Microsoft and Java camps, " +
                "striving to write simple and expressive code in whatever language he happens to be using. He’s also a technical trainer and a speaker, who regularly " +
                "presents at conferences and user groups on topics such as Object-oriented design, Test-driven development, Continuous Deployment and, sometimes, mechanical keyboards. " +
                "Enrico is a core contributor to AutoFixture, an open source library for .NET that helps alleviate some of the friction experienced when doing Test-driven " +
                "development by making it easier to generate test data. Enrico works at tretton37 and can be found blogging on megakemp.com or tweeting at @ecampidoglio.";
            Lectures = new List<Lecture>();
        }
    }
}
