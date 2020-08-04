using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplicWEB.Models
{

    public class Actor
    {

        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public float Rate { get; set; }

        public Actor(long id, string name, string surname,float rate)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Rate = rate;

        }

        public Actor()
        {
        }
    }
}