using DevDay.Mobile.WP8.Data.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay.Mobile.WP8.Data.Speakers
{
    public class SimonBrown : Speaker
    {
        public SimonBrown()
        {
            Name = "Simon Brown";
            TwitterAccount = "@simonbrown";
            Company = "AUTHOR OF 'SOFTWARE ARCHITECTURE FOR DEVELOPERS'";
            ImageURL = "/Assets/Images/Speakers/simonbrown.png";
            ShortName = "simonbrown";
            Description = "Simon lives in Jersey (the largest of the Channel Islands) and works as an independent consultant, helping teams to build better software. " +
                "His client list spans over 20 countries and includes organisations ranging from small technology startups through to global household names. " +
                "Simon is an award-winning speaker and the author of Software Architecture for Developers - a developer-friendly guide to software architecture, technical leadership and " +
                "the balance with agility. He still codes too.";
            Lectures = new List<Lecture>();
        }
    }
}
