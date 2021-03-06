﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL.Entities
{
    public class Actor
    {
        #region membres
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public ICollection<CharacterActor> CharacterActor { get; set; }
        public ICollection<Comment> Comment { get; set; }

        #endregion


        #region constructeurs
        public Actor()
        {
            Comment = new List<Comment>();
            CharacterActor = new List<CharacterActor>();
        }

        public Actor(long id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Comment = new List<Comment>();
            CharacterActor = new List<CharacterActor>();
        }
        #endregion

         
    }



}
