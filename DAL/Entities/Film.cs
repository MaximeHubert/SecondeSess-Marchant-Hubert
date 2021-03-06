﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Film
    {
        #region membres
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
        public string VoteAverage { get; set; }
        public int RunTime { get; set; }
        public string PosterPath { get; set; }
        public ICollection <CharacterActor> CharacterActor { get; set; }

        #endregion

        #region constructeurs
        public Film()
        {
            CharacterActor = new List<CharacterActor>();
        }

        public Film(long id, string title, string releaseDate, string voteAverage, int runTime, string posterPath)
        {
            Id = id;
            Title = title;
            ReleaseDate = releaseDate;
            VoteAverage = voteAverage;
            RunTime = runTime;
            PosterPath = posterPath;
            CharacterActor = new List<CharacterActor>();
        }
        #endregion
    }
}
