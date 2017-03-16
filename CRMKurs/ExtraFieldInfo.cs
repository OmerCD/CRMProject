using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMKurs.EntityClasses;

namespace CRMKurs
{
    class ExtraFieldInfo : EntityClasses.Abstract.EntityIdDefine
    {
        [Required]
        public ExtraField E_Field { get; set; }
        public string Infos { get; set; }
    }

    class ExtraInfo
    {
        private Dictionary<string, string> Infos;
        /// <summary>
        /// PersonId ye göre girilmiş bilgiyi verir.
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        public string this[string personId] => Infos[personId];
        public ExtraInfo(string wholeInfo)
        {
            Infos= new Dictionary<string, string>();
            SeperateInfo(wholeInfo);
        }

        private void SeperateInfo(string wholeInfo)
        {
            bool infoSwitch = true;
            string info = "", personId = "";
            #region Iteration

            foreach (char letter in wholeInfo)
            {
                if (infoSwitch)
                {
                    if (letter!=':')
                    {
                        info += letter;
                    }
                    else
                    {
                        infoSwitch = false;
                    }
                }
                else
                {
                    if (letter!='/')
                    {
                        personId += letter;
                    }
                    else
                    {
                        Infos.Add(personId,info);
                        personId = info = "";
                        infoSwitch = true;
                    }
                }
            }

            #endregion
        }
    }
}
