using DevDay.Mobile.WP8.Data.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay.Mobile.WP8.Data.Speakers
{
    public class KarlHenrikNilsson : Speaker
    {
        public KarlHenrikNilsson()
        {
            Name = "Karl-Henrik Nilsson";
            TwitterAccount = "@KHNilsson";
            Company = "SENIOR DEVELOPER/SOFTWARE ARCHITECT OF SOGETI";
            ImageURL = "/Assets/Images/Speakers/karlhenriknilsson.png";
            ShortName = "karlhenriknilsson";
            Description = "Karl-Henrik is an experienced developer that have written code for anything from cellular network base stations to websites. " +
                "He runs the local Microsoft competence network at Sogeti and spend a somewhat obsessive amount of his free time building smarter devices. " +
                "'If you ever need to see a man about building a smarter toaster - I'm that guy'";
            Lectures = new List<Lecture>();
        }
    }
}
