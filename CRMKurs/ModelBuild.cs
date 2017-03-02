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
        public virtual DbSet<EntityClasses.Öğrenci> Öğrenci { get; set; }
        public virtual DbSet<EntityClasses.Öğretmen> Öğretmen { get; set; }
        public virtual DbSet<EntityClasses.Okul> Okul { get; set; }
        public virtual DbSet<EntityClasses.ExtraField> ExtraField {get;set;}
        public virtual DbSet<EntityClasses.MainTypes> MainTypes { get; set; }
    }
}
