using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplicWEB.Models
{
    public class Film
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
        public string RunTime { get; set; }
        public string PosterPath { get; set; }

        public Film( string title, string releaseDate, string runTime, string posterPath)
        {
            Title = title;
            ReleaseDate = releaseDate;
            RunTime = runTime;
            PosterPath = posterPath;
        }

        public Film()
        {
        }
    }
}