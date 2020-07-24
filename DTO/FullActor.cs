using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Serializable]
    public class FullActor : Actor
    {
        public ICollection<Character> characters { get; set; }
        public ICollection<Film> Films { get; set; }

        public FullActor(long id, string name , string surname,ICollection<Comment> comment) : base (id,name,surname,comment)
        {
        }

        public FullActor(long id, string name, string surname, ICollection<Comment> comment,ICollection<Film>film,ICollection<Character> character)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Comment = comment;
            characters = character;
            Films = film;   
        }
    }
}
