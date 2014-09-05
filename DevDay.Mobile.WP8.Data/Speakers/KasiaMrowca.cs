using DevDay.Mobile.WP8.Data.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay.Mobile.WP8.Data.Speakers
{
    public class KasiaMrowca : Speaker
    {
        public KasiaMrowca()
        {
            Name = "Kasia Mrowca";
            TwitterAccount = "@MrowcaKasia";
            Company = "GEEK GIRL";
            ImageURL = "/Assets/Images/Speakers/kasiamrowca.png";
            ShortName = "KasiaMrowca";
            Description = "Kasia is an IT, management & agile passionate. For Kasia sky is the limit, so she moved to the clouds… and aviation business. "+
                "Currently she works for a factory producing billions of lines of code which magically turn into working software.";
            Lectures = new List<Lecture>();
        }
    }
}
