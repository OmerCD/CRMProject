using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRMKurs.EntityClasses
{
    class ExtraField : Abstract.EntityIdDefine
    {
        [NotMapped]
        public static string[] FieldTypes => new[] {"Tarih","Yazı","Sayı","Para"}; // Seçilebilecek Ekstra alan türleri

        public static string GetFieldTypeName(int fieldNumber)
        {
            switch (fieldNumber)
            {
                case 0:
                    return "DateTime";
                case 1:
                    return "varchar(60)";
                case 2:
                    return "int";
                case 3:
                    return "decimal(8,2)";
                default:
                    throw new StackOverflowException();
            }
        }

        public static string GetGetFieldName(string typeName)
        {
            switch (typeName)
            {
                case "DateTime":
                    return "Tarih";
                case "varchar(60)":
                    return "Yazı";
                case "int":
                    return "Sayı";
                case "decimal(8,2)":
                    return "Para";
                default:
                    throw new KeyNotFoundException();
            }
        }
        public string ExtraName { get; set; }
        /// <summary>
        /// FieldTypes'dan alınacak türün saklanacığı yer.
        /// </summary>
        public string InputType { get; set; } 
        /// <summary>
        /// kullanıcı/kurum veya kişi gibi kişi türleri arasından hangisine gösterileceğini seçmek
        /// </summary>
        public PersonTypes ShowType { get; set; }
    }
}
