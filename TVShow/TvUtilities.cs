using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVShow
{
    public static class TvUtilities
    {

        public static  double GenerateRandomScore()
        {
            Random randomGenerator = new Random();

            return randomGenerator.NextDouble() * 10;
        }

        public static Episode Parse(string Line)
        {
            string[] episodeParts = Line.Split(',');
            int Viewers = int.Parse(episodeParts[0]);
            double ScoreSum =double.Parse(episodeParts[1], CultureInfo.InvariantCulture);
           
            double MaxScore= double.Parse(episodeParts[2], CultureInfo.InvariantCulture);
            int EpisodeNumber= int.Parse(episodeParts[3]);
            string EpisodeName= episodeParts[5];

            string[] Time= episodeParts[4].Split(':');
            TimeSpan Duration = TimeSpan.Zero;

                int hours = int.Parse(Time[0]);
                int minutes = int.Parse(Time[1]);
                int seconds = int.Parse(Time[2]);
                Duration= TimeSpan.FromHours(hours)+TimeSpan.FromMinutes(minutes)+TimeSpan.FromSeconds(seconds);

            return new Episode(Viewers, ScoreSum, MaxScore, new Description(EpisodeNumber,Duration, EpisodeName));

        }


        
        public static void Sort(Episode[] episodes)
        {
            int index;
            for(int i = 0; i < episodes.Length; i++)
            {
                index = i;
                for(int j=i+1;j< episodes.Length;j++)
                {
                    if (episodes[index].GetAverageScore()< episodes[j].GetAverageScore())
                    {
                        index = j;
                    }
                }

                if (index != i)
                {
                    Episode temp;
                    temp = episodes[i];
                    episodes[i] = episodes[index];
                    episodes[index] = temp;
                }



            }

        }
                   

    }

}

