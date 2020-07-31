using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicWPF
{
    class ActorViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }


        public ActorViewModel(long id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
        public ActorViewModel()
        {

        }
    }
}
