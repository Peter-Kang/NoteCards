using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;
using NoteCards.Models;

namespace challenge.Data
{
    public class NoteCardContext : DbContext
    {
        public NoteCardContext() : base("NoteCardContext")
        {

        }

        public DbSet<NoteCard> NoteCards { get; set; }
    }
}