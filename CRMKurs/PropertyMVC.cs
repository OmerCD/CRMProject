﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMKurs
{
    [System.AttributeUsage(System.AttributeTargets.Property)]
    class PropertyMVC : Attribute
    {
        public ControlEnum DesiredControl { get; set; }
        public object[] Source { get; set; }

        public PropertyMVC(ControlEnum desiredControl)
        {
            DesiredControl = desiredControl;
        }
        public PropertyMVC(ControlEnum desiredControl,params object[] source)
        {
            DesiredControl = desiredControl;
            Source = source;
        }
        /// <summary>
        /// Enum türünde veriler girmek için
        /// </summary>
        /// <param name="desiredControl"></param>
        /// <param name="sourceType"></param>
        public PropertyMVC(ControlEnum desiredControl,Type sourceType)
        {
            DesiredControl = desiredControl;
            Source = Enum.GetNames(sourceType);
        }

    }

    public enum ControlEnum
    {
        TextBox,
        Combobox,
        MultipleAdder,
        Entity,
        NumericUpDown,
        DateTime,
        MultilineTextBox
    }
}