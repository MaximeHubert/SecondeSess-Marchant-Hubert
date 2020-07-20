using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    class Actor
    {
        #region membres
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        #endregion


        #region constructeurs
        public Actor()
        {
        }

        public Actor(long id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
        #endregion

         
    }



}
