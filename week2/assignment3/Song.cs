using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Time { get; set; }

        public Song(string artist, string title, string Time)
        {
            Artist = artist;
            Title = title;
            this.Time = Time;
        }
    }
}
