﻿using System;

namespace CRMKurs.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    class PropertyMVC : Attribute
    {
        public string DisplayName { get; set; }
        public ControlEnum DesiredControl { get; set; }
        public object[] Source { get; set; }
        [Obsolete("DisplayName Gir")]
        public PropertyMVC(ControlEnum desiredControl)
        {
            DesiredControl = desiredControl;
        }
        [Obsolete("DisplayName Gir")]
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
        [Obsolete("DisplayName Gir")]
        public PropertyMVC(ControlEnum desiredControl,Type sourceType)
        {
            DesiredControl = desiredControl;
            Source = Enum.GetNames(sourceType);
        }
        public PropertyMVC(string displayName, ControlEnum desiredControl)
        {
            DesiredControl = desiredControl;
            DisplayName = displayName;
        }
        public PropertyMVC(string displayName, ControlEnum desiredControl, params object[] source)
        {
            DesiredControl = desiredControl;
            Source = source;
            DisplayName = displayName;
        }

        /// <summary>
        /// Enum türünde veriler girmek için
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="desiredControl"></param>
        /// <param name="sourceType"></param>
        public PropertyMVC(string displayName, ControlEnum desiredControl, Type sourceType)
        {
            DesiredControl = desiredControl;
            Source = Enum.GetNames(sourceType);
            DisplayName = displayName;
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
