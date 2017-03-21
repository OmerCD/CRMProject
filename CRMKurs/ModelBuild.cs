using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CRMKurs
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    class ModelBuild : DbContext
    {
        static ModelBuild()
        {
            DbConfiguration.SetConfiguration(new MySql.Data.Entity.MySqlEFConfiguration());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public virtual DbSet<EntityClasses.Person> Person { get; set; }
        public virtual DbSet<EntityClasses.Institution> Institution { get; set; }
        public virtual DbSet<EntityClasses.ExtraField> ExtraField {get;set;}
        public virtual DbSet<EntityClasses.MainTypes> MainTypes { get; set; }
        public virtual DbSet<EntityClasses.Olay> Olay { get; set; }
        public virtual DbSet<EntityClasses.MainBoss> MainBoss { get; set; }
        public virtual DbSet<EntityClasses.Staff.Worker> Worker { get; set; }
        public virtual DbSet<EntityClasses.PersonTypes> PersonTypes { get; set; }
        public virtual DbSet<EntityClasses.Log> Log { get; set; }

    }
}
