using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVShow
{
    public class Description
    {
        private int EpisodeNumber { get; set; }
        private TimeSpan EpisodeDuration { get; set; }
        private string EpisodeName { get; set; }

        public Description( int EpisodeNumber, TimeSpan EpisodeDuration, string EpisodeName)
        {
            this.EpisodeNumber = EpisodeNumber;
            this.EpisodeDuration = EpisodeDuration;
            this.EpisodeName = EpisodeName;

        }

        public override string ToString()
        {
            return $"{EpisodeNumber},{EpisodeDuration},{EpisodeName}";
        }

    }
}
