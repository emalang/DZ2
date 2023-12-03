using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVShow
{
    public class Episode
    {
        private int viewers;
        private double scoreSum;
        private double maxScore;
        private Description description;

        public Episode(int viewers, double scoreSum, double maxScore, Description description)
        {
            this.viewers = viewers;
            this.scoreSum = scoreSum;
            this.maxScore = maxScore;
            this.description = description;
        }

        public void AddView(double score)
        {
            this.viewers++;
            if (this.maxScore < score)
            {
                this.maxScore = score;

            }
            this.scoreSum += score;

        }

        public double GetMaxScore()
        {
            return maxScore;

        }

        public double GetAverageScore()
        {
            return this.scoreSum / this.viewers;
        }

        public double GetViewerCount()
        {
            return this.viewers;
        }
        public static bool operator >(Episode lhs, Episode rhs)
        {
            return lhs.GetAverageScore() > rhs.GetAverageScore();
        }

        public static bool operator <(Episode lhs, Episode rhs)
        {
            return lhs.GetAverageScore() < rhs.GetAverageScore();
        }
        public override string ToString()
        {
            return $"{viewers},{GetAverageScore()*10:F2},{maxScore},{description.ToString()}";
        }




    }
}