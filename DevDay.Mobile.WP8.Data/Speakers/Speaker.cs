using DevDay.Mobile.WP8.Data.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay.Mobile.WP8.Data.Speakers
{
    public class Speaker
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string TwitterAccount { get; set; }
        public string Company { get; set; }
        public string ImageURL { get; set; }
        public string ShortName { get; set; }
        public IList<Lecture> Lectures { get; set; }
    }
}
