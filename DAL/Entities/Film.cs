using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    class Film
    {
        #region membres
        public long Id { get; set; }
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
        public string VoteAverage { get; set; }
        public int RunTime { get; set; }
        public string PosterPath { get; set; }
        //public ICollection <CharacterActor> Character { get; set; }

        #endregion

        #region constructeurs
        public Film()
        {
           // Character = new listcharacter;
        }

        public Film(long id, string title, string releaseDate, string voteAverage, int runTime, string posterPath)
        {
            Id = id;
            Title = title;
            ReleaseDate = releaseDate;
            VoteAverage = voteAverage;
            RunTime = runTime;
            PosterPath = posterPath;
        }
        #endregion
    }
}
