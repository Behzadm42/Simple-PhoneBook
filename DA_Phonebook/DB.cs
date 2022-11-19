using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE_Phonebook;

namespace DA_Phonebook
{
    class DB:DbContext
    {
        public DB():base("name=phonebook")
            {}
       public DbSet<Phonebook> phonebooks { get; set; }
       
    }
}
