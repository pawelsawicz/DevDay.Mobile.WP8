using DevDay.Mobile.WP8.Data.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay.Mobile.WP8.Data.Speakers
{
    public class Qi : Speaker
    {
        public Qi()
        {
            Name = "Qi";            
            Company = "THE CODELESS CODE";
            ImageURL = "/Assets/Images/Speakers/qi.png";
            ShortName = "Qi";
            Description = "Qi (not his real name) has been a professional software developer since the days of the Apple II, and an amateur writer and artist since he " +
                "was first able to hold a crayon. By day he works mostly as a designer/developer of Java-based Enterprise systems, but by night he may be found writing or " +
                "illustrating the latest installment of The Codeless Code. Qi has a passion for teaching, and has always considered mentoring the best part of leading a team. " +
                "Although the exaggerated cruelty in some of his stories might lead you to think otherwise, Qi is really quite gentle, and almost never administers fatal beatings.";
            Lectures = new List<Lecture>();
        }
    }
}
