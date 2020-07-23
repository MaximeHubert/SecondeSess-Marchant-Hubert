using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALDBContext : DbContext
    {
        private static DALDBContext instance = null;

        public DbSet<Film> film { get; set; }
        public DbSet<Actor> actor { get; set; }
        public DbSet<Comment> comment { get; set; }
        public DbSet<Character> character { get; set; }
        public DbSet<CharacterActor> characterActor { get; set; }

        public DALDBContext() : base("MoviesDatabase")
        {
        }

        public static DALDBContext Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DALDBContext();
                }
                return instance;
            }
        }
    }
}
