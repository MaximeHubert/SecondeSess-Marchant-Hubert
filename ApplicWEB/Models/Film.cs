﻿using System;
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
        public int RunTime { get; set; }
        public string PosterPath { get; set; }

        public Film(long id, string title, string releaseDate, int runTime, string posterPath)
        {
            Id = id;
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