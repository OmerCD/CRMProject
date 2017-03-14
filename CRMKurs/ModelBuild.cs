using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRMKurs
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    class ModelBuild : DbContext
    {
        static ModelBuild()
        {
            DbConfiguration.SetConfiguration(new MySql.Data.Entity.MySqlEFConfiguration());
        }
        public virtual DbSet<EntityClasses.Person> People { get; set; }
        public virtual DbSet<EntityClasses.Institution> Institutions { get; set; }
        public virtual DbSet<EntityClasses.ExtraField> ExtraField {get;set;}
        public virtual DbSet<EntityClasses.MainTypes> MainTypes { get; set; }
        public virtual DbSet<EntityClasses.Olay> Olaylar { get; set; }
        public virtual DbSet<EntityClasses.MainBoss> Bosses { get; set; }
        public virtual DbSet<EntityClasses.Staff.Worker> Workers { get; set; }
        public virtual DbSet<EntityClasses.PersonTypes> PersonTypes { get; set; }
        public virtual DbSet<EntityClasses.Log> Logs { get; set; }

    }
}
