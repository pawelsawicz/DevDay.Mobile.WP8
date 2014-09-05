using DevDay.Mobile.WP8.Data.Speakers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay.Mobile.WP8.Data
{
    public class ListOfSpeakers
    {
        public List<Speaker> Speakers { get; set; }

        public ListOfSpeakers()
        {
            Speakers = new List<Speaker>();            
            var baseClass = typeof(Speaker);
            var classesInAssembly = baseClass.Assembly.GetTypes().Where(t => t.IsSubclassOf(baseClass)).ToList();
            foreach (var speaker in classesInAssembly)
            {
                var createdObject = Activator.CreateInstance(speaker) as Speaker;
                Speakers.Add(createdObject);
            }
        }       
    }
}
