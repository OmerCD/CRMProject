using System;
using System.ComponentModel.DataAnnotations;
using DesktopAppCRM;

namespace CRMKurs.EntityClasses.Abstract
{
    public abstract class EntityIdDefine
    {
        [Key]
        public string Id { get; set; }
        /// <summary>
        /// Değiştirilmemesi gerekiyor. Tablolardan bilgi çekerken yazılması zorunlu
        /// </summary>
        public string OwnerId { get; set; }

        protected EntityIdDefine()
        {
            Id = Guid.NewGuid().ToString();
            OwnerId = DataBaseConnectionOptions.OwnerUserId;
        }
    }
}
