using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLManager
    {
        private DALManager Manager;

        public BLLManager()
        {
            Manager = new DALManager();
        }

        public void AddFilm (DTO.Film filmDTO)
        {
            Film filmDAL = new Film(filmDTO.Id, filmDTO.Title, filmDTO.ReleaseDate, filmDTO.VoteAverage, filmDTO.RunTime, filmDTO.PosterPath);

            ICollection<Actor> Actors = new List<Actor>();
            
            foreach(DTO.Actor a in filmDTO.Actor )
            {
                Actors.Add(new Actor(a.Id,a.Name,a.Surname));
            }

            ICollection<Character> Characters = new List<Character>();

            foreach (DTO.Character c in filmDTO.Character)
            {
                Characters.Add(new Character(c.CharacterName));
            }
            Manager.AddFilm(filmDAL, Actors, Characters);


        }
    }
}
