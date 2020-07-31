using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Serializable]
    public class Film
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
        public string VoteAverage { get; set; }
        public int RunTime { get; set; }
        public string PosterPath { get; set; }
        public virtual ICollection<Actor> Actor { get; set; }
        public virtual ICollection<Character> Character { get; set; }


        public Film()
        {
            Character = new List<Character>();
            Actor = new List<Actor>();
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

        public Film(string title)
        {
            Title = title;
        }

    }
}
