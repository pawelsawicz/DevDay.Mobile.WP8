using DevDay.Mobile.WP8.Data.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay.Mobile.WP8.Data.Speakers
{
    public class NiallMerrigan : Speaker
    {
        public NiallMerrigan()
        {
            Name = "Niall Merrigan";
            TwitterAccount = "@nmerrigan";
            Company = "IRISH MAN LOST IN NORWAY";
            ImageURL = "/Assets/Images/Speakers/niallmerrigan.png";
            ShortName = "NiallMerrigan";
            Description = "Niall is an Irish guy who managed to end up in Norway after finding out the country existed when he was in New Zealand. " +
                "He works in Capgemini in Stavanger, Norway as their Head of Custom Software Development, and is also an Microsoft ASP.NET MVP since 2010, Friend Of RedGate " +
                "and general rugby nut (which means he shouts a lot). He has a passion for web technologies, security and whiskey which can lead to some interesting discussions. " +
                "He can be found on twitter as @nmerrigan and hosts a blog at http://www.certsandprogs.com";
            Lectures = new List<Lecture>();
        }
    }
}
