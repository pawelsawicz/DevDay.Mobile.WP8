using DevDay.Mobile.WP8.Data.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay.Mobile.WP8.Data.Speakers
{
    public class SebRose : Speaker
    {
        public SebRose()
        {
            Name = "Seb Rose";
            Company = "FOR EXAMPLES";
            ImageURL = "/Assets/Images/Speakers/sebrose.png";
            ShortName = "SebRose";
            Description = "An independent software developer, trainer and consultant based in the UK. He specialises in working with teams adopting and refining " +
                "their agile practices, with a particular focus on automated testing. Since he first worked as a programmer in 1980 (writing applications in compiled " +
                "BASIC on an Apple II) he has dabbled in many technologies for many companies, including Linn Smart, Amazon and IBM. " +
                "He is writing 'The Cucumber-JVM Book' for the Pragmatic Programmer's.";
            Lectures = new List<Lecture>();
        }
    }
}
